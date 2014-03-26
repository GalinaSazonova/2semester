using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrissCross
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int check = 1;
        private void CheckClick(Button button)
        {
            if (check == 9)
            {
                if(button1.Text == button2.Text)
                {
                    if(button1.Text == button3.Text)
                    {
                        if (button1.Text == "x")
                        {
                            this.Text = "You win";
                        }
                        else
                        {
                            this.Text = "You lose";
                        }
                    }
                }
                else
                {
                    if (button4.Text == button5.Text)
                    {
                        if (button4.Text == button6.Text)
                        {
                            if (button4.Text == "x")
                            {
                                this.Text = "You win";
                            }
                            else
                            {
                                this.Text = "You lose";
                            }
                        }
                    }
                    else
                    {
                        if (button7.Text == button8.Text)
                        {
                            if (button7.Text == button9.Text)
                            {
                                if (button7.Text == "x")
                                {
                                    this.Text = "You win";
                                }
                                else
                                {
                                    this.Text = "You lose";
                                }
                            }
                        }
                        else 
                        {
                            if (button1.Text == button4.Text)
                            {
                                if (button1.Text == button7.Text)
                                {
                                    if (button1.Text == "x")
                                    {
                                        this.Text = "You win";
                                    }
                                    else
                                    {
                                        this.Text = "You lose";
                                    }
                                }
                            }
                            else
                            {
                                if (button2.Text == button5.Text)
                                {
                                    if (button2.Text == button8.Text)
                                    {
                                        if (button2.Text == "x")
                                        {
                                            this.Text = "You win";
                                        }
                                        else
                                        {
                                            this.Text = "You lose";
                                        }
                                    }
                                }
                                else
                                {
                                    if (button3.Text == button6.Text)
                                    {
                                        if (button3.Text == button9.Text)
                                        {
                                            if (button3.Text == "x")
                                            {
                                                this.Text = "You win";
                                            }
                                            else
                                            {
                                                this.Text = "You lose";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (button7.Text == button5.Text)
                                        {
                                            if (button7.Text == button3.Text)
                                            {
                                                if (button7.Text == "x")
                                                {
                                                    this.Text = "You win";
                                                }
                                                else
                                                {
                                                    this.Text = "You lose";
                                                }
                                            }
                                        }
                                        else
                                        {
                                            if (button9.Text == button5.Text)
                                            {
                                                if (button1.Text == button9.Text)
                                                {
                                                    if (button9.Text == "x")
                                                    {
                                                        this.Text = "You win";
                                                    }
                                                    else
                                                    {
                                                        this.Text = "You lose";
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (button.Text != "x" && button.Text != "o" && (check % 2 == 0))
            {
                button.Text = "o";
                check++;
            }
            if (button.Text != "x" && button.Text != "o" && (check % 2 == 1))
            {
                button.Text = "x";
                check++;
            }
        }

        private void LeftCornerClick(object sender, EventArgs e)
        {
            CheckClick(button1);
        }

        private void UpCenterClick(object sender, EventArgs e)
        {
            CheckClick(button2);
        }

        private void RightCornerClick(object sender, EventArgs e)
        {
            CheckClick(button3);
        }

        private void LeftCenterClick(object sender, EventArgs e)
        {
            CheckClick(button4);
        }

        private void CenterClick(object sender, EventArgs e)
        {
            CheckClick(button5);
        }

        private void RightCenterClick(object sender, EventArgs e)
        {
            CheckClick(button6);
        }

        private void LeftDownClick(object sender, EventArgs e)
        {
            CheckClick(button7);
        }

        private void DownCenterClick(object sender, EventArgs e)
        {
            CheckClick(button8);
        }

        private void DownRightClick(object sender, EventArgs e)
        {
            CheckClick(button9);
        }
    }
}
