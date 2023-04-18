using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mymathquiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Random randomizer = new Random();
            int addend1;
            int addend2;
            int minuend;
            int subtrahend;
            int multiplicand;
            int multiplier;
            int dividend;
            int divisor;
            int timeLeft;
            

            void StartTheQuiz()
            {
                addend1 = randomizer.Next(51);
                addend2 = randomizer.Next(51);
                plusLeftLabel.Text = addend1.ToString();
                plusRightLabel.Text = addend2.ToString();
                sum.Value = 0;
                minuend = randomizer.Next(1, 101);
                subtrahend = randomizer.Next(1, minuend);
                minusLeftLabel.Text = minuend.ToString();
                minusRightLabel.Text = subtrahend.ToString();
                difference.Value = 0;
                multiplicand = randomizer.Next(2, 11);
                multiplier = randomizer.Next(2, 11);
                timesLeftLabel.Text = multiplicand.ToString();
                timesRightLabel.Text = multiplier.ToString();
                product.Value = 0;
                divisor = randomizer.Next(2, 11);
                int temporaryQuotient = randomizer.Next(2, 11);
                dividend = divisor * temporaryQuotient;
                dividedLeftLabel.Text = dividend.ToString();
                dividedRightLabel.Text = divisor.ToString();
                quotient.Value = 0;
                timeLeft = 30;
                timeLabel.Text = "30 seconds";
                timer1.Start();


            }


            void Button1_Click(object sender, EventArgs e)
            {
                StartTheQuiz();
                Button1.Enabled = false;
            }




            bool CheckTheAnswer()
            {
                if ((addend1 + addend2 == sum.Value)
                    && (minuend - subtrahend == difference.Value)
                    && (multiplicand * multiplier == product.Value)
                    && (dividend / divisor == quotient.Value))
                    return true;
                else
                    return false;
            }


            void timer1_Tick(object sender, EventArgs e)


            {
                if (CheckTheAnswer())
                {
                    timer1.Stop();
                    MessageBox.Show("You got all the answers right!", "Congratulations!");
                    Button1.Enabled = true;
                }
                else
                {
                    if (timeLeft > 0)
                    {
                        timeLeft--;
                        timeLabel.Text = timeLeft + "seconds";
                    }
                    else
                    {
                        timer1.Stop();
                        timeLabel.Text = "Time's up!";
                        MessageBox.Show("You didn't finish in time.", "Sorry!");
                        sum.Value = addend1 + addend2;
                        difference.Value = minuend - subtrahend;
                        product.Value = multiplicand * multiplier;
                        quotient.Value = dividend / divisor;
                        Button1.Enabled = true;

                    }

                }
                timeLabel.BackColor = Color.Red;
            }



        }

        
        private void Answer_Enter(object sender, EventArgs e)
        {
            if (sender is NumericUpDown answerBox)
            {
                int lenghtOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lenghtOfAnswer);
            }
        }

        
    }
}
    


            

