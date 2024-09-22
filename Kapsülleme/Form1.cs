namespace Kapsülleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Araba rb = new Araba();

            rb.renk = "Kırmızı";
            rb.durum = '0';
            rb.hiz = 160;
            rb.motor = 1.6;
            rb.fiyat = 1000000;

            rb.YIL = -2020;
            rb.MARKA = "Polo";

            label1.Text = rb.renk;
            label2.Text = rb.durum.ToString();
            label3.Text = rb.motor.ToString();
            label4.Text = rb.fiyat.ToString();
            label5.Text = rb.YIL.ToString();
            label6.Text = rb.hiz.ToString();
            label7.Text = rb.MARKA.ToString();

        }
    }
}
