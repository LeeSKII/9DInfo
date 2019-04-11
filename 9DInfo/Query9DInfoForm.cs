using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Autodesk.Navisworks.Api;

namespace _9DInfo
{
    public partial class Query9DInfoForm : Form
    {
        public static string gStrId;
        public static bool gIsChange;
        public static int gCurTabPageIndex;
        private string sqlConnectInfo = "data source=192.168.0.69;Initial Catalog=ZYCT_Project;User ID=sa;PWD=sasa;";
        public Query9DInfoForm()
        {
            InitializeComponent();
            gStrId = "";
            gIsChange = false;
            gCurTabPageIndex = -1;
        }

        private void ButQuery_Click(object sender, EventArgs e)
        {
            DGV1Quality.Rows.Clear();
            /**操作数据库**/
            SqlConnection con = new SqlConnection(sqlConnectInfo);
            con.Open();
            string sqlCmd = @"SELECT ID,Name,ModifyDate,Describe FROM BIM_QualityInfo";
            SqlCommand cmd = new SqlCommand(sqlCmd, con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            int a = DGV1Quality.Rows.Count;
            for (int i = 0; i < dataSet.Tables[0].Rows.Count;i++)
            {
                DGV1Quality.Rows.Add();
                for (int j = 0; j < dataSet.Tables[0].Columns.Count; j++)
                {                   
                    DGV1Quality.Rows[i].Cells[j].Value = dataSet.Tables[0].Rows[i][j];
                }
            }            
            con.Close();
        }
        //查询数据库中是否存在该ID的记录，有的话选中当前窗口tab页的该行
        private bool HasRecordInSqlTable(string strId)
        {
            //入库查询
            SqlConnection con = new SqlConnection(sqlConnectInfo);
            con.Open();
            string cmdText = @"SELECT * FROM BIM_QualityInfo WHERE ID=" + "'" + strId + "'";
            SqlCommand sqlCommand = new SqlCommand(cmdText, con);
            int count = (int)sqlCommand.ExecuteScalar();//查询数据库中是否有此记录
            if (count > 0)
            {
                TabPage curTabPage = this.TCL1OfQF.SelectedTab;
                foreach (Control control in curTabPage.Controls)
                {
                    if (control is DataGridView)
                    {
                        DataGridView curDgv = (DataGridView)control;
                        for (int i = 0; i < curDgv.Rows.Count; i++)
                        {
                            if (curDgv.Rows[i].Cells[0].Value.ToString() == strId)
                            {
                                curDgv.Rows[i].Selected = true;//设置改行选中
                                curDgv.CurrentCell = curDgv.Rows[i].Cells[0];//焦点到该行
                            }
                        }
                    }
                }
            }
            else
            { 
                return false;
            }
            con.Close();
            return true;
        }
        private void ButQueryModelRecord_Click(object sender, EventArgs e)//查询模型记录
        {
            Document Doc = Autodesk.Navisworks.Api.Application.ActiveDocument;
            ModelItemCollection modelItems = Doc.CurrentSelection.SelectedItems;
            if (modelItems.Count != 1)
            {
                MessageBox.Show("请选择一个构件查询", "提示");
                return;
            }
            ModelItem modelItem = modelItems.First;
            int nId = -1;
            try
            {
                nId = modelItem.PropertyCategories.FindPropertyByDisplayName("元素", "Id").Value.ToInt32();
            }
            catch (Exception ex)
            {
                MessageBox.Show("查询错误" + ex.Message);
                return;
            }
            string strId = nId.ToString();
            if(!HasRecordInSqlTable(strId))//查询并聚焦
                MessageBox.Show("该构件未查询到信息!", "信息");
        }

        private void ButAdd_Click(object sender, EventArgs e)//新增或者修改记录
        {
            //规定只能选择单个构件添加记录
            Document doc = Autodesk.Navisworks.Api.Application.ActiveDocument;
            Selection selection = new Selection();
            selection = doc.CurrentSelection.ToSelection();
            ModelItemCollection modelItems = selection.ExplicitSelection;         

            if(modelItems.Count!=1)
            {
                MessageBox.Show("请只选择一个图元新增记录！");
                return;
            }
            ModelItem modelItem = modelItems.First;
            int nId = -1;
            try
            {
                nId = modelItem.PropertyCategories.FindPropertyByDisplayName("元素", "Id").Value.ToInt32();
            }
            catch (Exception ex)
            {
                MessageBox.Show("查询错误" + ex.Message);
                return;
            }
            string strId = nId.ToString();
            //查询是否有记录，有的话聚焦并选择
            if (HasRecordInSqlTable(strId))
            {
                MessageBox.Show("已有对应记录，显示在表中！", "提示");
            }
            else
            {//弹出新增记录对话框

            }
            //Form9D form9D = new Form9D();
            //form9D.Show();
        }

        private void ButFocus_Click(object sender, EventArgs e)//在NW中选择当前选择记录的
        {
            Document Doc = Autodesk.Navisworks.Api.Application.ActiveDocument;
            TabPage curTabPage = this.TCL1OfQF.SelectedTab;//获取当前选择的tab页面
            string strId = "";
            foreach (Control control in curTabPage.Controls)//遍历控件
            {
                if (control is DataGridView)//如果是datagridview，则在视图中选择元素
                {
                    DataGridView dgv = (DataGridView)control;
                    if (dgv.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("未选中行！");
                        return;
                    }
                    for (int i = 0; i < dgv.SelectedRows.Count; i++)
                    {
                        strId = dgv.SelectedRows[i].Cells[0].Value.ToString();
                    }
                    Search search = new Search();
                    search.Selection.SelectAll();
                    //元素ID是int32类型，所以Displaystring找不到
                    search.SearchConditions.Add(SearchCondition.HasPropertyByDisplayName("元素", "Id").EqualValue(VariantData.FromInt32(Int32.Parse(strId))));

                    ModelItemCollection items = search.FindAll(Doc, true);
                    Doc.CurrentSelection.Clear();
                    Doc.CurrentSelection.CopyFrom(items);
                    if (items.Count > 0)
                    {
                        MessageBox.Show("已在视图中选中该元素！", "提示");
                    }
                }
            }
                       
        }

        private void ButChange_Click(object sender, EventArgs e)
        {
            DataGridView dataGridView1 = new DataGridView();
            int nSelectedRowsCount = 0;
            TabPage curTabPage = this.TCL1OfQF.SelectedTab;
            foreach (Control control in curTabPage.Controls)
            {
                if (control is DataGridView)
                {
                    dataGridView1 = (DataGridView)control;
                    nSelectedRowsCount = dataGridView1.SelectedRows.Count;
                }
            }
            if (nSelectedRowsCount != 1)
            {
                MessageBox.Show("请选则单行数据进行修改", "提示");
            }
            else
            {
                gIsChange = true;
                gStrId = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                gCurTabPageIndex = this.TCL1OfQF.SelectedIndex;
                
                if (gStrId != "")
                {
                    Form9D form9D = new Form9D();
                    form9D.Show();
                }
                else
                {
                    MessageBox.Show("元素ID数据丢失，请检查！", "提示");
                }
            }
        }

        private void ButDelete_Click(object sender, EventArgs e)//从所有表中删除对应记录
        {
            TabPage tabPage = this.TCL1OfQF.SelectedTab;
            foreach (Control control in tabPage.Controls)
            {
                if (control is DataGridView)
                {

                }
            }
        }

        private void DGV1Quality_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MessageBox.Show("双击", "提示");
        }

        private void DGV1Quality_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            TabPage curTabPage = this.TCL1OfQF.SelectedTab;
            string pageName = curTabPage.Text;
            string sId = "",sName="",sModifyDate="",sDescribe="";
            foreach (Control control in curTabPage.Controls)
            {
                if (control is DataGridView)
                {
                    DataGridView dataGridView = (DataGridView)control;
                    int curRowIndex = dataGridView.CurrentCell.RowIndex;
                    sId = dataGridView.Rows[curRowIndex].Cells[0].Value.ToString();
                    sName= dataGridView.Rows[curRowIndex].Cells[1].Value.ToString();
                    sModifyDate = dataGridView.Rows[curRowIndex].Cells[2].Value.ToString();
                    sDescribe = dataGridView.Rows[curRowIndex].Cells[3].Value.ToString();
                }
            }
            string db_tableName="";
            switch (pageName)//表未实现
            {
                case "质量":
                    db_tableName = "BIM_QualityInfo";
                    break;
                case "安全":
                    break;
                case "建造":
                    break;
                case "成本":
                    break;
                case "数据":
                    break;           
            }       
            if (db_tableName == "")
            {
                MessageBox.Show("单元格内修改控件，表组件出现问题，联系管理员", "提示");
                return;
            }
            //链接数据库操作
            string nowDate = DateTime.Now.ToShortDateString();
            try
            {
                SqlConnection con = new SqlConnection(sqlConnectInfo);
                con.Open();
                string cmdText = "UPDATE " +db_tableName+ " SET ModifyDate=" + "'" + nowDate + "'" +
                    "," + "Describe=" + "'" + sDescribe + "'" + " WHERE ID=" + "'" + sId + "'";
                SqlCommand cmd = new SqlCommand(cmdText, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("更改发生错误"+ex.Message, "提示");
            }
        }

        
    }
}
