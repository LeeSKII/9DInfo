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
            this.TCLofForm9D = new System.Windows.Forms.TabControl();
            this.tabPage1Quality = new System.Windows.Forms.TabPage();
            this.dataGridViewQuality = new System.Windows.Forms.DataGridView();
            this.eleIdofQuality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameofQuality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifyDateofQuality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.describleofQuality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2Safety = new System.Windows.Forms.TabPage();
            this.dataGridViewSafety = new System.Windows.Forms.DataGridView();
            this.eleIdofSafety = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameofSafety = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifyDateofSafety = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.describeofSafety = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3Construct = new System.Windows.Forms.TabPage();
            this.dataGridViewConstruct = new System.Windows.Forms.DataGridView();
            this.eleIdofConstruct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameofConstruct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifyDateofConstruct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4Cost = new System.Windows.Forms.TabPage();
            this.dataGridViewCost = new System.Windows.Forms.DataGridView();
            this.eleIdofCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameofCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifyDateofCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.describeofCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage5Data = new System.Windows.Forms.TabPage();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.eleIdofData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameofData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifyDateofData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.describeofData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButSelect = new System.Windows.Forms.Button();
            this.ButOK = new System.Windows.Forms.Button();
            this.TCLofForm9D.SuspendLayout();
            this.tabPage1Quality.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuality)).BeginInit();
            this.tabPage2Safety.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSafety)).BeginInit();
            this.tabPage3Construct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConstruct)).BeginInit();
            this.tabPage4Cost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCost)).BeginInit();
            this.tabPage5Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            this.SuspendLayout();
            // 
            // TCLofForm9D
            // 
            this.TCLofForm9D.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TCLofForm9D.Controls.Add(this.tabPage1Quality);
            this.TCLofForm9D.Controls.Add(this.tabPage2Safety);
            this.TCLofForm9D.Controls.Add(this.tabPage3Construct);
            this.TCLofForm9D.Controls.Add(this.tabPage4Cost);
            this.TCLofForm9D.Controls.Add(this.tabPage5Data);
            this.TCLofForm9D.Location = new System.Drawing.Point(12, 12);
            this.TCLofForm9D.Name = "TCLofForm9D";
            this.TCLofForm9D.SelectedIndex = 0;
            this.TCLofForm9D.Size = new System.Drawing.Size(776, 106);
            this.TCLofForm9D.TabIndex = 0;
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
            this.dataGridViewQuality.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuality.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eleIdofQuality,
            this.nameofQuality,
            this.modifyDateofQuality,
            this.describleofQuality});
            this.dataGridViewQuality.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewQuality.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewQuality.Name = "dataGridViewQuality";
            this.dataGridViewQuality.RowTemplate.Height = 23;
            this.dataGridViewQuality.Size = new System.Drawing.Size(762, 74);
            this.dataGridViewQuality.TabIndex = 0;
            // 
            // eleIdofQuality
            // 
            this.eleIdofQuality.HeaderText = "ID";
            this.eleIdofQuality.Name = "eleIdofQuality";
            this.eleIdofQuality.ReadOnly = true;
            // 
            // nameofQuality
            // 
            this.nameofQuality.FillWeight = 150F;
            this.nameofQuality.HeaderText = "名称";
            this.nameofQuality.Name = "nameofQuality";
            this.nameofQuality.ReadOnly = true;
            this.nameofQuality.Width = 150;
            // 
            // modifyDateofQuality
            // 
            this.modifyDateofQuality.HeaderText = "修改时间";
            this.modifyDateofQuality.Name = "modifyDateofQuality";
            this.modifyDateofQuality.ReadOnly = true;
            // 
            // describleofQuality
            // 
            this.describleofQuality.FillWeight = 500F;
            this.describleofQuality.HeaderText = "说明";
            this.describleofQuality.Name = "describleofQuality";
            this.describleofQuality.Width = 500;
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
            this.eleIdofSafety,
            this.nameofSafety,
            this.modifyDateofSafety,
            this.describeofSafety});
            this.dataGridViewSafety.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSafety.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewSafety.Name = "dataGridViewSafety";
            this.dataGridViewSafety.RowTemplate.Height = 23;
            this.dataGridViewSafety.Size = new System.Drawing.Size(762, 74);
            this.dataGridViewSafety.TabIndex = 0;
            // 
            // eleIdofSafety
            // 
            this.eleIdofSafety.HeaderText = "ID";
            this.eleIdofSafety.Name = "eleIdofSafety";
            // 
            // nameofSafety
            // 
            this.nameofSafety.HeaderText = "名称";
            this.nameofSafety.Name = "nameofSafety";
            this.nameofSafety.Width = 150;
            // 
            // modifyDateofSafety
            // 
            this.modifyDateofSafety.HeaderText = "修改时间";
            this.modifyDateofSafety.Name = "modifyDateofSafety";
            // 
            // describeofSafety
            // 
            this.describeofSafety.HeaderText = "说明";
            this.describeofSafety.Name = "describeofSafety";
            this.describeofSafety.Width = 500;
            // 
            // tabPage3Construct
            // 
            this.tabPage3Construct.Controls.Add(this.dataGridViewConstruct);
            this.tabPage3Construct.Location = new System.Drawing.Point(4, 22);
            this.tabPage3Construct.Name = "tabPage3Construct";
            this.tabPage3Construct.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3Construct.Size = new System.Drawing.Size(768, 80);
            this.tabPage3Construct.TabIndex = 2;
            this.tabPage3Construct.Text = "建造";
            this.tabPage3Construct.UseVisualStyleBackColor = true;
            // 
            // dataGridViewConstruct
            // 
            this.dataGridViewConstruct.AllowUserToAddRows = false;
            this.dataGridViewConstruct.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewConstruct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConstruct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eleIdofConstruct,
            this.nameofConstruct,
            this.modifyDateofConstruct,
            this.Column1});
            this.dataGridViewConstruct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewConstruct.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewConstruct.Name = "dataGridViewConstruct";
            this.dataGridViewConstruct.RowTemplate.Height = 23;
            this.dataGridViewConstruct.Size = new System.Drawing.Size(762, 74);
            this.dataGridViewConstruct.TabIndex = 0;
            // 
            // eleIdofConstruct
            // 
            this.eleIdofConstruct.HeaderText = "ID";
            this.eleIdofConstruct.Name = "eleIdofConstruct";
            // 
            // nameofConstruct
            // 
            this.nameofConstruct.HeaderText = "名称";
            this.nameofConstruct.Name = "nameofConstruct";
            this.nameofConstruct.Width = 150;
            // 
            // modifyDateofConstruct
            // 
            this.modifyDateofConstruct.HeaderText = "修改时间";
            this.modifyDateofConstruct.Name = "modifyDateofConstruct";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "说明";
            this.Column1.Name = "Column1";
            this.Column1.Width = 500;
            // 
            // tabPage4Cost
            // 
            this.tabPage4Cost.Controls.Add(this.dataGridViewCost);
            this.tabPage4Cost.Location = new System.Drawing.Point(4, 22);
            this.tabPage4Cost.Name = "tabPage4Cost";
            this.tabPage4Cost.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4Cost.Size = new System.Drawing.Size(768, 80);
            this.tabPage4Cost.TabIndex = 3;
            this.tabPage4Cost.Text = "成本";
            this.tabPage4Cost.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCost
            // 
            this.dataGridViewCost.AllowUserToAddRows = false;
            this.dataGridViewCost.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewCost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCost.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eleIdofCost,
            this.nameofCost,
            this.modifyDateofCost,
            this.describeofCost});
            this.dataGridViewCost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCost.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewCost.Name = "dataGridViewCost";
            this.dataGridViewCost.RowTemplate.Height = 23;
            this.dataGridViewCost.Size = new System.Drawing.Size(762, 74);
            this.dataGridViewCost.TabIndex = 0;
            // 
            // eleIdofCost
            // 
            this.eleIdofCost.HeaderText = "ID";
            this.eleIdofCost.Name = "eleIdofCost";
            this.eleIdofCost.ReadOnly = true;
            // 
            // nameofCost
            // 
            this.nameofCost.HeaderText = "名称";
            this.nameofCost.Name = "nameofCost";
            this.nameofCost.ReadOnly = true;
            this.nameofCost.Width = 150;
            // 
            // modifyDateofCost
            // 
            this.modifyDateofCost.HeaderText = "修改时间";
            this.modifyDateofCost.Name = "modifyDateofCost";
            this.modifyDateofCost.ReadOnly = true;
            // 
            // describeofCost
            // 
            this.describeofCost.HeaderText = "说明";
            this.describeofCost.Name = "describeofCost";
            this.describeofCost.Width = 500;
            // 
            // tabPage5Data
            // 
            this.tabPage5Data.Controls.Add(this.dataGridViewData);
            this.tabPage5Data.Location = new System.Drawing.Point(4, 22);
            this.tabPage5Data.Name = "tabPage5Data";
            this.tabPage5Data.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5Data.Size = new System.Drawing.Size(768, 80);
            this.tabPage5Data.TabIndex = 4;
            this.tabPage5Data.Text = "数据";
            this.tabPage5Data.UseVisualStyleBackColor = true;
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.AllowUserToAddRows = false;
            this.dataGridViewData.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eleIdofData,
            this.nameofData,
            this.modifyDateofData,
            this.describeofData});
            this.dataGridViewData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewData.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.RowTemplate.Height = 23;
            this.dataGridViewData.Size = new System.Drawing.Size(762, 74);
            this.dataGridViewData.TabIndex = 0;
            // 
            // eleIdofData
            // 
            this.eleIdofData.HeaderText = "ID";
            this.eleIdofData.Name = "eleIdofData";
            this.eleIdofData.ReadOnly = true;
            // 
            // nameofData
            // 
            this.nameofData.HeaderText = "名称";
            this.nameofData.Name = "nameofData";
            this.nameofData.ReadOnly = true;
            this.nameofData.Width = 150;
            // 
            // modifyDateofData
            // 
            this.modifyDateofData.HeaderText = "修改时间";
            this.modifyDateofData.Name = "modifyDateofData";
            this.modifyDateofData.ReadOnly = true;
            // 
            // describeofData
            // 
            this.describeofData.HeaderText = "说明";
            this.describeofData.Name = "describeofData";
            this.describeofData.Width = 500;
            // 
            // ButSelect
            // 
            this.ButSelect.Location = new System.Drawing.Point(176, 139);
            this.ButSelect.Name = "ButSelect";
            this.ButSelect.Size = new System.Drawing.Size(75, 23);
            this.ButSelect.TabIndex = 2;
            this.ButSelect.Text = "关注";
            this.ButSelect.UseVisualStyleBackColor = true;
            this.ButSelect.Click += new System.EventHandler(this.ButSelect_Click);
            // 
            // ButOK
            // 
            this.ButOK.Location = new System.Drawing.Point(50, 139);
            this.ButOK.Name = "ButOK";
            this.ButOK.Size = new System.Drawing.Size(75, 23);
            this.ButOK.TabIndex = 3;
            this.ButOK.Text = "确认";
            this.ButOK.UseVisualStyleBackColor = true;
            this.ButOK.Click += new System.EventHandler(this.ButOK_Click);
            // 
            // Form9D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 171);
            this.Controls.Add(this.ButOK);
            this.Controls.Add(this.ButSelect);
            this.Controls.Add(this.TCLofForm9D);
            this.Name = "Form9D";
            this.Text = "Form9D";
            this.Load += new System.EventHandler(this.Form9D_Load);
            this.TCLofForm9D.ResumeLayout(false);
            this.tabPage1Quality.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuality)).EndInit();
            this.tabPage2Safety.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSafety)).EndInit();
            this.tabPage3Construct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConstruct)).EndInit();
            this.tabPage4Cost.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCost)).EndInit();
            this.tabPage5Data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TCLofForm9D;
        private System.Windows.Forms.TabPage tabPage1Quality;
        private System.Windows.Forms.TabPage tabPage2Safety;
        private System.Windows.Forms.TabPage tabPage3Construct;
        private System.Windows.Forms.TabPage tabPage4Cost;
        private System.Windows.Forms.TabPage tabPage5Data;
        private System.Windows.Forms.DataGridView dataGridViewSafety;
        private System.Windows.Forms.DataGridView dataGridViewConstruct;
        private System.Windows.Forms.Button ButSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn eleIdofSafety;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameofSafety;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifyDateofSafety;
        private System.Windows.Forms.DataGridViewTextBoxColumn describeofSafety;
        private System.Windows.Forms.DataGridViewTextBoxColumn eleIdofConstruct;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameofConstruct;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifyDateofConstruct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dataGridViewCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn eleIdofCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameofCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifyDateofCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn describeofCost;
        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.DataGridViewTextBoxColumn eleIdofData;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameofData;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifyDateofData;
        private System.Windows.Forms.DataGridViewTextBoxColumn describeofData;
        private System.Windows.Forms.Button ButOK;
        private System.Windows.Forms.DataGridView dataGridViewQuality;
        private System.Windows.Forms.DataGridViewTextBoxColumn eleIdofQuality;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameofQuality;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifyDateofQuality;
        private System.Windows.Forms.DataGridViewTextBoxColumn describleofQuality;
    }
}