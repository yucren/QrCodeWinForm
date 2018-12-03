namespace QrCodeWinForm
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.button1 = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.PrintViewBtn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.openQrExcelDg = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UpBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.行号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.料号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.品名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.序列号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.供应商编码DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemMasterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "img1.jpg");
            this.imageList1.Images.SetKeyName(1, "img2.jpg");
            this.imageList1.Images.SetKeyName(2, "img3.jpg");
            this.imageList1.Images.SetKeyName(3, "img4.jpg");
            this.imageList1.Images.SetKeyName(4, "img13.jpg");
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(262, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "打印";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // PrintViewBtn
            // 
            this.PrintViewBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PrintViewBtn.Location = new System.Drawing.Point(383, 392);
            this.PrintViewBtn.Name = "PrintViewBtn";
            this.PrintViewBtn.Size = new System.Drawing.Size(75, 23);
            this.PrintViewBtn.TabIndex = 1;
            this.PrintViewBtn.Text = "打印预览";
            this.PrintViewBtn.UseVisualStyleBackColor = true;
            this.PrintViewBtn.Click += new System.EventHandler(this.PrintViewBtn_Click);
            // 
            // openQrExcelDg
            // 
            this.openQrExcelDg.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.CausesValidation = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.行号DataGridViewTextBoxColumn,
            this.料号DataGridViewTextBoxColumn,
            this.品名DataGridViewTextBoxColumn,
            this.序列号DataGridViewTextBoxColumn,
            this.供应商编码DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.itemMasterBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(617, 361);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // UpBtn
            // 
            this.UpBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.UpBtn.Location = new System.Drawing.Point(143, 392);
            this.UpBtn.Name = "UpBtn";
            this.UpBtn.Size = new System.Drawing.Size(83, 23);
            this.UpBtn.TabIndex = 3;
            this.UpBtn.Text = "上传文件";
            this.UpBtn.UseVisualStyleBackColor = true;
            this.UpBtn.Click += new System.EventHandler(this.UpBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(475, 392);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // 行号DataGridViewTextBoxColumn
            // 
            this.行号DataGridViewTextBoxColumn.DataPropertyName = "行号";
            this.行号DataGridViewTextBoxColumn.HeaderText = "行号";
            this.行号DataGridViewTextBoxColumn.Name = "行号DataGridViewTextBoxColumn";
            // 
            // 料号DataGridViewTextBoxColumn
            // 
            this.料号DataGridViewTextBoxColumn.DataPropertyName = "料号";
            this.料号DataGridViewTextBoxColumn.HeaderText = "料号";
            this.料号DataGridViewTextBoxColumn.Name = "料号DataGridViewTextBoxColumn";
            // 
            // 品名DataGridViewTextBoxColumn
            // 
            this.品名DataGridViewTextBoxColumn.DataPropertyName = "品名";
            this.品名DataGridViewTextBoxColumn.HeaderText = "品名";
            this.品名DataGridViewTextBoxColumn.Name = "品名DataGridViewTextBoxColumn";
            // 
            // 序列号DataGridViewTextBoxColumn
            // 
            this.序列号DataGridViewTextBoxColumn.DataPropertyName = "序列号";
            this.序列号DataGridViewTextBoxColumn.HeaderText = "序列号";
            this.序列号DataGridViewTextBoxColumn.Name = "序列号DataGridViewTextBoxColumn";
            // 
            // 供应商编码DataGridViewTextBoxColumn
            // 
            this.供应商编码DataGridViewTextBoxColumn.DataPropertyName = "供应商编码";
            this.供应商编码DataGridViewTextBoxColumn.HeaderText = "供应商编码";
            this.供应商编码DataGridViewTextBoxColumn.Name = "供应商编码DataGridViewTextBoxColumn";
            // 
            // itemMasterBindingSource
            // 
            this.itemMasterBindingSource.DataSource = typeof(QrCodeWinForm.ItemMaster);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 427);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.UpBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PrintViewBtn);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemMasterBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button PrintViewBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.OpenFileDialog openQrExcelDg;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button UpBtn;
        private System.Windows.Forms.BindingSource itemMasterBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn 行号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 料号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 品名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 序列号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 供应商编码DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
    }
}

