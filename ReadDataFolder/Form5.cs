using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ReadDataFolder
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            sqlCon = new SqlConnection(conString);
            sqlCon.Open();
        }

        string conString = @"Data Source=SYFPC702030\SQL19;Initial Catalog=coba_db;Integrated Security=True";
        SqlConnection sqlCon;
        SqlCommand sqlCmd = new SqlCommand();
        string query;
        int result;

        
        private DataTable FetchEmpDetails()
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            DataTable dtData = new DataTable();
            sqlCmd = new SqlCommand("spEmployee", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@ActionType", "FetchData");
            SqlDataAdapter sqlSda = new SqlDataAdapter(sqlCmd);
            sqlSda.Fill(dtData);
            return dtData;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Enter Employee Name !!!");
                textBox1.Select();
            }
            else if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Enter Current City !!!");
                textBox2.Select();
            }
            else if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Enter Department !!!");
                textBox3.Select();
            }
            
            else
            {
                try
                {
                    if (sqlCon.State == ConnectionState.Closed)
                    {
                        sqlCon.Open();
                    }
                    query = "INSERT INTO model (id_brand, type, remark_type) VALUES ('"+textBox1.Text+"' ,'"+textBox2.Text+"' ,'"+textBox3.Text+"')";
                    sqlCmd.Connection = sqlCon;
                    sqlCmd.CommandText = query;
                    result = sqlCmd.ExecuteNonQuery();

                    if (result != 0)
                    {
                        MessageBox.Show("Data has been saved in the SQL database");
                        //calling a method
                        srcBtn_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("SQL QUERY ERROR");
                    }

                    sqlCon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:- " + ex.Message);
                }
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {

        }

        private void editBtn_Click(object sender, EventArgs e)
        {

        }

        private void srcBtn_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            //dataGridView1.AutoGenerateColumns = false; // dgvEmp is DataGridView name  
            //dataGridView1.DataSource = FetchEmpDetails();
        }
    }
}
