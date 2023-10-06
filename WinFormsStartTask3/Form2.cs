using WinFormsStartTask3.Properties;

namespace WinFormsStartTask3
{
    public partial class Form2 : Form
    {
        System.Windows.Forms.Timer timer;
        DateTime bakuTime;
        DateTime londonTime;
        bool CheckBaku, CheckLondon;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckBaku = true;
            CheckLondon = false;
            timer.Start();
            label1.Visible = true;
            pictureBox1.Image = Resources.Baku;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CheckBaku = false;
            CheckLondon = true;
            timer.Start();
            label1.Visible = true;
            pictureBox1.Image = Resources.London;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;

            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            bakuTime = DateTime.UtcNow.AddHours(4);
            londonTime = DateTime.UtcNow.AddHours(1);
            if (CheckBaku) { label1.Text = bakuTime.ToLongTimeString(); }
            else if (CheckLondon) { label1.Text = londonTime.ToLongTimeString(); }
        }
    }
}