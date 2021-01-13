using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Running_Pug
{
    public partial class Form1 : Form
    {

        bool jump = false;
        int jumpSpeed = 15;
        double gravity = 18;
        int time = 0;
        int lives = 5;
        int obstacleSpeed = 10;
        int heartSpeed = 10;
        int heartShowRate; 

        Random rand = new Random();
        bool isGameOver = false;


        public Form1()
        {
            InitializeComponent();
            reset();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TimerEvent(object sender, EventArgs e)
        {
            pug.Top += jumpSpeed;
            textLives.Text = "Lives: " + lives;

            if (jump == true && gravity < 0)
            {
                jump = false;
            }

            if (jump == true)
            {
                jumpSpeed = -15;
                gravity -= 1;
            } else
            {
                jumpSpeed = 15;
            }

            if (pug.Top > 183 && jump == false)
            {
                gravity = 18;
                pug.Top = 186;
                jumpSpeed = 0;
            }
            fireHydrantMovement();
            heartMovement();

            checkDeath();
        }

        //Function that controls the movement of the firehydrant
        private void fireHydrantMovement()
        {
            obstacleSpeed = rand.Next(1, 10);

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "fireHydrant")
                {

                    x.Left -= obstacleSpeed;
                    if (x.Left < -100)
                    {
                       x.Left = this.ClientSize.Width + rand.Next(200, 500) + (x.Width * 15);
                    }

                    if(pug.Bounds.IntersectsWith(x.Bounds))
                    {
                        fireHydrant.Location = new Point(900, 205);
                        lives-= 1;
                    }
                }
            }
        }

        //Function that controls the movement of the heart
        private void heartMovement()
        {
            heartSpeed = rand.Next(5, 10);
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "heart")
                {
                    //if statement to randomize the appearance of the heart
                    heartShowRate = rand.Next(1, 20);
                    if (heartShowRate % 4 == 0)
                    {
                        x.Left -= heartSpeed;
                        if (x.Left < -100)
                        {
                            x.Left = this.ClientSize.Width + rand.Next(200, 500) + (x.Width * 15);
                        }

                    }

                    if (pug.Bounds.IntersectsWith(x.Bounds))
                    {
                        heart.Location = new Point(900, 135);
                        lives += 1;
                    }
                }
            }
        }

        private void isKeyDown(object sender, KeyEventArgs e)
        {
            //checks if the player is pressing the UP key, and if they are already jumping 
            if(e.KeyCode == Keys.Up && jump == false)
            {
                jump = true;
            }
        }

        private void isKeyUp(object sender, KeyEventArgs e)
        {
            if (jump == true)
            {
                jump = false;
            }

            //Check if the player wants to reset the game state
            if (e.KeyCode == Keys.R && isGameOver == true)
            {
                reset();
            }
        }

        //Function to reset the game back to its orignal state, ready to start again
        private void reset()
        {
            gravity = 18;
            jumpSpeed = 0;
            jump = false;
            time = 0;
            obstacleSpeed = 10;

            textTime.Text = "Time: " + time;
            lives = 5;
            textLives.Text ="Lives: " + lives;

            pug.Image = Properties.Resources.runningPug_smaller;
            isGameOver = false;
            pug.Top = 186;

            fireHydrant.Top = 205;
            heart.Top = 135;

            gameTimer.Start();
        }


        //Timer counter with 1000 interval to tick each second
        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            textTime.Text = "Time: " + time;

        }

        private void checkDeath()
        {
            if (lives < 0)
            {
                isGameOver = true;
                gameTimer.Stop();
                counter.Stop();
                finalTime.Text = "Final Time: " + time;
                finalMessage.Text = "Press 'R' to beat that lame score of yours!";
            }
        }

        private void finalTime_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
