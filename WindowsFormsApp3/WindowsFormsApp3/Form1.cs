using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        

        Random randomNumber = new Random();
        int number = 0;


        public Form1()
        {
            InitializeComponent();
            loadQuestions();
        }

        private void CheckNumber(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(txtEnterNumber.Text);
            if(i == number)
            {
                MessageBox.Show("Correct!");
                loadQuestions();
                txtEnterNumber.Text = "";
                txtEnterNumber.BackColor = Color.Green;
                txtEnterNumber.Enabled = false;
            }
            else if(i < number)
            {
                MessageBox.Show("Too High");
                txtEnterNumber.BackColor = Color.Blue;
            }
            else
            {
                MessageBox.Show("Too Low");
                txtEnterNumber.BackColor = Color.Red;
            }
        }

        private void loadQuestions()
        {
                number = randomNumber.Next(1, 1000);

            lblQuestion.Text = "I have a number between 1 and 1000--can you guess my number?";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            loadQuestions();
            txtEnterNumber.Enabled = true;
            txtEnterNumber.BackColor = DefaultBackColor;
        }
    }
}
