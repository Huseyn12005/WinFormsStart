using System;

namespace WinFormsStart
{
    public partial class Form1 : Form
    {
        private Random random;
        public Form1()
        {
            random = new Random();
            InitializeComponent();
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            int newWidth = random.Next(0, ClientSize.Width - label1.Width+10);
            int newHeight = random.Next(0, ClientSize.Height - label1.Height+10);
            label1.Location = new Point(newWidth, newHeight);
        }


    }
}