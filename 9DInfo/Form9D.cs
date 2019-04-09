using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
