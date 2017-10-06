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

namespace Righton
{
    public partial class form_Report : Form
    {
        public DataTable dtGene_Ori;
        public Double dbRS;
        public string strVar;
        public form_Report()
        {
            InitializeComponent();
        }

        private void btn_OutToWord_Click(object sender, EventArgs e)
        {           
            if(CheckAddString(textBox21.Text) && CheckAddString(textBox22.Text) && CheckAddString(textBox23.Text) && CheckAddString(textBox24.Text) && CheckAddString(textBox25.Text) && CheckAddString(textBox26.Text))
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
                wh.Replace("检测结果", dbRS.ToString());
                string strDan = "";
                string strPro = "";
                if (dbRS<18)
                {
                    strDan = "低复发风险组";
                    strPro = "内分泌治疗";
                }
                else if(dbRS>=18 && dbRS <30)
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
                wh.Replace("检测时间", textBox20.Text);
                wh.Replace("报告时间", textBox2.Text);
                wh.Replace("风险评分", dbRS.ToString());
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
                    }
                    catch (Exception ex)
                    {
                        wh.Close();
                        MessageBox.Show("保存失败::" + ex.Message.ToString(), "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
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
            catch(Exception ex)
            {
                MessageBox.Show("Error::" + ex.Message.ToString());
                boolResult = false;
            }
            return boolResult;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            form_Main fm = new form_Main();
            fm.Visible = true;
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox21.Text = GetAdd();
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

        private void button2_Click(object sender, EventArgs e)
        {
            textBox22.Text = GetAdd();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox23.Text = GetAdd();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox24.Text = GetAdd();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox25.Text = GetAdd();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox26.Text = GetAdd();
        }

        private void form_Report_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(dbRS.ToString());
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            Application.Exit(e);
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            strVar = textBox1.Text;
            for (int i = 3; i < 17; i++)
            {
                if (i != 18 && i != 19)
                {
                    foreach (Control cur in Controls)
                    {
                        if (cur is TextBox && cur.Name == "textBox" + i.ToString())
                        {
                            strVar = strVar + "|" + cur.Text;
                        }
                    }
                }
            }
            form_Main fr = new form_Main();
            fr.strlVar = strVar;
            fr.Show();
            this.Visible = false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBox10.Text = dateTimePicker1.Value.ToShortDateString();
        }
    }
}
