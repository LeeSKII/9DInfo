using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Autodesk.Navisworks.Api;
using System.Data.SqlClient;

namespace _9DInfo
{
    public partial class Form9D : Form
    {
        string strId; string strName;
        public Form9D()
        {
            InitializeComponent();
            
            dataGridViewQuality.RowCount = 1;
            dataGridViewSafety.RowCount = 1;
            dataGridViewConstruct.RowCount = 1;
            dataGridViewCost.RowCount = 1;
            dataGridViewData.RowCount = 1;
        }   

        private void ButSelect_Click(object sender, EventArgs e)
        {
            Document oDoc = Autodesk.Navisworks.Api.Application.ActiveDocument;
            
            Search search = new Search();
            search.Selection.SelectAll();
            //元素ID是int32类型，所以Displaystring找不到
            search.SearchConditions.Add(SearchCondition.HasPropertyByDisplayName("元素", "Id").EqualValue(VariantData.FromInt32(1243755)));
            
            ModelItemCollection items = search.FindAll(oDoc, true);
            
            if (items.Count == 0)
            {
                MessageBox.Show("未找到目标！");
                return;
            }
            oDoc.CurrentSelection.CopyFrom(items);
        }

        private void Form9D_Load(object sender, EventArgs e)//载入窗体时
        {
            if (Query9DInfoForm.gIsChange)//点击的是change按钮
            {//从数据库中取数据
                string Id = Query9DInfoForm.gStrId;
                int tabPageIndex = Query9DInfoForm.gCurTabPageIndex;//传递当前修改页名称，以获取对应修改数据
                this.TCLofForm9D.SelectedIndex = tabPageIndex;//选中该页

                string loadInfo = "data source=192.168.0.69;Initial Catalog=ZYCT_Project;User ID=sa;PWD=sasa;";
                SqlConnection con = new SqlConnection(loadInfo);
                con.Open();
                string strCmd = @"SELECT ID,Name,ModifyDate,Describe FROM BIM_QualityInfo WHERE ID="+"'"+Id+"'";
                SqlCommand sqlCommand = new SqlCommand(strCmd, con);
                SqlDataReader reader;
                try
                {
                    reader = sqlCommand.ExecuteReader();
                    reader.Read();//只读唯一的一条记录
                }
                catch (Exception ex)
                {
                    MessageBox.Show("数据库数据加载错误信息" + ex.Message);
                    return;
                }
                List<string> infoListOfQuality = new List<string>();
                strId = reader.GetInt32(reader.GetOrdinal("ID")).ToString();
                infoListOfQuality.Add(strId);
                strName = reader.GetString(reader.GetOrdinal("Name"));
                infoListOfQuality.Add(strName);              
                if (reader.IsDBNull(reader.GetOrdinal("ModifyDate")))//db中是否有数据
                    infoListOfQuality.Add("");                
                else
                    infoListOfQuality.Add(reader.GetString(reader.GetOrdinal("ModifyDate")));
                if (reader.IsDBNull(reader.GetOrdinal("Describe")))
                    infoListOfQuality.Add("");
                else                    
                    infoListOfQuality.Add(reader.GetString(reader.GetOrdinal("Describe")));

                
                for (int i = 0; i < infoListOfQuality.Count; i++)
                {
                    this.dataGridViewQuality.Rows[0].Cells[i].Value = infoListOfQuality[i];
                }



                con.Close();
                //主窗口参数还原
                Query9DInfoForm.gStrId = "";
                Query9DInfoForm.gIsChange = false;
                Query9DInfoForm.gCurTabPageIndex = -1;
            }
            else//点击的是新增按钮，从模型中取数据
            {
                Document doc = Autodesk.Navisworks.Api.Application.ActiveDocument;
                Selection selection = new Selection();
                selection = doc.CurrentSelection.ToSelection();
                ModelItemCollection modelItems = selection.ExplicitSelection;
                ModelItem item = modelItems.First;
                try
                {
                    strId = item.PropertyCategories.FindPropertyByDisplayName("元素", "Id").Value.ToInt32().ToString();
                    strName = item.PropertyCategories.FindPropertyByDisplayName("元素", "名称").Value.ToDisplayString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " 请联系管理员！", "程序异常");
                }
                dataGridViewQuality.Rows[0].Cells[0].Value = dataGridViewSafety.Rows[0].Cells[0].Value =
                    dataGridViewConstruct.Rows[0].Cells[0].Value = dataGridViewCost.Rows[0].Cells[0].Value
                    = dataGridViewData.Rows[0].Cells[0].Value = strId;
                dataGridViewQuality.Rows[0].Cells[1].Value = dataGridViewSafety.Rows[0].Cells[1].Value =
                    dataGridViewConstruct.Rows[0].Cells[1].Value = dataGridViewCost.Rows[0].Cells[1].Value
                    = dataGridViewData.Rows[0].Cells[1].Value = strName;
                dataGridViewQuality.Rows[0].Cells[2].Value = dataGridViewSafety.Rows[0].Cells[2].Value =
                     dataGridViewConstruct.Rows[0].Cells[2].Value = dataGridViewCost.Rows[0].Cells[2].Value
                     = dataGridViewData.Rows[0].Cells[2].Value = DateTime.Now.ToString();
            }
            
        }

        private void ButOK_Click(object sender, EventArgs e)//确认提交数据库
        {
            string strNowDate = DateTime.Now.ToShortDateString();
            string loadInfo = "data source=192.168.0.69;Initial Catalog=ZYCT_Project;User ID=sa;PWD=sasa;";
            SqlConnection con = new SqlConnection(loadInfo);
            con.Open();
            string strDescribeQuality = "";
            if (dataGridViewQuality.Rows[0].Cells[3].Value!=null)
                strDescribeQuality = dataGridViewQuality.Rows[0].Cells[3].Value.ToString();
            string sqlCmd = @"IF NOT EXISTS(SELECT ID FROM BIM_QualityInfo WHERE ID =" + "'" + strId + "')"
                +@"INSERT INTO BIM_QualityInfo(ID,Name,ModifyDate,Describe) VALUES " +
                "(" +"'"+ strId +"'"+ "," +"'"+ strName +"'"+ "," +"'"+ strNowDate +"'"+ "," +"'"+ strDescribeQuality +"'"+ ")"
                + @"ELSE UPDATE BIM_QualityInfo SET ModifyDate="+"'"+strNowDate+"'"+","+ "Describe="+"'"+ strDescribeQuality+"'"
                +"WHERE ID="+"'"+strId+"'";
            SqlCommand cmdQuality = new SqlCommand(sqlCmd, con);
            try
            {
                cmdQuality.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("提交错误：" + ex.Message);
                return;
            }
            con.Close();
            MessageBox.Show("提交成功");
            this.Close();
        }

    }
}
