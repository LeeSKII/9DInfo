namespace _9DInfo
{
    partial class Query9DInfoForm
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
            this.TCL1OfQF = new System.Windows.Forms.TabControl();
            this.tabPage1Quality = new System.Windows.Forms.TabPage();
            this.DGV1Quality = new System.Windows.Forms.DataGridView();
            this.tabPage2Safety = new System.Windows.Forms.TabPage();
            this.DGV2Safety = new System.Windows.Forms.DataGridView();
            this.C1IDofSafety = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameofSafety = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifyDateofSafety = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.describeofDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3Construct = new System.Windows.Forms.TabPage();
            this.DGV3Construct = new System.Windows.Forms.DataGridView();
            this.tabPage4Cost = new System.Windows.Forms.TabPage();
            this.DGV4Cost = new System.Windows.Forms.DataGridView();
            this.tabPage5Data = new System.Windows.Forms.TabPage();
            this.DGV5Data = new System.Windows.Forms.DataGridView();
            this.ButQuery = new System.Windows.Forms.Button();
            this.ButFocus = new System.Windows.Forms.Button();
            this.ButAdd = new System.Windows.Forms.Button();
            this.ButChange = new System.Windows.Forms.Button();
            this.ButDelete = new System.Windows.Forms.Button();
            this.C1IDofQuality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C2NameofQuality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C3DateofQuality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C4DescribeofQuality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButQueryModelRecord = new System.Windows.Forms.Button();
            this.TCL1OfQF.SuspendLayout();
            this.tabPage1Quality.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1Quality)).BeginInit();
            this.tabPage2Safety.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV2Safety)).BeginInit();
            this.tabPage3Construct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV3Construct)).BeginInit();
            this.tabPage4Cost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV4Cost)).BeginInit();
            this.tabPage5Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV5Data)).BeginInit();
            this.SuspendLayout();
            // 
            // TCL1OfQF
            // 
            this.TCL1OfQF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TCL1OfQF.Controls.Add(this.tabPage1Quality);
            this.TCL1OfQF.Controls.Add(this.tabPage2Safety);
            this.TCL1OfQF.Controls.Add(this.tabPage3Construct);
            this.TCL1OfQF.Controls.Add(this.tabPage4Cost);
            this.TCL1OfQF.Controls.Add(this.tabPage5Data);
            this.TCL1OfQF.Location = new System.Drawing.Point(2, 1);
            this.TCL1OfQF.Name = "TCL1OfQF";
            this.TCL1OfQF.SelectedIndex = 0;
            this.TCL1OfQF.Size = new System.Drawing.Size(795, 441);
            this.TCL1OfQF.TabIndex = 0;
            // 
            // tabPage1Quality
            // 
            this.tabPage1Quality.Controls.Add(this.DGV1Quality);
            this.tabPage1Quality.Location = new System.Drawing.Point(4, 22);
            this.tabPage1Quality.Name = "tabPage1Quality";
            this.tabPage1Quality.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1Quality.Size = new System.Drawing.Size(787, 415);
            this.tabPage1Quality.TabIndex = 0;
            this.tabPage1Quality.Text = "质量";
            this.tabPage1Quality.UseVisualStyleBackColor = true;
            // 
            // DGV1Quality
            // 
            this.DGV1Quality.AllowUserToAddRows = false;
            this.DGV1Quality.AllowUserToDeleteRows = false;
            this.DGV1Quality.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV1Quality.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DGV1Quality.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV1Quality.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C1IDofQuality,
            this.C2NameofQuality,
            this.C3DateofQuality,
            this.C4DescribeofQuality});
            this.DGV1Quality.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV1Quality.Location = new System.Drawing.Point(3, 3);
            this.DGV1Quality.Name = "DGV1Quality";
            this.DGV1Quality.RowTemplate.Height = 23;
            this.DGV1Quality.Size = new System.Drawing.Size(781, 409);
            this.DGV1Quality.TabIndex = 0;
            this.DGV1Quality.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV1Quality_CellEndEdit);
            this.DGV1Quality.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV1Quality_RowHeaderMouseDoubleClick);
            // 
            // tabPage2Safety
            // 
            this.tabPage2Safety.Controls.Add(this.DGV2Safety);
            this.tabPage2Safety.Location = new System.Drawing.Point(4, 22);
            this.tabPage2Safety.Name = "tabPage2Safety";
            this.tabPage2Safety.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2Safety.Size = new System.Drawing.Size(787, 415);
            this.tabPage2Safety.TabIndex = 1;
            this.tabPage2Safety.Text = "安全";
            this.tabPage2Safety.UseVisualStyleBackColor = true;
            // 
            // DGV2Safety
            // 
            this.DGV2Safety.AllowUserToAddRows = false;
            this.DGV2Safety.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV2Safety.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DGV2Safety.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV2Safety.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C1IDofSafety,
            this.nameofSafety,
            this.modifyDateofSafety,
            this.describeofDate});
            this.DGV2Safety.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV2Safety.Location = new System.Drawing.Point(3, 3);
            this.DGV2Safety.Name = "DGV2Safety";
            this.DGV2Safety.ReadOnly = true;
            this.DGV2Safety.RowTemplate.Height = 23;
            this.DGV2Safety.Size = new System.Drawing.Size(781, 409);
            this.DGV2Safety.TabIndex = 0;
            // 
            // C1IDofSafety
            // 
            this.C1IDofSafety.FillWeight = 1F;
            this.C1IDofSafety.HeaderText = "ID";
            this.C1IDofSafety.Name = "C1IDofSafety";
            this.C1IDofSafety.ReadOnly = true;
            // 
            // nameofSafety
            // 
            this.nameofSafety.FillWeight = 1F;
            this.nameofSafety.HeaderText = "名称";
            this.nameofSafety.Name = "nameofSafety";
            this.nameofSafety.ReadOnly = true;
            // 
            // modifyDateofSafety
            // 
            this.modifyDateofSafety.FillWeight = 1F;
            this.modifyDateofSafety.HeaderText = "修改时间";
            this.modifyDateofSafety.Name = "modifyDateofSafety";
            this.modifyDateofSafety.ReadOnly = true;
            // 
            // describeofDate
            // 
            this.describeofDate.FillWeight = 5F;
            this.describeofDate.HeaderText = "说明";
            this.describeofDate.Name = "describeofDate";
            this.describeofDate.ReadOnly = true;
            // 
            // tabPage3Construct
            // 
            this.tabPage3Construct.Controls.Add(this.DGV3Construct);
            this.tabPage3Construct.Location = new System.Drawing.Point(4, 22);
            this.tabPage3Construct.Name = "tabPage3Construct";
            this.tabPage3Construct.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3Construct.Size = new System.Drawing.Size(787, 415);
            this.tabPage3Construct.TabIndex = 2;
            this.tabPage3Construct.Text = "建造";
            this.tabPage3Construct.UseVisualStyleBackColor = true;
            // 
            // DGV3Construct
            // 
            this.DGV3Construct.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DGV3Construct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV3Construct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV3Construct.Location = new System.Drawing.Point(3, 3);
            this.DGV3Construct.Name = "DGV3Construct";
            this.DGV3Construct.RowTemplate.Height = 23;
            this.DGV3Construct.Size = new System.Drawing.Size(781, 409);
            this.DGV3Construct.TabIndex = 0;
            // 
            // tabPage4Cost
            // 
            this.tabPage4Cost.Controls.Add(this.DGV4Cost);
            this.tabPage4Cost.Location = new System.Drawing.Point(4, 22);
            this.tabPage4Cost.Name = "tabPage4Cost";
            this.tabPage4Cost.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4Cost.Size = new System.Drawing.Size(787, 415);
            this.tabPage4Cost.TabIndex = 3;
            this.tabPage4Cost.Text = "成本";
            this.tabPage4Cost.UseVisualStyleBackColor = true;
            // 
            // DGV4Cost
            // 
            this.DGV4Cost.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DGV4Cost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV4Cost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV4Cost.Location = new System.Drawing.Point(3, 3);
            this.DGV4Cost.Name = "DGV4Cost";
            this.DGV4Cost.RowTemplate.Height = 23;
            this.DGV4Cost.Size = new System.Drawing.Size(781, 409);
            this.DGV4Cost.TabIndex = 0;
            // 
            // tabPage5Data
            // 
            this.tabPage5Data.Controls.Add(this.DGV5Data);
            this.tabPage5Data.Location = new System.Drawing.Point(4, 22);
            this.tabPage5Data.Name = "tabPage5Data";
            this.tabPage5Data.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5Data.Size = new System.Drawing.Size(787, 415);
            this.tabPage5Data.TabIndex = 4;
            this.tabPage5Data.Text = "数据";
            this.tabPage5Data.UseVisualStyleBackColor = true;
            // 
            // DGV5Data
            // 
            this.DGV5Data.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DGV5Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV5Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV5Data.Location = new System.Drawing.Point(3, 3);
            this.DGV5Data.Name = "DGV5Data";
            this.DGV5Data.RowTemplate.Height = 23;
            this.DGV5Data.Size = new System.Drawing.Size(781, 409);
            this.DGV5Data.TabIndex = 0;
            // 
            // ButQuery
            // 
            this.ButQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButQuery.Location = new System.Drawing.Point(19, 460);
            this.ButQuery.Name = "ButQuery";
            this.ButQuery.Size = new System.Drawing.Size(75, 23);
            this.ButQuery.TabIndex = 1;
            this.ButQuery.Text = "显示";
            this.ButQuery.UseVisualStyleBackColor = true;
            this.ButQuery.Click += new System.EventHandler(this.ButQuery_Click);
            // 
            // ButFocus
            // 
            this.ButFocus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButFocus.Location = new System.Drawing.Point(132, 460);
            this.ButFocus.Name = "ButFocus";
            this.ButFocus.Size = new System.Drawing.Size(75, 23);
            this.ButFocus.TabIndex = 2;
            this.ButFocus.Text = "关注";
            this.ButFocus.UseVisualStyleBackColor = true;
            this.ButFocus.Click += new System.EventHandler(this.ButFocus_Click);
            // 
            // ButAdd
            // 
            this.ButAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButAdd.Location = new System.Drawing.Point(349, 460);
            this.ButAdd.Name = "ButAdd";
            this.ButAdd.Size = new System.Drawing.Size(75, 23);
            this.ButAdd.TabIndex = 3;
            this.ButAdd.Text = "新增";
            this.ButAdd.UseVisualStyleBackColor = true;
            this.ButAdd.Click += new System.EventHandler(this.ButAdd_Click);
            // 
            // ButChange
            // 
            this.ButChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButChange.Location = new System.Drawing.Point(440, 460);
            this.ButChange.Name = "ButChange";
            this.ButChange.Size = new System.Drawing.Size(75, 23);
            this.ButChange.TabIndex = 4;
            this.ButChange.Text = "修改";
            this.ButChange.UseVisualStyleBackColor = true;
            this.ButChange.Click += new System.EventHandler(this.ButChange_Click);
            // 
            // ButDelete
            // 
            this.ButDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButDelete.Location = new System.Drawing.Point(530, 459);
            this.ButDelete.Name = "ButDelete";
            this.ButDelete.Size = new System.Drawing.Size(75, 23);
            this.ButDelete.TabIndex = 5;
            this.ButDelete.Text = "删除";
            this.ButDelete.UseVisualStyleBackColor = true;
            this.ButDelete.Click += new System.EventHandler(this.ButDelete_Click);
            // 
            // C1IDofQuality
            // 
            this.C1IDofQuality.FillWeight = 1F;
            this.C1IDofQuality.HeaderText = "ID";
            this.C1IDofQuality.Name = "C1IDofQuality";
            this.C1IDofQuality.ReadOnly = true;
            // 
            // C2NameofQuality
            // 
            this.C2NameofQuality.FillWeight = 1F;
            this.C2NameofQuality.HeaderText = "名称";
            this.C2NameofQuality.Name = "C2NameofQuality";
            this.C2NameofQuality.ReadOnly = true;
            // 
            // C3DateofQuality
            // 
            this.C3DateofQuality.FillWeight = 1F;
            this.C3DateofQuality.HeaderText = "修改时间";
            this.C3DateofQuality.Name = "C3DateofQuality";
            this.C3DateofQuality.ReadOnly = true;
            // 
            // C4DescribeofQuality
            // 
            this.C4DescribeofQuality.FillWeight = 5F;
            this.C4DescribeofQuality.HeaderText = "说明";
            this.C4DescribeofQuality.Name = "C4DescribeofQuality";
            // 
            // ButQueryModelRecord
            // 
            this.ButQueryModelRecord.Location = new System.Drawing.Point(229, 460);
            this.ButQueryModelRecord.Name = "ButQueryModelRecord";
            this.ButQueryModelRecord.Size = new System.Drawing.Size(75, 23);
            this.ButQueryModelRecord.TabIndex = 6;
            this.ButQueryModelRecord.Text = "查询";
            this.ButQueryModelRecord.UseVisualStyleBackColor = true;
            this.ButQueryModelRecord.Click += new System.EventHandler(this.ButQueryModelRecord_Click);
            // 
            // Query9DInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.ButQueryModelRecord);
            this.Controls.Add(this.ButDelete);
            this.Controls.Add(this.ButChange);
            this.Controls.Add(this.ButAdd);
            this.Controls.Add(this.ButFocus);
            this.Controls.Add(this.ButQuery);
            this.Controls.Add(this.TCL1OfQF);
            this.Name = "Query9DInfoForm";
            this.Text = "信息总览";
            this.TCL1OfQF.ResumeLayout(false);
            this.tabPage1Quality.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV1Quality)).EndInit();
            this.tabPage2Safety.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV2Safety)).EndInit();
            this.tabPage3Construct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV3Construct)).EndInit();
            this.tabPage4Cost.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV4Cost)).EndInit();
            this.tabPage5Data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV5Data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TCL1OfQF;
        private System.Windows.Forms.TabPage tabPage1Quality;
        private System.Windows.Forms.TabPage tabPage2Safety;
        private System.Windows.Forms.TabPage tabPage3Construct;
        private System.Windows.Forms.TabPage tabPage4Cost;
        private System.Windows.Forms.TabPage tabPage5Data;
        private System.Windows.Forms.DataGridView DGV1Quality;
        private System.Windows.Forms.Button ButQuery;
        private System.Windows.Forms.Button ButFocus;
        private System.Windows.Forms.Button ButAdd;
        private System.Windows.Forms.Button ButChange;
        private System.Windows.Forms.Button ButDelete;
        private System.Windows.Forms.DataGridView DGV2Safety;
        private System.Windows.Forms.DataGridView DGV3Construct;
        private System.Windows.Forms.DataGridView DGV4Cost;
        private System.Windows.Forms.DataGridView DGV5Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn C1IDofSafety;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameofSafety;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifyDateofSafety;
        private System.Windows.Forms.DataGridViewTextBoxColumn describeofDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn C1IDofQuality;
        private System.Windows.Forms.DataGridViewTextBoxColumn C2NameofQuality;
        private System.Windows.Forms.DataGridViewTextBoxColumn C3DateofQuality;
        private System.Windows.Forms.DataGridViewTextBoxColumn C4DescribeofQuality;
        private System.Windows.Forms.Button ButQueryModelRecord;
    }
}