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
        DataSet set = new DataSet();
        SqlCommand command = new SqlCommand();
        SqlDataAdapter dbAdapter = null;
        SqlCommandBuilder commandBuilder = null;

        public Form1()
        {
            InitializeComponent();
            dateOfBirth.MaxDate = DateTime.Today;
            dateOfBirth.Value = DateTime.Today;
            dbAdapter = new SqlDataAdapter($"select * from Persons", sql);
            commandBuilder = new SqlCommandBuilder(dbAdapter);
            dbAdapter.Fill(set, "persons");
            dataGridView1.DataSource = set.Tables["persons"];

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

                DataTable dt = set.Tables["persons"];
                dt.Columns[0].AutoIncrement = true;
                dt.Columns[0].AutoIncrementSeed = ((int)dt.Rows[dt.Rows.Count - 1][0]) + 1;

                DataRow dataRow = dt.NewRow();
                dataRow[1] = tbName.Text;
                dataRow[2] = tbLastName.Text;
                dataRow[3] = DateTime.Now.Date;
                dataRow[4] = rbMale.Checked ? rbMale.Text : rbFemale.Text;
                dataRow[5] = pictureBox1.ImageLocation == null ? "" : pictureBox1.ImageLocation;
                dataRow[6] = cbSport.Checked;
                dataRow[7] = cbTourism.Checked;
                dataRow[8] = cbBooks.Checked;
                dataRow[9] = cbMovies.Checked;
                dataRow[10] = tbLastName.Text;
                dt.Rows.Add(dataRow);
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
                dbAdapter.Update(set, "persons");
            }
            catch (Exception)
            {

            }
        }
    }
}
