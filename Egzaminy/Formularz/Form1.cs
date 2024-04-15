namespace Formularz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string small_Letters = "qwertyuiopasdfghjklzxcvbnm";

        string big_Letters = "QWERTYUIOPASDFGHJKLZXCVBNM";

        string numbers = "1234567890";

        string password = "";

        string special_characters = "!@#$%^&*()+-=";

        Random random = new Random();

        private void generate_Click(object sender, EventArgs e)
        {
            password = "";
            int length = Convert.ToInt32(type_pass.Text);

            if (characters.Checked)
            {
                password += big_Letters[random.Next(0, big_Letters.Length)];
            }
            if (digits.Checked)
            {
                password += numbers[random.Next(0, numbers.Length)];
            }
            if (special.Checked)
            {
                password += special_characters[random.Next(0, special_characters.Length)];
            }
            while (password.Length < length)
            {
                password += small_Letters[random.Next(0, small_Letters.Length)];
            }
            MessageBox.Show(password);
        }

        private void alter_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Name: " + name_box.Text + " secName: " + secName_box.Text + " Job: " + job_select.Text + " Password: " + password);
        }
    }
}