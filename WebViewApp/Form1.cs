namespace WebViewApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ir_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri(textBox1.Text);
        }
    }
}
