using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollatzConjecture
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            startCollatzConjectureButton.Enabled = false;
        }

        private void startCollatzConjectureButton_Click(object sender, EventArgs e)
        {

            int step = 1;

            if (stepsListBox.Items.Count > 0)
            {
                stepsListBox.Items.Clear();
            }

            try
            {

                int num = Int32.Parse(userInputTF.Text);
                stepsListBox.Items.Add("Starting value: " + num);

                while(num != 1)
                {

                    if(num % 2 == 0)
                    {
                        num = num / 2;
                        stepsListBox.Items.Add("Step " + step + ": " + num);
                        step += 1;
                    }
                    else
                    {
                        num = num * 3 + 1;
                        stepsListBox.Items.Add("Step " + step + ": " + num);
                        step += 1;
                    }

                }

            }catch(FormatException num)
            {
                MessageBox.Show("You have entered something invalid, please enter a number.");
                userInputTF.Text = "";
            }

        }

        private void userInputTF_TextChanged(object sender, EventArgs e)
        {

            if(userInputTF.Text.Equals("") || userInputTF.Text.StartsWith(" "))
            {
                startCollatzConjectureButton.Enabled = false;
            }
            else
            {
                startCollatzConjectureButton.Enabled = true;
            }

        }
    }
}
