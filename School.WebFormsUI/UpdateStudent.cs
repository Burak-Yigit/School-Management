using School.Business.Abstract;
using School.Business.DependencyResolvers.Ninject;
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
    public partial class UpdateStudent : Form
    {
        public UpdateStudent()
        {
            InitializeComponent();
            _studentService = InstanceFactory.GetInstance<IStudentService>();
            _relationService = InstanceFactory.GetInstance<IRelationService>();
            ListStudents();
            ListRelations();

        }
        SchoolContext _context = new SchoolContext();
        IStudentService _studentService;
        IRelationService _relationService;
        private void ListStudents()
        {
            dgvStudents.DataSource = cbStudents.Checked ? _studentService.GetAll().ToList() : _studentService.GetAll().Where(x=>x.IsActive==true).ToList();
        }
        private void ListRelations()
        {
            var dbRelations = (from r in _context.Relations
                               join f in _context.Fathers on r.FatherId equals f.FatherId
                               join m in _context.Mothers on r.MotherId equals m.MotherId
                               select new
                               {
                                   r.RelationId,
                                   FatherId = f.FatherId,
                                   MotherId = m.MotherId,
                                   FatherFirstName = f.FirstName,
                                   FatherLastName = f.LastName,
                                   MotherFirstName = m.FirstName,
                                   MotherLastName = m.LastName
                               })
                          .ToList();

            var relations = dbRelations.Select(r => new Relation
            {
                RelationId = r.RelationId,
                FatherId = r.FatherId,
                MotherId = r.MotherId,
                DisplayText = $"{r.RelationId} {r.FatherFirstName} {r.FatherLastName} {r.MotherFirstName} {r.MotherLastName}"
            }).ToList();

            cmbxRelation.DataSource = relations;
            cmbxRelation.DisplayMember = "DisplayText";
            cmbxRelation.ValueMember = "RelationId";
        }
        private void UpdateStudent_Load(object sender, EventArgs e)
        {

        }

        

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvStudents.CurrentRow;
            
            tbxSFirstName.Text= row.Cells[2].Value.ToString();
            tbxSLastName.Text = row.Cells[3].Value.ToString();
            dtpSBirthdate.Text = row.Cells[5].Value.ToString();
            dtpRegistrationDate.Text= row.Cells[6].Value.ToString();
            if (row.Cells[8].Value is true)
            {
                cbActive.Checked = true;
            }
            else
            {
                cbActive.Checked= false;
            }
            if (row.Cells[7].Value.ToString() == "Male")
            {
                rbMale.Checked = true;
            }
            else
            {
                rbFemale.Checked = true;
            }
            cmbxRelation.Text = row.Cells[1].Value.ToString();
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow == null)
            {
                MessageBox.Show("Choose a person from the list!");
            }
            else
            {
                try
                {
                    _studentService.Update(new Student
                    {
                        StudentId = Convert.ToInt32(dgvStudents.CurrentRow.Cells[0].Value),
                        RelationId=Convert.ToInt32(cmbxRelation.SelectedValue),
                        FirstName = tbxSFirstName.Text,
                        LastName = tbxSLastName.Text,
                        Birthdate = dtpSBirthdate.Value,
                        Gender = rbMale.Checked ? "Male":"Female",
                        IsActive=cbActive.Checked?true:false,
                        RegistrationDate= dtpRegistrationDate.Value

                    });
                    MessageBox.Show($"The person whose ID is {Convert.ToInt32(dgvStudents.CurrentRow.Cells[0].Value)} has been updated as '{tbxSFirstName.Text} {tbxSLastName.Text}' ");
                    ListStudents();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {

        }

        private void cbActive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbStudents_CheckedChanged(object sender, EventArgs e)
        {
            ListStudents();
        }
    }
}
