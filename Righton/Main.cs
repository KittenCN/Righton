using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Righton
{
    public partial class form_Main : Form
    {
        public DataTable dtGene_Ori;
        public double dblRS;
        public string strlVar;
        public form_Main()
        {
            InitializeComponent();
            this.Width = 883;
            this.Height = 833;
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
                        //MessageBox.Show("导入成功!");
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
                dblRS = 0;
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
                lab_Result.Text = "检测结果(RS值)         " + dblRS.ToString();
                lab_Result.Visible = true;               
                btn_report.Enabled = true;
                //MessageBox.Show("RS = " + dblRS.ToString());
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
            //form_Report fr = new form_Report();
            //fr.dblRS = dblRS;
            //fr.Show();
            //this.Visible = false;
            string[] sArray = strlVar.Split('|');
            int intCurNum = 1;
            textBox1.Text = sArray[0];
            for (int i = 3; i < 17; i++)
            {
                if (i != 18 && i != 19)
                {
                    foreach (Control cur in Controls)
                    {
                        if (cur is TextBox && cur.Name == "textBox" + i.ToString())
                        {
                            cur.Text = sArray[intCurNum];
                            intCurNum++;
                        }
                    }
                }
            }
            if (CheckAddString(textBox21.Text) && CheckAddString(textBox22.Text) && CheckAddString(textBox23.Text) && CheckAddString(textBox24.Text) && CheckAddString(textBox25.Text) && CheckAddString(textBox26.Text))
            {
                WordHelper.WordHelper wh = new WordHelper.WordHelper();
                string path = Application.StartupPath;
                wh.CreateNewWordDocument(path + "//Model//Report.dot");

                //string[] strClass = {"报告编号","报告时间2","姓名","性别","年龄","科别","样本类型","送检医院","病区","取样时间","病理号","样本编号","床位号","临床诊断","家族史","已接受的治疗","检测仪器","检测结果","十年复发风险", "检验人员","审核人员","检测时间","报告时间","P1","P2","P3","P4","P5","P6","风险评分","复发等级","治疗方式" };
                string[] strClass = { "报告编号", "报告时间2", "姓名", "性别", "年龄", "科别", "样本类型", "送检医院", "病区", "取样时间", "病理号", "样本编号", "床位号", "临床诊断", "家族史", "已接受的治疗", "检测仪器", "检测结果", "十年复发风险", "检验人员", "审核人员", "检测时间", "报告时间", "风险评分", "复发等级", "治疗方式" };
                for (int i = 0; i < 17; i++)
                {
                    if (i != 18 && i != 19)
                    {
                        foreach (Control cur in Controls)
                        {
                            if (cur is TextBox && cur.Name == "textBox" + (i + 1).ToString())
                            {
                                wh.Replace(strClass[i], cur.Text);
                            }
                        }
                    }
                }
                wh.Replace("检测仪器", textBox17.Text);
                wh.Replace("检测结果", dblRS.ToString());
                string strDan = "";
                string strPro = "";
                if (dblRS < 18)
                {
                    strDan = "低复发风险组";
                    strPro = "内分泌治疗";
                }
                else if (dblRS >= 18 && dblRS < 30)
                {
                    strDan = "中复发风险组";
                    strPro = "根据临床其他指标确定是否需要额外化疗";
                }
                else
                {
                    strDan = "高复发风险组";
                    strPro = "联合应用内分泌治疗和辅助化疗";
                }
                wh.Replace("十年复发风险", strDan);
                wh.Replace("检验人员", textBox18.Text);
                wh.Replace("审核人员", textBox19.Text);
                wh.Replace("检测时间", dateTimePicker1.Value.ToShortDateString());
                wh.Replace("报告时间2", dateTimePicker2.Value.ToShortDateString());
                wh.Replace("报告时间", dateTimePicker2.Value.ToShortDateString());
                wh.Replace("风险评分", dblRS.ToString());
                wh.Replace("复发等级", strDan);
                wh.Replace("治疗方式", strPro);
                wh.AddPic("P1", textBox21.Text);
                wh.AddPic("P2", textBox22.Text);
                wh.AddPic("P3", textBox23.Text);
                wh.AddPic("P4", textBox24.Text);
                wh.AddPic("P5", textBox25.Text);
                wh.AddPic("P6", textBox26.Text);
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Word文件(*.doc)|*.doc";
                // Show save file dialog box
                DialogResult result = saveFileDialog.ShowDialog();
                //点了保存按钮进入
                if (result == DialogResult.OK)
                {
                    //获得文件路径
                    string localFilePath = saveFileDialog.FileName.ToString();
                    try
                    {
                        wh.SaveAs(localFilePath);
                        wh.Close();
                        MessageBox.Show("保存成功", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        System.Diagnostics.Process proc = new System.Diagnostics.Process();
                        proc.EnableRaisingEvents = false;
                        proc.StartInfo.FileName = "winword";
                        proc.StartInfo.Arguments = localFilePath;
                        proc.Start();
                    }
                    catch (Exception ex)
                    {
                        wh.Close();
                        MessageBox.Show("保存失败::" + ex.Message.ToString(), "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            Application.Exit(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox21.Text = GetAdd();
        }
        private Boolean CheckAddString(string strOri)
        {
            Boolean boolResult = false;
            try
            {
                if (strOri != null && strOri.Length > 0)
                {
                    if (File.Exists(strOri))
                    {
                        boolResult = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error::" + ex.Message.ToString());
                boolResult = false;
            }
            return boolResult;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            form_Report fr = new form_Report();
            fr.Show();
            this.Visible = false;
        }
        private string GetAdd()
        {
            string strResult = "";
            OpenFileDialog OpenFileDialog = new OpenFileDialog();
            OpenFileDialog.Filter = "图片文件(*.jpg)|*.jpg";
            DialogResult result = OpenFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                //获得文件路径
                string localFilePath = OpenFileDialog.FileName.ToString();
                try
                {
                    strResult = localFilePath;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error::" + ex.Message.ToString(), "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            return strResult;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox23.Text = GetAdd();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox25.Text = GetAdd();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox22.Text = GetAdd();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox24.Text = GetAdd();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox26.Text = GetAdd();
        }
    }
}
