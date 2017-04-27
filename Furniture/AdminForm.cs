using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Furniture_B;
using Furniture_DA;
using Furniture_Ob;

namespace Furniture
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            //this.Username = username;
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                User user = getUserInfo();

                IDBMUser db = new UserDB();
                db.AddUser(user);
                ///// EmptyControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void btnEditUser_Click(object sender, EventArgs e)
        {
            try
            {
                User user = getUserInfo();

                IDBMUser db = new UserDB();
                db.UpdateUser(user);
                //EmptyControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                User user = getUserInfo();

                IDBMUser db = new UserDB();
                db.DeleteUser(user);
                //EmptyControls();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private User getUserInfo()
        {
            User user = new User();
            user.ID = Convert.ToInt32(txtUserID.Text);
            user.Name = txtName.Text;
            user.BirthDate = dtpUserBirthDate.Value;
            user.Address = txtUserAddress.Text;
            return user;

        }
        private void EmptyControls()
        {
            txtUserID.Text = string.Empty;
            txtName.Text = string.Empty;
            dtpUserBirthDate.Value = DateTime.Now;
            txtUserAddress.Text = string.Empty;
            if (gridUsers.SelectedRows.Count > 0)
            {
                gridUsers.SelectedRows[0].Selected = false;
            }
        }

        private void logout_b_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();

        }
    }
}

