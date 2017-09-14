using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Righton
{
    public partial class form_Main : Form
    {
        public DataTable dtGene_Ori;
        public form_Main()
        {
            InitializeComponent();
        }
        private void btn_insertData_Click(object sender, EventArgs e)
        {
            DataTable TempDT = null;
            btn_cal.Enabled = false;
            lab_Result.Visible = false;
            dgv_Gene_Ori.DataSource = TempDT;
            dgv_Gene_Process.DataSource = TempDT;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel文件(xlsx)|*.xlsx|Excel文件(xls)|*.xls";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Boolean boolValid = true;
                    string filePath = openFileDialog.FileName;
                    ExcelHelper.ExcelHelper eh = new ExcelHelper.ExcelHelper();
                    TempDT = eh.ExcelToDataTable(filePath);
                    dgv_Gene_Ori.AutoGenerateColumns = false;
                    dgv_Gene_Ori.DataSource = TempDT;
                    dtGene_Ori = TempDT;
                    for(int i = 0;i < TempDT.Rows.Count;i++)
                    {
                        if(TempDT.Rows[i][1] == null || TempDT.Rows[i][1].ToString() == "")
                        {
                            boolValid = false;
                            break;
                        }
                    }
                    if(!boolValid)
                    {
                        MessageBox.Show("导入数据有误,请检查!");
                    }
                    else
                    {
                        MessageBox.Show("导入成功!");
                        btn_cal.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Excel数据导入失败,详见数据错误列表::" + ex.Message, "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void btn_cal_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtGene_Process = dtGene_Ori.Copy();
                ////计算公式是：1. （5个内参平均值）-目的 + 10
                double dbl_avg = (double.Parse(dtGene_Ori.Rows[4][1].ToString()) + double.Parse(dtGene_Ori.Rows[5][1].ToString()) + double.Parse(dtGene_Ori.Rows[18][1].ToString()) + double.Parse(dtGene_Ori.Rows[19][1].ToString()) + double.Parse(dtGene_Ori.Rows[20][1].ToString())) / 5;
                for (int i = 0; i < dtGene_Process.Rows.Count; i++)
                {
                    if (i == 4 || i == 5 || i == 18 || i == 19 || i == 20)
                    {
                        continue;
                    }
                    else
                    {
                        dtGene_Process.Rows[i][1] = (dbl_avg - double.Parse(dtGene_Ori.Rows[i][1].ToString()) + 10).ToString("0.000");
                    }
                }
                dgv_Gene_Process.AutoGenerateColumns = false;
                dgv_Gene_Process.DataSource = dtGene_Process;
                double dblERBB = double.Parse(dtGene_Process.Rows[10][1].ToString());
                double dblSTK15 = double.Parse(dtGene_Process.Rows[7][1].ToString());
                ////1   ER 目的
                ////2   BCL2 目的
                ////3   BIR(Survivin)   目的
                ////4   MMP11 目的
                ////5   ACTB 内参
                ////6   GAPD 内参
                ////7   GRB7 目的
                ////8   AUR（STK15)	目的
                ////9   CTSL2 目的
                ////10  GST 目的
                ////11  ERBB 目的
                ////12  MYBL2 目的
                ////13  MKI(Ki67)   目的
                ////14  PGR 目的
                ////15  CD68 目的
                ////16  BAG 目的
                ////17  CCNB1 目的
                ////18  SCUB 目的
                ////19  RPL 内参
                ////20  TFR 内参
                ////21  GUS 内参
                ////1.GBR7组值 = 0.9×GRB7 + 0.1×HER2(如果值小于8，算作8）									
                double dblGBR7 = 0.9 * double.Parse(dtGene_Process.Rows[6][1].ToString()) + 0.1 * dblERBB;
                if (dblGBR7 < 8)
                {
                    dblGBR7 = 8;
                }
                ////2.ER组值 = 0.25×（0.8×ER + 1.2×PGR + BCL2 + SCUBZ）									
                double dblER = 0.25 * (0.8 * double.Parse(dtGene_Process.Rows[0][1].ToString()) + 1.2 * double.Parse(dtGene_Process.Rows[13][1].ToString()) + double.Parse(dtGene_Process.Rows[1][1].ToString()) + double.Parse(dtGene_Process.Rows[17][1].ToString()));
                ////3.增值组值 = 0.2×(Survivin + Ki67 + MyBL2 + Cyclin + STK15) （如果值小于6.5，算作6.5）									
                double dblIncrement = 0.2 * (double.Parse(dtGene_Process.Rows[2][1].ToString()) + double.Parse(dtGene_Process.Rows[12][1].ToString()) + double.Parse(dtGene_Process.Rows[11][1].ToString()) + double.Parse(dtGene_Process.Rows[16][1].ToString()) + dblSTK15);
                if (dblIncrement < 6.5)
                {
                    dblIncrement = 6.5;
                }
                ////4.侵袭组值 = 0.5×（Cathepsin L2 + (MMP 11）		
                double dblAttack = 0.5 * (double.Parse(dtGene_Process.Rows[8][1].ToString()) + double.Parse(dtGene_Process.Rows[3][1].ToString()));
                ////5.RSu =（0.47× GBR7组值）-（0.34× ER组值）+（1.04× 增值组值）+（0.1×侵袭组值）+（0.05×CD68）-(0.08×GSTM1) -（0.07×BAG1）																		
                ////如果RSu < 0,则RS = 0    如果0≤ RSu≤100，RS = 20×(RSu - 6.7)     如果RSu > 100，则RS = 100
                double dblRsu = (0.47 * dblGBR7) - (0.34 * dblER) + (1.04 * dblIncrement) + (0.1 * dblAttack) + (0.05 * double.Parse(dtGene_Process.Rows[14][1].ToString())) - (0.08 * double.Parse(dtGene_Process.Rows[9][1].ToString())) - (0.07 * double.Parse(dtGene_Process.Rows[15][1].ToString()));
                double dblRS = 0;
                if (dblRsu < 0)
                {
                    dblRS = 0;
                }
                else if (dblRsu >= 0 && dblRsu <= 100)
                {
                    dblRS = 20 * (dblRsu - 6.7);
                }
                else
                {
                    dblRS = 100;
                }
                //lab_Result.Text = "RS = " + dblRS.ToString();
                //lab_Result.Visible = true;
                Base be = new Base();
                be.dbRS = dblRS;
                btn_report.Enabled = true;
                MessageBox.Show("RS = " + dblRS.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show("程序故障::" + ex.Message + "请联系开发商!");
            }
        }

        private void btn_aboutme_Click(object sender, EventArgs e)
        {
            MessageBox.Show("copyright (c) 2017 上海睿昂生物技术有限公司");
        }

        private void form_Main_Load(object sender, EventArgs e)
        {
            panel_workspace.BackColor = Color.FromArgb(65, 204, 212, 230);
            btn_report.Enabled = false;
            btn_cal.Enabled = false;
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            form_Report fr = new form_Report();
            fr.Show();
            this.Close();
        }
    }
}
