using School.Business.Abstract;
using School.Business.DependencyResolvers.Ninject;
using School.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School.WebFormsUI
{
    public partial class AddParentForms : Form
    {
        public AddParentForms()
        {
            InitializeComponent();
            _motherService = InstanceFactory.GetInstance<IMotherService>();
            _fatherService = InstanceFactory.GetInstance<IFatherService>();
            _relationService = InstanceFactory.GetInstance<IRelationService>();
        }
        IMotherService _motherService;
        IFatherService _fatherService;
        IRelationService _relationService;

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void AddParentForms_Load(object sender, EventArgs e)
        {
            LoadMotherList();
            LoadFatherList();
            LoadCmbMotherList();
            LoadCmbFatherList();
            LoadRelationList();
        }
        private void LoadMotherList()
        {
            dgvMotherList.DataSource = _motherService.GetAll();
        }
        private void LoadFatherList()
        {
            dgvFatherList.DataSource = _fatherService.GetAll();
        }
        private void LoadRelationList()
        {
           dgvRelations.DataSource = _relationService.GetAll(); 
           
        }

        private void btnAddMother_Click(object sender, EventArgs e)
        {
            try
            {
                _motherService.Add(new Mother
                {
                    FirstName = tbxMFirstName.Text,
                    LastName = tbxMLastName.Text,
                    PhoneNumber = mtbxMPhoneNumber.Text
                });
                tbxMFirstName.Clear();
                tbxMLastName.Clear();
                mtbxMPhoneNumber.Clear();
                LoadMotherList();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
        }
        private void LoadCmbMotherList()
        {
            try
            {
                List<Mother> mothers = _motherService.GetAll();
                cmbxMother.DataSource = mothers;

                // Set a custom DisplayMember using the Format event of the ComboBox
                cmbxMother.Format += (sender, e) =>
                {
                    if (e.ListItem is Mother mother)
                    {
                        e.Value = $"{mother.FirstName} {mother.LastName}";
                    }
                };

                cmbxMother.ValueMember = "MotherId"; // Assuming Mother class has MotherId property
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during data retrieval.
                MessageBox.Show("An error occurred while loading the mother list: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadCmbFatherList()
        {
             
            try
            {
                List<Father> fathers = _fatherService.GetAll();
                cmbxFather.DataSource = fathers;

                // Set a custom DisplayMember using the Format event of the ComboBox
                cmbxFather.Format += (sender, e) =>
                {
                    if (e.ListItem is Father father)
                    {
                        e.Value = $"{father.FirstName} {father.LastName}";
                    }
                };

                cmbxFather.ValueMember = "FatherID"; // Assuming Mother class has MotherId property
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during data retrieval.
                MessageBox.Show("An error occurred while loading the mother list: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAddFather_Click(object sender, EventArgs e)
        {
            try
            {
                _fatherService.Add(new Father
                {
                    FirstName = tbxFFirstName.Text,
                    LastName = tbxFLastName.Text,
                    PhoneNumber = mtbxFPhoneNumber.Text


                });
                tbxFFirstName.Clear();
                tbxFLastName.Clear();
                mtbxFPhoneNumber.Clear();
                LoadFatherList();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }

        }

        private void btnAddRelation_Click(object sender, EventArgs e)
        {
            try
            {
                int motherID = Convert.ToInt32(cmbxMother.SelectedValue);
                int fatherID = Convert.ToInt32(cmbxFather.SelectedValue);
                if(_relationService.RelationExists(motherID, fatherID))
                {
                    MessageBox.Show("Seçili velilerden biri zaten daha önce eklenmiş.");
                    return;
                }
                _relationService.AddRelation(new Relation
                {
                    MotherID= motherID,
                    FatherID= fatherID
                });

                LoadRelationList();
                MessageBox.Show("Added Successfully");
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException exception)
            {

                MessageBox.Show("Zaten bu kişiler eklenmiş.");
            }
        }
    }
}
