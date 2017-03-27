using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using DevComponents.DotNetBar.SuperGrid;

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
    }
}
