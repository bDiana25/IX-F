using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primalitateanumerelor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e) {
        int result = 0;
            bool isNumber = Int32.TryParse(numberTextBox.Text,out result);
            if(isNumber) {
                bool isPrime = true;
                int i;
                for (i = 2; i <= result / 2; i++)
                {
                    if (result % i == 0)
                    {
                        isPrime = false;
                    }
                }
                if (isPrime)
                {
                    this.BackColor = Color.Green;
                }
                else
                {
                    this.BackColor = Color.Red;
                }
            }


            else
            {
                this.BackColor = Color.Yellow;
                MessageBox.Show("S-a introdus un text");
            }
            numberTextBox.Clear();
        }
        }
    
}
        




