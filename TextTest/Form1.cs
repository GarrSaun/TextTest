using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace TextTest
{
    public partial class Form1 : Form
    {
        int scene = 0;
        Boolean nextEnabled = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            if (nextEnabled == true)
            {
                scene++;
                nextEnabled = false;

                switch (scene)
                {
                    case 1:
                        type("(Crash)");
                        break;
                    case 2:
                        textLabel.Text = "Austria-Hungary:";
                        type(" Kyaaaaaaaaaa!");
                        break;
                    case 3:
                        textLabel.Text = "Austria-Hungary:";
                        type(" Help me Senpai!");
                        break;
                }
            }
        }

        public void type(string text)
        {
            for (int i = 0; i < text.Length; i++) 
            {
                textLabel.Text += text.ElementAt(i);
                textLabel.Refresh();
                Thread.Sleep(100);
            }

            nextEnabled = true;
        }

    }


}
