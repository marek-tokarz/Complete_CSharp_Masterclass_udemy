using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace InvoiceManagement
{
    /// <summary>
    /// Logika interakcji dla klasy LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
        }

        public void OnLoginBtnClicked(object sender, EventArgs e)
        {
            string passwordEntered = PasswordBox.Password;
            string? envPw = System.Environment.GetEnvironmentVariable("InvoiceManagement");

            if (envPw != null)
            {
                if (passwordEntered == envPw)
                {
                    MessageBox.Show("Entered correct password");
                }
                else
                {
                    MessageBox.Show("Entered wrong password");
                }
            }else
            {
                MessageBox.Show("Enviroment variable not found");
            }
        }
    }
}
