using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelHelper
{
    public class ExcelHelper
    {
        public DataTable ExcelToDataTable(string filePath)
        {
            DataTable Result = new DataTable();
            Result.Columns.Add(new DataColumn("Gene", typeof(string)));
            Result.Columns.Add(new DataColumn("Ct", typeof(double)));

            Excel.Application app = new Excel.Application();
            Excel.Sheets sheets;
            object oMissiong = System.Reflection.Missing.Value;
            Excel.Workbook workbook = null;

            try
            {
                if (app == null) return null;
                workbook = app.Workbooks.Open(filePath, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong,
                    oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong, oMissiong);
                sheets = workbook.Worksheets;

                //将数据读入到DataTable中
                Excel.Worksheet worksheet = (Excel.Worksheet)sheets.get_Item(1);//读取第一张表  
                if (worksheet == null) return null;

                int iRowCount = worksheet.UsedRange.Rows.Count;
                int iColCount = worksheet.UsedRange.Columns.Count;

                //生成行数据
                //Excel.Range range;
                for (int iRow = 3; iRow <= iRowCount; iRow++)
                {
                    int validate = 0;
                    DataRow dr = Result.NewRow();
                    dr["Gene"] = ((Excel.Range)worksheet.Cells[iRow, 1]).Text;
                    dr["Ct"] = double.Parse(((Excel.Range)worksheet.Cells[iRow, 2]).Text.ToString());
                    if (validate == 0) Result.Rows.Add(dr);
                }
                return Result;
            }
            catch (Exception ex) { return null; }
            finally
            {
                workbook.Close(false, oMissiong, oMissiong);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                workbook = null;
                app.Workbooks.Close();
                app.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(app);
                app = null;
            }
        }
    }
}
