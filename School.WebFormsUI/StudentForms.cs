using School.Business.Abstract;
using School.Business.Concrete;
using School.Business.DependencyResolvers.Ninject;
using School.DataAccess.Concrete.EntityFramework;
using School.Entities.Abstract;
using School.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School.WebFormsUI
{
    public partial class StudentForms : Form
    {
        public StudentForms()
        {
            InitializeComponent();
            _relationService = InstanceFactory.GetInstance<IRelationService>();
            _studentService = InstanceFactory.GetInstance<IStudentService>();
        }
        IRelationService _relationService;
        IStudentService _studentService;
        SchoolContext _context = new SchoolContext();
        private void StudentForms_Load(object sender, EventArgs e)
        {
            LoadRelations();
            LoadStudents();
        }
        private void LoadRelations()
        {
            var relations = (from r in _context.Relations
                             join f in _context.Fathers on r.FatherId equals f.FatherId
                             join m in _context.Mothers on r.MotherId equals m.MotherId
                             select new
                             {
                                 r.RelationId,
                                 FatherFirstName = f.FirstName,
                                 FatherLastName = f.LastName,
                                 MotherFirstName = m.FirstName,
                                 MotherLastName = m.LastName
                             })
                 .ToList();

            var formattedRelations = relations.Select(r => $"{r.RelationId} {r.FatherFirstName} {r.FatherLastName} {r.MotherFirstName} {r.MotherLastName}")
                                              .ToList();

            cmbxRelation.DataSource = formattedRelations;
            cmbxRelation.ValueMember = ""; 
        }
        private void LoadStudents()
        {
            dgvStudents.DataSource = _studentService.GetAll();
        }
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                
                
                _studentService.Add(new Student
                {
                    FirstName = tbxSFirstName.Text,
                    LastName = tbxSLastName.Text,
                    RelationId = cmbxRelation.SelectedIndex + 1,
                    Birthdate = dtpSBirthdate.Value,
                    RegistrationDate = dtpRegistrationDate.Value,
                    Gender = rbMale.Checked ? "Male" : "Female"

            }) ;
                LoadStudents();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
        }
    }
}
