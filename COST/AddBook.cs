﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COST
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           if (txtBookName.Text != "" && txtAuthor.Text != "" && txtPublication.Text != "" && txtPrice.Text != "" && txtQuantity.Text != "")
            {
                String bname = txtBookName.Text;
                String bauthor = txtAuthor.Text;
                String publication = txtPublication.Text;
                String pdate = dateTimePicker1.Text;
                Int64 price = Int64.Parse(txtQuantity.Text);
                Int64 quan = Int64.Parse(txtQuantity.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-0NV0SBU\\SQLEXPRESS;database = library_mang;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "insert  into NewBook(bName,bAuthor,bPubl,bpDate,bPrice,bQuan) values('" + bname + "','" + bauthor + "','" + publication + "','" + pdate + "','" + price + "','" + quan + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("data Saved.", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBookName.Clear();
                txtAuthor.Clear();
                txtPublication.Clear();
                txtPrice.Clear();
                txtQuantity.Clear();
            }
            else
            {
                MessageBox.Show("Empty Field Not Allowed", "warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you Sure?"," this will delete your unsaved  Data",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)== DialogResult.OK)
            {
                this.Close();
            }
        }

        private void txtBookName_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddBook_Load(object sender, EventArgs e)
        {

        }
    }
}
