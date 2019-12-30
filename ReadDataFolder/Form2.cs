using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace ReadDataFolder
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fname = "";
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Open";
            fdlg.InitialDirectory = @"D:\Dokumenppppppp";
            fdlg.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm;*.xlsb";
            fdlg.RestoreDirectory = true;

            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                fname = fdlg.FileName;

                txtBox.Text = fname;
                
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();

                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(fname);
                Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
                Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;

                int rowCount = xlRange.Rows.Count;
                int colCount = xlRange.Columns.Count;

                // dt.Column = colCount;  
                dataGridView1.ColumnCount = colCount;
                dataGridView1.RowCount = rowCount;

                for (int i = 1; i <= rowCount; i++)
                {
                    for (int j = 1; j <= colCount; j++)
                    {


                        //write the value to the Grid  


                        if (xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)
                        {
                            dataGridView1.Rows[i - 1].Cells[j - 1].Value = xlRange.Cells[i, j].Value2.ToString();
                        }
                        // Console.Write(xlRange.Cells[i, j].Value2.ToString() + "\t");  

                        //add useful things here!     
                    }
                }

                //cleanup  
                GC.Collect();
                GC.WaitForPendingFinalizers();

                //rule of thumb for releasing com objects:  
                //  never use two dots, all COM objects must be referenced and released individually  
                //  ex: [somthing].[something].[something] is bad  

                //release com objects to fully kill excel process from running in the background  
                Marshal.ReleaseComObject(xlRange);
                Marshal.ReleaseComObject(xlWorksheet);

                //close and release  
                xlWorkbook.Close();
                Marshal.ReleaseComObject(xlWorkbook);

                //quit and release  
                xlApp.Quit();
                Marshal.ReleaseComObject(xlApp);


            }
            else if (fdlg.ShowDialog() == DialogResult.Cancel)
            {
               // Close();
            }


            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
