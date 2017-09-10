using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WF1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=solarproject;Integrated Security=True;Pooling=False";
            string q = "insert into initial(place,lifespan,legal_doc,roof_area,roof_obstruction,roof_obstruction_yes,roof_material,load_bearing_capacity,roof_shading,asthetic,safety_standards,electricity_bills) values('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + textBox3.Text + "','" + comboBox2.Text + "','" + textBox4.Text + "','" + comboBox3.Text + "','" + textBox5.Text + "','" + comboBox4.Text + "','" + comboBox5.Text + "','" + comboBox6.Text + "','" + comboBox7.Text + "')";
            con.Open();
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Saved Successfully");
            proposedplantcapacity form = new proposedplantcapacity(textBox3.Text);
            //proposedplantcapacity form1 = new proposedplantcapacity(label20.Text);
            form.Show();
        }

        public void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            float val1 = Convert.ToInt32(textBox3.Text);
            float val2 = 0.4f;
            float val3 = val1 * val2;
            label20.Text = val3.ToString();
            //proposedplantcapacity form = new proposedplantcapacity(label20.Text);
        }

        public void label20_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //public proposedplantcapacity otherForm = new proposedplantcapacity();

        //public void proposedplantcapacity_Load(object sender, EventArgs e)
        //{
        //    label20.Text = otherForm.effective_area.Text;
        //}
    }
}
