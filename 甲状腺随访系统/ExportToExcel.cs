using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using DevComponents.DotNetBar.SuperGrid;
using System.Data;
using Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace 甲状腺随访系统
{
    class ExportToExcel
    {

        /// <summary>
        /// SuperGridControl 导出EXCEL
        /// </summary>
        /// <param name="m_DataView"></param>
        public static void DataToExcel(SuperGridControl m_DataView)
        {
            SaveFileDialog dialog = new SaveFileDialog
            {
                Title = "保存EXECL文件",
                Filter = "EXECL文件(*.xls) |*.xls |所有文件(*.*) |*.*",
                FilterIndex = 1
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = dialog.FileName;
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }
                string str2 = "";

                FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter writer = new StreamWriter(stream, Encoding.Unicode);
                for (int i = 0; i < m_DataView.PrimaryGrid.Columns.Count; i++)
                {
                    if (m_DataView.PrimaryGrid.Columns[i].Visible)
                    {
                        str2 = str2 + m_DataView.PrimaryGrid.Columns[i].HeaderText.ToString() + Convert.ToChar(9);
                    }
                }
                writer.WriteLine(str2);
                str2 = "";
                for (int j = 0; j < m_DataView.PrimaryGrid.Rows.Count; j++)
                {
                    if (m_DataView.PrimaryGrid.Columns[0].Visible)
                    {
                        GridRow row = m_DataView.PrimaryGrid.Rows[j] as GridRow;
                        if (row.Cells[0].Value == null)
                        {
                            str2 = str2 + " " + Convert.ToChar(9);
                        }
                        else
                        {
                            str2 = str2 + row.Cells[0].Value.ToString() + Convert.ToChar(9);
                        }
                    }
                    for (int k = 1; k < m_DataView.PrimaryGrid.Columns.Count; k++)
                    {

                        if (m_DataView.PrimaryGrid.Columns[k].Visible)
                        {
                            GridRow row = m_DataView.PrimaryGrid.Rows[j] as GridRow;

                            if (row.Cells[k].Value == null)
                            {
                                str2 = str2 + " " + Convert.ToChar(9);
                            }
                            else
                            {
                                string str3 = "";
                                str3 = row.Cells[k].Value.ToString();
                                if (str3.IndexOf("\r\n") > 0)
                                {
                                    str3 = str3.Replace("\r\n", " ");
                                }
                                if (str3.IndexOf("\t") > 0)
                                {
                                    str3 = str3.Replace("\t", " ");
                                }
                                str2 = str2 + str3 + Convert.ToChar(9);
                            }
                        }
                    }
                    writer.WriteLine(str2);
                    str2 = "";
                }
                writer.Close();
                stream.Close();
                MessageBox.Show("保存EXCEL成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }




        public void doExport(DataSet ds, string[] tableNames, string strExcelFileName)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            try
            {
                excel.Visible = false;
                //设置禁止弹出保存和覆盖的询问提示框
                excel.DisplayAlerts = false;
                excel.AlertBeforeOverwriting = false;
                //增加一个工作簿
                Workbook book = excel.Workbooks.Add(true);
                //添加工作表
                Worksheet sheets = (Microsoft.Office.Interop.Excel.Worksheet)
                    book.Worksheets.Add(Missing.Value, Missing.Value, 19, Microsoft.Office.Interop.Excel.XlSheetType.xlWorksheet);
                for (int i = 0; i < ds.Tables.Count; i++)
                {
                    System.Data.DataTable table = ds.Tables[i];
                    //获取一个工作表
                    Worksheet sheet = book.Worksheets[i + 1] as Worksheet;
                    int rowIndex = 1;
                    int colIndex = 0;
                    foreach (DataColumn col in table.Columns)
                    {
                        colIndex++;
                        sheet.Cells[1, colIndex] = col.ColumnName;
                    }
                    foreach (DataRow row in table.Rows)
                    {
                        rowIndex++;
                        colIndex = 0;
                        foreach (DataColumn col in table.Columns)
                        {
                            colIndex++;
                            //在这里要在数字前加前单引号
                            String typeName = row[col.ColumnName].GetType().ToString();
                            sheet.Cells[rowIndex, colIndex] = typeCheckAdd(row[col.ColumnName].ToString(), typeName);
                        }
                    }
                    sheet.Name = tableNames[i];
                }
                //删除多余Sheet
                for (int g = 1; g <= book.Worksheets.Count; g++)
                {
                    Worksheet sheet = book.Worksheets[g] as Worksheet;
                    if (sheet.Name.Substring(0, 5) == "Sheet")
                    {
                        sheet.Delete();
                        g--;
                    }
                }
                book.Save();
                book.SaveAs(strExcelFileName, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                    Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
                excel.Quit();
                excel = null;
                GC.Collect();
                SaveXls(strExcelFileName);//保存到选定路径
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        #region 若是大数需加前导引号变成字符串
        public String typeCheckAdd(String cellContent, String strType)
        {
            String cellContentAdd;
            switch (strType)
            {
                case "System.String":
                    cellContentAdd = "'" + cellContent;
                    break;
                default:
                    cellContentAdd = cellContent;
                    break;
            }
            return cellContentAdd;
        }
        #endregion

        #region 保存已生成Excel到选定路径
        protected void SaveXls(string fileURL)
        {
            System.IO.FileInfo fileInfo = new System.IO.FileInfo(fileURL);
        }
            
        #endregion


    }
}