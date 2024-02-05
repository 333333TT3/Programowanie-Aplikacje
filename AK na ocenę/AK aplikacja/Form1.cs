namespace AK_aplikacja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mail_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(mailBox.Text.Contains('@')))
            {
                Powitanie.Text = "Nieprawidlowy adres e-mail";
            }

            else if (PasswordBox.Text != RepPasswordBox.Text) 
            {
                Powitanie.Text = "Hasla sa rozne";
            }

             else
             {
                Powitanie.Text = "Witaj" + mailBox.Text;
             }
        }
    }
}