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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace School.WebFormsUI
{
    public partial class ClassListForms : Form
    {
        public ClassListForms()
        {
            InitializeComponent();
            _classService = InstanceFactory.GetInstance<IClassService>();
            _classMemberService = InstanceFactory.GetInstance<IClassMemberService>();
            _classTeacherService = InstanceFactory.GetInstance<IClassTeacherService>();
            _employeeService = InstanceFactory.GetInstance<IEmployeeService>();
            _gradeService = InstanceFactory.GetInstance<IGradeService>();
            _classCodeService= InstanceFactory.GetInstance<IClassCodeService>();

        }
        IClassService _classService;
        IClassMemberService _classMemberService;
        IClassTeacherService _classTeacherService;
        IEmployeeService _employeeService;
        IGradeService _gradeService;
        IClassCodeService _classCodeService;
        private void ClassListForms_Load(object sender, EventArgs e)
        {
            LoadEmployees();
            LoadClassesList();
            LoadClassesForTeacherList();

        }
        private void LoadEmployees()
        {
            try
            {
                List<Employee> employees = _employeeService.GetAll();
                cmbxTeacherId.DataSource = employees;

                // Set a custom DisplayMember using the Format event of the ComboBox
                cmbxTeacherId.Format += (sender, e) =>
                {
                    if (e.ListItem is Employee employee)
                    {
                        e.Value = $"{employee.FirstName} {employee.LastName}";
                    }
                };

                cmbxTeacherId.ValueMember = "EmployeeId"; 
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during data retrieval.
                MessageBox.Show("An error occurred while loading the father list: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadClassesList()
        {
            try
            {
                cmbxGradeId.DataSource = _gradeService.GetAll();
                cmbxGradeId.DisplayMember = "GradeNumber";
                cmbxGradeId.ValueMember = "GradeId";

                cmbxClassCode.DataSource = _classCodeService.GetAll();
                cmbxClassCode.DisplayMember = "ClassCodeLetter";
                cmbxClassCode.ValueMember = "ClassCodeId";
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void LoadClassesForTeacherList()
        {
            try
            {
                cmbxTGrade.DataSource = _gradeService.GetAll();
                cmbxTGrade.DisplayMember = "GradeNumber";
                cmbxTGrade.ValueMember = "GradeId";

                cmbxTClass.DataSource = _classCodeService.GetAll();
                cmbxTClass.DisplayMember = "ClassCodeLetter";
                cmbxTClass.ValueMember = "ClassCodeId";
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
       
        private void btnAddTeacherToClass_Click(object sender, EventArgs e)
        {
            try
            {
                int classId = Convert.ToInt32(cmbxTClass.SelectedValue);
                int gradeId = Convert.ToInt32(cmbxTGrade.SelectedValue);
                if (_classService.Check(classId, gradeId) != null)
                {

                    _classTeacherService.Add(new ClassTeacher
                    {
                        ClassId = Convert.ToInt32(_classService.GetClassId(classId, gradeId)),
                        EmployeeId =Convert.ToInt32(cmbxTeacherId.SelectedValue)
                    });
                    MessageBox.Show("Added");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            int classId = Convert.ToInt32(cmbxClassCode.SelectedValue);
            int gradeId = Convert.ToInt32(cmbxGradeId.SelectedValue);
            if(_classService.Check(classId, gradeId)==null)
            {
                _classService.Add(new Class
                {
                    ClassCodeId = classId,
                    GradeID = gradeId
                });
            }
            else
            {
                MessageBox.Show("This class has already been added before!");
                return;
            }
           
        }

        private void cmbxTeacherId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
