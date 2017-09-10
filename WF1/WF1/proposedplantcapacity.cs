using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WF1
{
    public partial class proposedplantcapacity : Form
    {
        public proposedplantcapacity()
        {
            InitializeComponent();
        }

        public proposedplantcapacity(string text)
        {
            InitializeComponent();
            lbl_1st_page.Text = text;
            effective_area.Text = text;
        }

        public void effective_area_TextChanged(object sender, EventArgs e)
        {
            float val1 = Convert.ToInt32(lbl_1st_page.Text);
            float val2 = 0.4f;
            float val3 = val1 * val2;
            effective_area.Text = val3.ToString();
        }

        public void lbl_1st_page_Click(object sender, EventArgs e)
        {
            
        }

  

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
            if (Int32.Parse(textBox2.Text) > Int32.Parse(textBox3.Text))
            {
                MessageBox.Show("PROJECT FEASIBLE IN TERMS OF AREA AVAILABILITY!");
            }
            else
            {
                MessageBox.Show("PROJECT IS NOT FEASIBLE IN TERMS OF AREA AVAILABILITY!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        

       

   
        
    }
}
