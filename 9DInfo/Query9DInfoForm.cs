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

namespace _9DInfo
{
    public partial class Query9DInfoForm : Form
    {
        public Query9DInfoForm()
        {
            InitializeComponent();
        }

        private void ButQuery_Click(object sender, EventArgs e)
        {
            /**操作数据库**/
            string loadInfo = "data source=192.168.0.69;Initial Catalog=ZYCT_Project;User ID=sa;PWD=sasa;";
            SqlConnection con = new SqlConnection(loadInfo);
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


    }
}
