namespace WindowSignIn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            string userId = id.Text;
            string userPassword = password.Text;

            if (userId.Equals("MyId") && userPassword.Equals("MyPassword"))
            {
                MessageBox.Show("�α��ο� �����߽��ϴ�.", "�α���");
            }
            else
            {
                MessageBox.Show("�α��ο� �����߽��ϴ�.", "�α���");
            }
        }
    }
}