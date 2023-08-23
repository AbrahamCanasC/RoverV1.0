namespace WinFormsApp1
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

        private void BtnConfiguracion_Click(object sender, EventArgs e)
        {
            Form IrConf = new Form2();
            IrConf.Show();
        }
    }
}