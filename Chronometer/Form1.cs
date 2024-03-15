namespace Chronometer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int seconds;


        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private int ConvertToMinutes(int seconds)
        {
            return seconds / 60;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            seconds = 0;
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void UpdateTimeLabel()
        {
            int minutes = seconds / 60;
            int remainingSeconds = seconds % 60;
            label1.Text = $"{minutes:D2}:{remainingSeconds:D2}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            seconds = 0;
            UpdateTimeLabel();

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

            seconds++;
            UpdateTimeLabel();
        }
    }
}