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
            this.btn_aboutme = new System.Windows.Forms.Button();
            this.lab_Result = new System.Windows.Forms.Label();
            this.dgv_Gene_Process = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Gene_Ori = new System.Windows.Forms.DataGridView();
            this.Gene = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_insertData = new System.Windows.Forms.Button();
            this.btn_cal = new System.Windows.Forms.Button();
            this.panel_workspace = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Gene_Process)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Gene_Ori)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Logo
            // 
            this.pb_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pb_Logo.Image")));
            this.pb_Logo.Location = new System.Drawing.Point(0, 0);
            this.pb_Logo.Margin = new System.Windows.Forms.Padding(0);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(864, 790);
            this.pb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_Logo.TabIndex = 0;
            this.pb_Logo.TabStop = false;
            // 
            // btn_aboutme
            // 
            this.btn_aboutme.Location = new System.Drawing.Point(880, 11);
            this.btn_aboutme.Margin = new System.Windows.Forms.Padding(2);
            this.btn_aboutme.Name = "btn_aboutme";
            this.btn_aboutme.Size = new System.Drawing.Size(76, 34);
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
            this.lab_Result.Location = new System.Drawing.Point(392, 83);
            this.lab_Result.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_Result.Name = "lab_Result";
            this.lab_Result.Size = new System.Drawing.Size(58, 24);
            this.lab_Result.TabIndex = 10;
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
            this.dgv_Gene_Process.Location = new System.Drawing.Point(427, 121);
            this.dgv_Gene_Process.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_Gene_Process.Name = "dgv_Gene_Process";
            this.dgv_Gene_Process.ReadOnly = true;
            this.dgv_Gene_Process.RowTemplate.Height = 30;
            this.dgv_Gene_Process.Size = new System.Drawing.Size(382, 594);
            this.dgv_Gene_Process.TabIndex = 9;
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
            // dgv_Gene_Ori
            // 
            this.dgv_Gene_Ori.AllowUserToAddRows = false;
            this.dgv_Gene_Ori.AllowUserToDeleteRows = false;
            this.dgv_Gene_Ori.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Gene_Ori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Gene_Ori.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Gene,
            this.Ct});
            this.dgv_Gene_Ori.Location = new System.Drawing.Point(43, 121);
            this.dgv_Gene_Ori.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_Gene_Ori.Name = "dgv_Gene_Ori";
            this.dgv_Gene_Ori.ReadOnly = true;
            this.dgv_Gene_Ori.RowTemplate.Height = 30;
            this.dgv_Gene_Ori.Size = new System.Drawing.Size(382, 594);
            this.dgv_Gene_Ori.TabIndex = 8;
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
            // btn_insertData
            // 
            this.btn_insertData.Location = new System.Drawing.Point(43, 83);
            this.btn_insertData.Margin = new System.Windows.Forms.Padding(2);
            this.btn_insertData.Name = "btn_insertData";
            this.btn_insertData.Size = new System.Drawing.Size(76, 34);
            this.btn_insertData.TabIndex = 6;
            this.btn_insertData.Text = "Data";
            this.btn_insertData.UseVisualStyleBackColor = true;
            this.btn_insertData.Click += new System.EventHandler(this.btn_insertData_Click);
            // 
            // btn_cal
            // 
            this.btn_cal.Enabled = false;
            this.btn_cal.Location = new System.Drawing.Point(123, 83);
            this.btn_cal.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cal.Name = "btn_cal";
            this.btn_cal.Size = new System.Drawing.Size(76, 34);
            this.btn_cal.TabIndex = 7;
            this.btn_cal.Text = "Process";
            this.btn_cal.UseVisualStyleBackColor = true;
            this.btn_cal.Click += new System.EventHandler(this.btn_cal_Click);
            // 
            // panel_workspace
            // 
            this.panel_workspace.BackColor = System.Drawing.SystemColors.Control;
            this.panel_workspace.Location = new System.Drawing.Point(880, 77);
            this.panel_workspace.Margin = new System.Windows.Forms.Padding(2);
            this.panel_workspace.Name = "panel_workspace";
            this.panel_workspace.Size = new System.Drawing.Size(772, 638);
            this.panel_workspace.TabIndex = 1;
            this.panel_workspace.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 34);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(864, 790);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lab_Result);
            this.Controls.Add(this.dgv_Gene_Process);
            this.Controls.Add(this.dgv_Gene_Ori);
            this.Controls.Add(this.btn_insertData);
            this.Controls.Add(this.btn_cal);
            this.Controls.Add(this.btn_aboutme);
            this.Controls.Add(this.panel_workspace);
            this.Controls.Add(this.pb_Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Righton";
            this.Load += new System.EventHandler(this.form_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Gene_Process)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Gene_Ori)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Logo;
        private System.Windows.Forms.Button btn_aboutme;
        private System.Windows.Forms.Label lab_Result;
        private System.Windows.Forms.DataGridView dgv_Gene_Process;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView dgv_Gene_Ori;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gene;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ct;
        private System.Windows.Forms.Button btn_insertData;
        private System.Windows.Forms.Button btn_cal;
        private System.Windows.Forms.Panel panel_workspace;
        private System.Windows.Forms.Button button1;
    }
}

