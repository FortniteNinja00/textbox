using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
           
        }
        
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

         

    }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0)
            {
                MessageBox.Show("Nie podano danych");
            }
            else
            {
                MessageBox.Show("Imię " + textBox1.Text + " Nazwisko " + textBox2.Text + " Data urodzenia " + dateTimePicker1.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
