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

namespace _9DInfo
{
    public partial class Form9D : Form
    {
        public Form9D()
        {
            InitializeComponent();
            dataGridViewQuality.RowCount = 1;
            dataGridViewSafety.RowCount = 1;
            
        }

        private void ButQuery_Click(object sender, EventArgs e)
        {
            dataGridViewQuality.Rows[0].Cells["ID"].Value = "1234";
            dataGridViewQuality.Rows[0].Cells["EleName"].Value = "结构柱";
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
    }
}
