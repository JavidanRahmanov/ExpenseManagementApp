using System;
using System.Linq;
using System.Windows.Forms;
using ExpenseManagementApp;
using ExpenseManagementApp.Data;

namespace ExpenseApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Kullanıcı girişini kontrol et
            string username = Username.Text;
            string password = Password.Text;

            using (var context = new MyDbContext())
            {
                var user = context.Users
                                  .FirstOrDefault(u => u.Username == username && u.Password == password);

                if (user != null)
                {
                    // Başarılı giriş
                    MessageBox.Show("Giriş Başarılı!");
                    MainForm mainForm = new MainForm();
                    this.Hide();
                    mainForm.Show();
                }
                else
                {
                    // Başarısız giriş
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
