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
            this.btn_aboutme = new System.Windows.Forms.Button();
            this.lab_Result = new System.Windows.Forms.Label();
            this.dgv_Gene_Process = new System.Windows.Forms.DataGridView();
            this.dgv_Gene_Ori = new System.Windows.Forms.DataGridView();
            this.btn_cal = new System.Windows.Forms.Button();
            this.btn_insertData = new System.Windows.Forms.Button();
            this.pb_foot = new System.Windows.Forms.PictureBox();
            this.Gene = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            this.panel_workspace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Gene_Process)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Gene_Ori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_foot)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Logo
            // 
            this.pb_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pb_Logo.Image")));
            this.pb_Logo.Location = new System.Drawing.Point(4, 5);
            this.pb_Logo.Margin = new System.Windows.Forms.Padding(4);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(1067, 95);
            this.pb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Logo.TabIndex = 0;
            this.pb_Logo.TabStop = false;
            // 
            // panel_workspace
            // 
            this.panel_workspace.Controls.Add(this.btn_aboutme);
            this.panel_workspace.Controls.Add(this.lab_Result);
            this.panel_workspace.Controls.Add(this.dgv_Gene_Process);
            this.panel_workspace.Controls.Add(this.dgv_Gene_Ori);
            this.panel_workspace.Controls.Add(this.btn_cal);
            this.panel_workspace.Controls.Add(this.btn_insertData);
            this.panel_workspace.Location = new System.Drawing.Point(4, 109);
            this.panel_workspace.Margin = new System.Windows.Forms.Padding(4);
            this.panel_workspace.Name = "panel_workspace";
            this.panel_workspace.Size = new System.Drawing.Size(1079, 898);
            this.panel_workspace.TabIndex = 1;
            // 
            // btn_aboutme
            // 
            this.btn_aboutme.Location = new System.Drawing.Point(908, 4);
            this.btn_aboutme.Margin = new System.Windows.Forms.Padding(4);
            this.btn_aboutme.Name = "btn_aboutme";
            this.btn_aboutme.Size = new System.Drawing.Size(153, 68);
            this.btn_aboutme.TabIndex = 5;
            this.btn_aboutme.Text = "AboutMe";
            this.btn_aboutme.UseVisualStyleBackColor = true;
            this.btn_aboutme.Visible = false;
            this.btn_aboutme.Click += new System.EventHandler(this.btn_aboutme_Click);
            // 
            // lab_Result
            // 
            this.lab_Result.AutoSize = true;
            this.lab_Result.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Result.ForeColor = System.Drawing.Color.Red;
            this.lab_Result.Location = new System.Drawing.Point(396, 5);
            this.lab_Result.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_Result.Name = "lab_Result";
            this.lab_Result.Size = new System.Drawing.Size(116, 48);
            this.lab_Result.TabIndex = 4;
            this.lab_Result.Text = "RS=*";
            this.lab_Result.Visible = false;
            // 
            // dgv_Gene_Process
            // 
            this.dgv_Gene_Process.AllowUserToAddRows = false;
            this.dgv_Gene_Process.AllowUserToDeleteRows = false;
            this.dgv_Gene_Process.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Gene_Process.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Gene_Process.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgv_Gene_Process.Location = new System.Drawing.Point(535, 83);
            this.dgv_Gene_Process.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Gene_Process.Name = "dgv_Gene_Process";
            this.dgv_Gene_Process.ReadOnly = true;
            this.dgv_Gene_Process.RowTemplate.Height = 30;
            this.dgv_Gene_Process.Size = new System.Drawing.Size(540, 708);
            this.dgv_Gene_Process.TabIndex = 3;
            // 
            // dgv_Gene_Ori
            // 
            this.dgv_Gene_Ori.AllowUserToAddRows = false;
            this.dgv_Gene_Ori.AllowUserToDeleteRows = false;
            this.dgv_Gene_Ori.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Gene_Ori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Gene_Ori.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Gene,
            this.Ct});
            this.dgv_Gene_Ori.Location = new System.Drawing.Point(0, 83);
            this.dgv_Gene_Ori.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Gene_Ori.Name = "dgv_Gene_Ori";
            this.dgv_Gene_Ori.ReadOnly = true;
            this.dgv_Gene_Ori.RowTemplate.Height = 30;
            this.dgv_Gene_Ori.Size = new System.Drawing.Size(533, 708);
            this.dgv_Gene_Ori.TabIndex = 2;
            // 
            // btn_cal
            // 
            this.btn_cal.Enabled = false;
            this.btn_cal.Location = new System.Drawing.Point(175, 5);
            this.btn_cal.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cal.Name = "btn_cal";
            this.btn_cal.Size = new System.Drawing.Size(153, 68);
            this.btn_cal.TabIndex = 1;
            this.btn_cal.Text = "Process";
            this.btn_cal.UseVisualStyleBackColor = true;
            this.btn_cal.Click += new System.EventHandler(this.btn_cal_Click);
            // 
            // btn_insertData
            // 
            this.btn_insertData.Location = new System.Drawing.Point(13, 5);
            this.btn_insertData.Margin = new System.Windows.Forms.Padding(4);
            this.btn_insertData.Name = "btn_insertData";
            this.btn_insertData.Size = new System.Drawing.Size(153, 68);
            this.btn_insertData.TabIndex = 0;
            this.btn_insertData.Text = "InputExcel";
            this.btn_insertData.UseVisualStyleBackColor = true;
            this.btn_insertData.Click += new System.EventHandler(this.btn_insertData_Click);
            // 
            // pb_foot
            // 
            this.pb_foot.Image = ((System.Drawing.Image)(resources.GetObject("pb_foot.Image")));
            this.pb_foot.Location = new System.Drawing.Point(4, 903);
            this.pb_foot.Margin = new System.Windows.Forms.Padding(4);
            this.pb_foot.Name = "pb_foot";
            this.pb_foot.Size = new System.Drawing.Size(1075, 104);
            this.pb_foot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_foot.TabIndex = 2;
            this.pb_foot.TabStop = false;
            // 
            // Gene
            // 
            this.Gene.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gene.DataPropertyName = "Gene";
            this.Gene.HeaderText = "Gene";
            this.Gene.Name = "Gene";
            this.Gene.ReadOnly = true;
            // 
            // Ct
            // 
            this.Ct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ct.DataPropertyName = "Ct";
            this.Ct.HeaderText = "Ct";
            this.Ct.Name = "Ct";
            this.Ct.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Gene";
            this.dataGridViewTextBoxColumn1.HeaderText = "Gene";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Ct";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ct";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1081, 1010);
            this.Controls.Add(this.pb_foot);
            this.Controls.Add(this.panel_workspace);
            this.Controls.Add(this.pb_Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Righton";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            this.panel_workspace.ResumeLayout(false);
            this.panel_workspace.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Gene_Process)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Gene_Ori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_foot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Logo;
        private System.Windows.Forms.Panel panel_workspace;
        private System.Windows.Forms.DataGridView dgv_Gene_Ori;
        private System.Windows.Forms.Button btn_cal;
        private System.Windows.Forms.Button btn_insertData;
        private System.Windows.Forms.DataGridView dgv_Gene_Process;
        private System.Windows.Forms.Label lab_Result;
        private System.Windows.Forms.Button btn_aboutme;
        private System.Windows.Forms.PictureBox pb_foot;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gene;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ct;
    }
}

