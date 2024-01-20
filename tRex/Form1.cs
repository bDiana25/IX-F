using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tRex.Properties;

namespace tRex
{
    public partial class EndlessRunner : Form
    {
        bool jumping = false;
        bool isGameOver = false;
        Random random = new Random();
        int jumpSpeed;
        int force = 12;
        int score = 0;
        int obstacleSpeed = 10;
        int position = 0;
        public EndlessRunner()
        {
            InitializeComponent();
            GameReset();
        }

        private void GameReset()
        {
            jumping = false;
            force = 12;
            score = 0;
            jumpSpeed = 0;
            obstacleSpeed = 10;
            scoreLabel.Text = "Score" + score;
            trexPictureBox.Image = Resources.running;
            isGameOver = false;
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    position = this.ClientSize.Width + random.Next(500, 800) + (x.Width * 10);
                    x.Left = position;
                }
            }
           
        }
        private void EndlessRunnerTimerEvent(object sender, EventArgs e)
        {
            trexPictureBox.Top = trexPictureBox.Top + jumpSpeed;
            scoreLabel.Text = "Score: " + score + " Jumping speed: " + jumpSpeed + " force: " + force + " Top:" + trexPictureBox.Top + " Bottom:" + trexPictureBox.Bottom;
            if (jumping == true && force < 0)
            {
                jumping = false;
            }

            if (jumping == true)
            {
                jumpSpeed = -12;
                force--;
            }
            else
            {
                jumpSpeed = 12;
            }


            if (trexPictureBox.Top > 366 && jumping == false)
            {
                force = 12;
                trexPictureBox.Top = 367;
                jumpSpeed = 0;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    x.Left -= obstacleSpeed;

                    if (x.Left < -100)
                    {
                        x.Left = this.ClientSize.Width + random.Next(200, 500) + (x.Width * 15);
                        score++;
                    }

                    if (trexPictureBox.Bounds.IntersectsWith(x.Bounds))
                    {
                        
                        trexPictureBox.Image = Resources.dead;
                        scoreLabel.Text += " Press R to restart the game!";
                        isGameOver = true;
                    }
                }
            }
            if (score > 5)
            {
                obstacleSpeed = 15;
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && jumping == false)
            {
                jumping = true;
            }

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (jumping == true)
            {
                jumping = false;
            }

            if (e.KeyCode == Keys.R && isGameOver == true)
            {
                GameReset();
            }
        }

    }
}
