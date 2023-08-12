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
        
        private void LoadStudents()
        {
            dgvStudents.DataSource = _studentService.GetAll();
        }
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                int motherId=0;
                int fatherId=0;
                if (cmbxRelation.SelectedItem is Relation selectedRelation)
                {
                    motherId = selectedRelation.MotherId;
                    fatherId = selectedRelation.FatherId;
                    // Burada motherId'yi istediğiniz gibi kullanabilirsiniz.
                }
                _studentService.Add(new Student
                {
                    FirstName = tbxSFirstName.Text,
                    LastName = tbxSLastName.Text,
                    RelationId = _relationService.GetRelationId(motherId,fatherId),
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
