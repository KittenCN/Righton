namespace Righton
{
    partial class form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Main));
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            this.panel_workspace = new System.Windows.Forms.Panel();
            this.btn_insertData = new System.Windows.Forms.Button();
            this.btn_cal = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            this.panel_workspace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Logo
            // 
            this.pb_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pb_Logo.Image")));
            this.pb_Logo.Location = new System.Drawing.Point(3, 4);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(800, 71);
            this.pb_Logo.TabIndex = 0;
            this.pb_Logo.TabStop = false;
            // 
            // panel_workspace
            // 
            this.panel_workspace.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_workspace.BackgroundImage")));
            this.panel_workspace.Controls.Add(this.dataGridView1);
            this.panel_workspace.Controls.Add(this.btn_cal);
            this.panel_workspace.Controls.Add(this.btn_insertData);
            this.panel_workspace.Location = new System.Drawing.Point(3, 82);
            this.panel_workspace.Name = "panel_workspace";
            this.panel_workspace.Size = new System.Drawing.Size(800, 600);
            this.panel_workspace.TabIndex = 1;
            // 
            // btn_insertData
            // 
            this.btn_insertData.Location = new System.Drawing.Point(10, 4);
            this.btn_insertData.Name = "btn_insertData";
            this.btn_insertData.Size = new System.Drawing.Size(115, 51);
            this.btn_insertData.TabIndex = 0;
            this.btn_insertData.Text = "InputExcel";
            this.btn_insertData.UseVisualStyleBackColor = true;
            // 
            // btn_cal
            // 
            this.btn_cal.Location = new System.Drawing.Point(131, 4);
            this.btn_cal.Name = "btn_cal";
            this.btn_cal.Size = new System.Drawing.Size(115, 51);
            this.btn_cal.TabIndex = 1;
            this.btn_cal.Text = "Process";
            this.btn_cal.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(786, 531);
            this.dataGridView1.TabIndex = 2;
            // 
            // form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 687);
            this.Controls.Add(this.panel_workspace);
            this.Controls.Add(this.pb_Logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "form_Main";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            this.panel_workspace.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Logo;
        private System.Windows.Forms.Panel panel_workspace;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_cal;
        private System.Windows.Forms.Button btn_insertData;
    }
}

