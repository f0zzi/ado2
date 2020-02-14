using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Task_1
{
    public partial class Form1 : Form
    {
        static string connection = ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString;
        SqlConnection sql = new SqlConnection(connection);
        string query;
        DataSet set = new DataSet();
        SqlCommand command = new SqlCommand();
        SqlDataAdapter dbAdapter = new SqlDataAdapter();
        SqlCommandBuilder commandBuilder = null;

        public Form1()
        {
            InitializeComponent();
            dateOfBirth.MaxDate = DateTime.Today;
            dateOfBirth.Value = DateTime.Today;
            dbAdapter.SelectCommand = new SqlCommand($"select * from Persons", sql);
            dbAdapter.Fill(set, "persons");
            try
            {
                string tmp = File.ReadAllText($"../../SQLQuery.sql");
                sql.Open();
                command.CommandText = tmp;
                command.Connection = sql;
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                if (sql != null)
                    sql.Close();
            }

            //GridShow();
        }
        private void GridShow()
        {
            //dataGridView1.DataSource = null;
            //dataGridView1.Rows.Clear();
            //dataGridView1.Refresh();
            //query = "select * from Persons";
            //commandBuilder = new SqlCommandBuilder(dbAdapter);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = set.Tables["persons"];

            //try
            //{
            //    SqlConnection conn = new SqlConnection(cs);
            //    set = new DataSet();
            //    string sql = tbRequest.Text;
            //    da = new SqlDataAdapter(sql, conn);
            //    dataGridView1.DataSource = null;
            //    cmd = new SqlCommandBuilder(da);
            //    da.Fill(set, "mybook");
            //    dataGridView1.DataSource = set.Tables["mybook"];
            //}
            //catch (Exception ex)
            //{
            //}
            //finally
            //{
            //}
        }
        private void DateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan timeSpan = DateTime.Now.Subtract(dateOfBirth.Value);
            Age.Value = Convert.ToInt32(timeSpan.Days / 365);
        }

        private void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                tbOther.Enabled = true;
                tbOther.Visible = true;
            }
            else
            {
                tbOther.Enabled = false;
                tbOther.Visible = false;
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbName.Text))
            {
                tbName.Focus();
                lbWarning.Text = "Enter name";
            }
            else if (String.IsNullOrWhiteSpace(tbLastName.Text))
            {
                tbLastName.Focus();
                lbWarning.Text = "Enter lastname";
            }
            else if (dateOfBirth.Value == DateTime.Today)
            {
                dateOfBirth.Focus();
                lbWarning.Text = "Enter birth date";
            }
            else if (String.IsNullOrWhiteSpace(tbOther.Text) && cbOther.Checked)
            {
                tbOther.Focus();
                lbWarning.Text = "Enter hobby";
            }
            else
            {
                lbWarning.Text = "";

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@Name", tbName.Text);
                command.Parameters.AddWithValue("@Lastname", tbLastName.Text);
                command.Parameters.AddWithValue("@BirthDate", DateTime.Now.Date);
                command.Parameters.AddWithValue("@Sex", rbMale.Checked ? rbMale.Text : rbFemale.Text);
                command.Parameters.AddWithValue("@ImageURL", pictureBox1.ImageLocation == null ? "" : pictureBox1.ImageLocation);
                command.Parameters.AddWithValue("@Sport", cbSport.Checked);
                command.Parameters.AddWithValue("@Tourism", cbTourism.Checked);
                command.Parameters.AddWithValue("@Books", cbBooks.Checked);
                command.Parameters.AddWithValue("@Movies", cbMovies.Checked);
                command.Parameters.AddWithValue("@Other", tbLastName.Text);
                command.CommandText = $"insert into Persons values (@Name, @LastName, @BirthDate, @Sex, @ImageURL, @Sport, @Tourism, @Books, @Movies, @Other)";
                command.Connection = sql;
                dbAdapter.InsertCommand = command;
                dbAdapter.Update(set, "persons");
                dataGridView1.DataSource = set.Tables["persons"];
                //GridShow();
                pictureBox1.Load()
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string way = openFileDialog1.FileName;
                pictureBox1.Load(way);
            }
        }

        private void BtSave_Click(object sender, EventArgs e)
        {
            try
            {
                dbAdapter.Update(set, "users");
            }
            catch (Exception)
            {

            }
        }

        private void DataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            GridShow();
        }
    }
}
