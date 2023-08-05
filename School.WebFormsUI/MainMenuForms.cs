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
    public partial class MainMenuForms : Form
    {
        public MainMenuForms()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult logout = MessageBox.Show("Are you sure you want to log out?","", MessageBoxButtons.YesNo);
            if (logout == DialogResult.Yes) 
            {
                LoginForms loginForm = new LoginForms();
                this.Hide();
                loginForm.ShowDialog();
                
            }
        }

        private void btnAddParent_Click(object sender, EventArgs e)
        {
            AddParentForms addParent = new AddParentForms();
            addParent.ShowDialog();
        }

        private void MainMenuForms_Load(object sender, EventArgs e)
        {

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            StudentForms studentForm = new StudentForms();
            studentForm.ShowDialog();
        }
    }
}
