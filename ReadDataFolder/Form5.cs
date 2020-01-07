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
        SqlDataAdapter sqlDa = new SqlDataAdapter();
        DataTable dtData = new DataTable();
        string kueri;
        int result;
        int id;

        
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
                MessageBox.Show("Enter ID Brand !!!");
                textBox1.Select();
            }
            else if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Enter Tipe !!!");
                textBox2.Select();
            }
            
            
            else
            {
                try
                {
                    if (sqlCon.State == ConnectionState.Closed)
                    {
                        sqlCon.Open();
                    }
                    kueri = "INSERT INTO model (id_brand, type, remark_type) VALUES ('"+textBox1.Text+"' ,'"+textBox2.Text+"' ,'"+textBox3.Text+"')";
                    sqlCmd.Connection = sqlCon;
                    sqlCmd.CommandText = kueri;
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
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
                kueri = "DELETE FROM model WHERE id_model =" + id;
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = kueri;
                result = sqlCmd.ExecuteNonQuery();

                if (result != 0)
                {
                    MessageBox.Show("Data has been deleted in the SQL database");
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

        private void editBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
                kueri = "UPDATE model SET id_brand ='"+textBox1.Text+ "' , type = '" + textBox2.Text + "', remark_type = '" + textBox3.Text + "'WHERE id_model = " +id;
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = kueri;
                result = sqlCmd.ExecuteNonQuery();

                if (result != 0)
                {
                    MessageBox.Show("Data has been updated in the SQL database");
                    //calling a method
                    srcBtn_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("SQL QUERY ERROR");
                }
                sqlCon.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                
            }
        }

        private void srcBtn_Click(object sender, EventArgs e)
        {
            try
            {
                kueri = "SELECT model.id_model as 'ID Model', model.id_brand as 'ID', merk.brand as 'Brand', model.type as 'Type', model.remark_type as 'Seri' FROM merk RIGHT JOIN model ON merk.id_brand = model.id_brand";
                sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = kueri;
                sqlDa = new SqlDataAdapter();
                sqlDa.SelectCommand = sqlCmd;
                dtData = new DataTable();
                sqlDa.Fill(dtData);
                dataGridView1.DataSource = dtData;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlDa.Dispose();
            }
            id = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                id = Int32.Parse(dataGridView1.CurrentRow.Cells["ID Model"].FormattedValue.ToString());
                textBox1.Text = dataGridView1.CurrentRow.Cells["ID"].FormattedValue.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells["Type"].FormattedValue.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells["Seri"].FormattedValue.ToString();


            }
        }

        private void Form5_Click(object sender, EventArgs e)
        {
            id = 0;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
