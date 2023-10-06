namespace WinFormsStartTask1
{
    public partial class Form3 : Form
    {
        int x, y, x_, y_;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x = Location.X;
            y = Location.Y;
        }

        private void Form3_MouseUp(object sender, MouseEventArgs e)
        {
            x_ = Location.X;
            y_ = Location.Y;

            label = new Label();
        }
    }
}