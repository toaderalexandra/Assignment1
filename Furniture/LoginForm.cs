using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Furniture_Ob;
using Furniture_B;

namespace Furniture
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            string username = username_txt.Text;
            string pass = password_txt.Text;
            User user = new User();
            user = lg.ProcessLogin(username, pass);           

            if (user == null)
            {
                MessageBox.Show("The username or the password is incorrect");
            }

            if (user is AdminUser)
            {
                this.Hide();
                AdminForm adminForm = new AdminForm();
                adminForm.Show();
            }
            else if (user is RegularUser)
            {
                this.Hide();
                EmployeeForm userForm = new EmployeeForm();
                userForm.Show();
            }
        }

        
    }
}
