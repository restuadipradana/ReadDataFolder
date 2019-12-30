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

namespace ReadDataFolder
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            string dir = @"F:\File Restu\Dokumen";
            listBox1.Items.Clear();

            var allowedExtensions = new[] { ".xls", ".xlsx", ".xlsb", ".xlsm" };
            var files = Directory.GetFiles(dir).Where(file => allowedExtensions.Any(file.ToLower().EndsWith)).ToList();


            int i = 0;

            foreach (string file in files)
            {
                listBox1.Items.Add(Path.GetFileName(file));
                i++;
            }

            //foreach (string dir in dirs)
            //{
            //    listBox1.Items.Add(Path.GetFileName(dir));
            //    i++;
            //}
           
            textBox1.Text = i + " File";


         //   FolderBrowserDialog RST = new FolderBrowserDialog();
            

         //   if (RST.ShowDialog() == DialogResult.OK)
         //   {
         //       listBox1.Items.Clear();
         //       string[] files = Directory.GetFiles(RST.SelectedPath);
         //       string[] dirs = Directory.GetDirectories(RST.SelectedPath);
         //
         //       foreach(string file in files)
         //       {
         //           listBox1.Items.Add(Path.GetFileName(file));
         //       }
         //
         //       foreach (string dir in dirs)
         //       {
         //           listBox1.Items.Add(Path.GetFileName(dir));
         //       }
         //
         //
         //   }
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btEx1_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();

            form2.ShowDialog();


        }
    }
}
