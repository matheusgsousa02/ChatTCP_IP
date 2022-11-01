using System;
using System.Threading;
using System.Windows.Forms;

namespace ChatTCP_IP
{
    public partial class Login : Form
    {
        Thread th;
        public string userName { get; set; }
        public Login()
        {
            InitializeComponent();
        }

        public void openMDI()
        {
            var user = userName;
            Application.Run(new Chat(user));
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(UserNameTextBox.Text))
            {
                userName = UserNameTextBox.Text;
                this.Close();
                th = new Thread(openMDI);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
        }
    }
}
