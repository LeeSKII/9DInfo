namespace _9DInfo
{
    partial class Form9D
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControlInfo = new System.Windows.Forms.TabControl();
            this.tabPage1Quality = new System.Windows.Forms.TabPage();
            this.dataGridViewQuality = new System.Windows.Forms.DataGridView();
            this.tabPage2Safety = new System.Windows.Forms.TabPage();
            this.dataGridViewSafety = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.ButQuery = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.person = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButSelect = new System.Windows.Forms.Button();
            this.tabControlInfo.SuspendLayout();
            this.tabPage1Quality.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuality)).BeginInit();
            this.tabPage2Safety.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSafety)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlInfo
            // 
            this.tabControlInfo.Controls.Add(this.tabPage1Quality);
            this.tabControlInfo.Controls.Add(this.tabPage2Safety);
            this.tabControlInfo.Controls.Add(this.tabPage3);
            this.tabControlInfo.Controls.Add(this.tabPage4);
            this.tabControlInfo.Controls.Add(this.tabPage5);
            this.tabControlInfo.Location = new System.Drawing.Point(12, 12);
            this.tabControlInfo.Name = "tabControlInfo";
            this.tabControlInfo.SelectedIndex = 0;
            this.tabControlInfo.Size = new System.Drawing.Size(776, 106);
            this.tabControlInfo.TabIndex = 0;
            // 
            // tabPage1Quality
            // 
            this.tabPage1Quality.Controls.Add(this.dataGridViewQuality);
            this.tabPage1Quality.Location = new System.Drawing.Point(4, 22);
            this.tabPage1Quality.Name = "tabPage1Quality";
            this.tabPage1Quality.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1Quality.Size = new System.Drawing.Size(768, 80);
            this.tabPage1Quality.TabIndex = 0;
            this.tabPage1Quality.Text = "质量";
            this.tabPage1Quality.UseVisualStyleBackColor = true;
            // 
            // dataGridViewQuality
            // 
            this.dataGridViewQuality.AllowUserToAddRows = false;
            this.dataGridViewQuality.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewQuality.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewQuality.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewQuality.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuality.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.EleName,
            this.person,
            this.info});
            this.dataGridViewQuality.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewQuality.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewQuality.Name = "dataGridViewQuality";
            this.dataGridViewQuality.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewQuality.RowTemplate.Height = 23;
            this.dataGridViewQuality.Size = new System.Drawing.Size(762, 74);
            this.dataGridViewQuality.TabIndex = 0;
            // 
            // tabPage2Safety
            // 
            this.tabPage2Safety.Controls.Add(this.dataGridViewSafety);
            this.tabPage2Safety.Location = new System.Drawing.Point(4, 22);
            this.tabPage2Safety.Name = "tabPage2Safety";
            this.tabPage2Safety.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2Safety.Size = new System.Drawing.Size(768, 80);
            this.tabPage2Safety.TabIndex = 1;
            this.tabPage2Safety.Text = "安全";
            this.tabPage2Safety.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSafety
            // 
            this.dataGridViewSafety.AllowUserToAddRows = false;
            this.dataGridViewSafety.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewSafety.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSafety.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridViewSafety.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSafety.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewSafety.Name = "dataGridViewSafety";
            this.dataGridViewSafety.RowTemplate.Height = 23;
            this.dataGridViewSafety.Size = new System.Drawing.Size(762, 74);
            this.dataGridViewSafety.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "a";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "b";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "c";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "d";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "e";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "f";
            this.Column6.Name = "Column6";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 80);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(762, 74);
            this.dataGridView2.TabIndex = 0;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "a";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "b";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "c";
            this.Column9.Name = "Column9";
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(768, 80);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(768, 80);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // ButQuery
            // 
            this.ButQuery.Location = new System.Drawing.Point(42, 141);
            this.ButQuery.Name = "ButQuery";
            this.ButQuery.Size = new System.Drawing.Size(75, 23);
            this.ButQuery.TabIndex = 1;
            this.ButQuery.Text = "查询";
            this.ButQuery.UseVisualStyleBackColor = true;
            this.ButQuery.Click += new System.EventHandler(this.ButQuery_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "构件ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.ToolTipText = "三维模型的构件ID标志符";
            // 
            // EleName
            // 
            this.EleName.HeaderText = "构件名称";
            this.EleName.Name = "EleName";
            this.EleName.ReadOnly = true;
            // 
            // person
            // 
            this.person.HeaderText = "责任人";
            this.person.Name = "person";
            // 
            // info
            // 
            this.info.HeaderText = "备注";
            this.info.Name = "info";
            this.info.Width = 500;
            // 
            // ButSelect
            // 
            this.ButSelect.Location = new System.Drawing.Point(383, 140);
            this.ButSelect.Name = "ButSelect";
            this.ButSelect.Size = new System.Drawing.Size(75, 23);
            this.ButSelect.TabIndex = 2;
            this.ButSelect.Text = "选择";
            this.ButSelect.UseVisualStyleBackColor = true;
            this.ButSelect.Click += new System.EventHandler(this.ButSelect_Click);
            // 
            // Form9D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 231);
            this.Controls.Add(this.ButSelect);
            this.Controls.Add(this.ButQuery);
            this.Controls.Add(this.tabControlInfo);
            this.Name = "Form9D";
            this.Text = "Form9D";
            this.tabControlInfo.ResumeLayout(false);
            this.tabPage1Quality.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuality)).EndInit();
            this.tabPage2Safety.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSafety)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlInfo;
        private System.Windows.Forms.TabPage tabPage1Quality;
        private System.Windows.Forms.DataGridView dataGridViewQuality;
        private System.Windows.Forms.TabPage tabPage2Safety;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dataGridViewSafety;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Button ButQuery;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn person;
        private System.Windows.Forms.DataGridViewTextBoxColumn info;
        private System.Windows.Forms.Button ButSelect;
    }
}