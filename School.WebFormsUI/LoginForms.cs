using School.Business.Abstract;
using School.Business.DependencyResolvers.Ninject;
using School.DataAccess.Abstract;
using School.DataAccess.Concrete.EntityFramework;
using School.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School.WebFormsUI
{
    public partial class LoginForms : Form
    {
        
        public LoginForms()
        {
            InitializeComponent();
            _authenticatorService = InstanceFactory.GetInstance<IAuthenticatorService>();
        }
        IAuthenticatorService _authenticatorService;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username=tbxUsername.Text;
            string password=tbxPassword.Text;
            try
            {
                var result = _authenticatorService.Authenticate(username, password);
                if (result != null)
                {
                    MessageBox.Show($"Dear {username}, you have successfully logged in as admin.");
                    MainMenuForms mainMenu = new MainMenuForms();
                    this.Hide();
                    mainMenu.ShowDialog();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Your username or password might be wrong!");
                }
                
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
        }

        private void LoginForms_Load(object sender, EventArgs e)
        {

        }
    }
}
