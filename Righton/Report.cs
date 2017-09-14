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
        public form_Report()
        {
            InitializeComponent();
        }

        private void btn_OutToWord_Click(object sender, EventArgs e)
        {
            Base be = new Base();
            MessageBox.Show(be.dbRS.ToString());
            if(CheckAddString(textBox21.Text) && CheckAddString(textBox22.Text) && CheckAddString(textBox23.Text) && CheckAddString(textBox24.Text) && CheckAddString(textBox25.Text) && CheckAddString(textBox26.Text))
            {
                WordHelper.WordHelper wh = new WordHelper.WordHelper();
                string path = Application.StartupPath;
                wh.CreateNewWordDocument(path + "//Model//Report.dot");

                //string[] strClass = {"报告编号","报告时间2","姓名","性别","年龄","科别","样本类型","送检医院","病区","取样时间","病理号","样本编号","床位号","临床诊断","家族史","已接受的治疗","检测仪器","检测结果","十年复发风险", "检验人员","审核人员","检测时间","报告时间","P1","P2","P3","P4","P5","P6","风险评分","复发等级","治疗方式" };
                string[] strClass = { "报告编号", "报告时间2", "姓名", "性别", "年龄", "科别", "样本类型", "送检医院", "病区", "取样时间", "病理号", "样本编号", "床位号", "临床诊断", "家族史", "已接受的治疗", "检测仪器", "检测结果", "十年复发风险", "检验人员", "审核人员", "检测时间", "报告时间", "风险评分", "复发等级", "治疗方式" };
                for (int i = 0; i < 22; i++)
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
            fm.Show();
            this.Close();
        }
    }
}
