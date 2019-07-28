namespace THSet {
    partial class MainForm {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if(disposing&&(components!=null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.tbAddrX = new System.Windows.Forms.TextBox();
            this.tbAddrY = new System.Windows.Forms.TextBox();
            this.tbOBSXMax = new System.Windows.Forms.TextBox();
            this.TbOBSYMax = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 16;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(109, 104);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(43, 86);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(41, 12);
            this.labelX.TabIndex = 1;
            this.labelX.Text = "label1";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(43, 115);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(41, 12);
            this.labelY.TabIndex = 1;
            this.labelY.Text = "label1";
            // 
            // tbAddrX
            // 
            this.tbAddrX.Location = new System.Drawing.Point(12, 12);
            this.tbAddrX.Name = "tbAddrX";
            this.tbAddrX.Size = new System.Drawing.Size(100, 21);
            this.tbAddrX.TabIndex = 2;
            this.tbAddrX.Text = "0x051E1074";
            // 
            // tbAddrY
            // 
            this.tbAddrY.Location = new System.Drawing.Point(12, 39);
            this.tbAddrY.Name = "tbAddrY";
            this.tbAddrY.Size = new System.Drawing.Size(100, 21);
            this.tbAddrY.TabIndex = 2;
            this.tbAddrY.Text = "0x051E1074";
            // 
            // tbOBSXMax
            // 
            this.tbOBSXMax.Location = new System.Drawing.Point(153, 12);
            this.tbOBSXMax.Name = "tbOBSXMax";
            this.tbOBSXMax.Size = new System.Drawing.Size(100, 21);
            this.tbOBSXMax.TabIndex = 2;
            this.tbOBSXMax.Text = "550";
            // 
            // TbOBSYMax
            // 
            this.TbOBSYMax.Location = new System.Drawing.Point(153, 39);
            this.TbOBSYMax.Name = "TbOBSYMax";
            this.TbOBSYMax.Size = new System.Drawing.Size(100, 21);
            this.TbOBSYMax.TabIndex = 2;
            this.TbOBSYMax.Text = "600";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(265, 152);
            this.Controls.Add(this.TbOBSYMax);
            this.Controls.Add(this.tbAddrY);
            this.Controls.Add(this.tbOBSXMax);
            this.Controls.Add(this.tbAddrX);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.btnStart);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Form1";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        public System.Windows.Forms.TextBox tbAddrX;
        public System.Windows.Forms.TextBox tbOBSXMax;
        public System.Windows.Forms.TextBox tbAddrY;
        public System.Windows.Forms.TextBox TbOBSYMax;
    }
}

