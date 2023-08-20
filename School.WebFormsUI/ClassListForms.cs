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
        SchoolContext _context = new SchoolContext();
        public ClassListForms()
        {
            InitializeComponent();
            _classService = InstanceFactory.GetInstance<IClassService>();
            _classMemberService = InstanceFactory.GetInstance<IClassMemberService>();
            _classTeacherService = InstanceFactory.GetInstance<IClassTeacherService>();
            _employeeService = InstanceFactory.GetInstance<IEmployeeService>();
            _gradeService = InstanceFactory.GetInstance<IGradeService>();
            _classCodeService= InstanceFactory.GetInstance<IClassCodeService>();
            _lessonService= InstanceFactory.GetInstance<ILessonService>();
            _studentService  = InstanceFactory.GetInstance<IStudentService>();

        }
        IClassService _classService;
        IClassMemberService _classMemberService;
        IClassTeacherService _classTeacherService;
        IEmployeeService _employeeService;
        IGradeService _gradeService;
        IClassCodeService _classCodeService;
        ILessonService _lessonService;
        IStudentService _studentService;
        private void ClassListForms_Load(object sender, EventArgs e)
        {
            LoadEmployees();
            LoadEmployees();
            LoadClassesList();
            LoadClassesForTeacherList();
            LoadLessons();
            LoadStudents();
            LoadClassesForStudents();
            TeacherList();
            StudentList();
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
                MessageBox.Show("An error occurred while loading the Teacher list: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadStudents()
        {
            try
            {
                List<Student> students = _studentService.GetAll();
                cmbxLStudentName.DataSource = students;

                // Set a custom DisplayMember using the Format event of the ComboBox
                cmbxLStudentName.Format += (sender, e) =>
                {
                    if (e.ListItem is Student student)
                    {
                        e.Value = $"{student.FirstName} {student.LastName}";
                    }
                };

                cmbxLStudentName.ValueMember = "StudentId";
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during data retrieval.
                MessageBox.Show("An error occurred while loading the Student list: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void LoadLessons()
        {
            cmbxLessons.DataSource = _lessonService.GetAll();
            cmbxLessons.DisplayMember = "LessonName";
            cmbxLessons.ValueMember = "LessonId";
        }
        private void LoadClassesForStudents()
        {
            cmbxLGrade.DataSource = _gradeService.GetAll();
            cmbxLGrade.DisplayMember = "GradeNumber";
            cmbxLGrade.ValueMember = "GradeId";

            cmbxLClass.DataSource = _classCodeService.GetAll();
            cmbxLClass.DisplayMember = "ClassCodeLetter";
            cmbxLClass.ValueMember = "ClassCodeId";
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
                        EmployeeId =Convert.ToInt32(cmbxTeacherId.SelectedValue),
                        LessonId = Convert.ToInt32(cmbxLessons.SelectedValue)
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

                string gradeNumber = cmbxGradeId.Text;
                string classCode = cmbxClassCode.Text;
                MessageBox.Show($"{gradeNumber}-{classCode} class has successfully been added.");
            }
            else
            {
                MessageBox.Show("This class has already been added before!");
                return;
            }
           
        }
        private void TeacherList()
        {
            try
            {
                var dbRelations = (from cm in _context.ClassTeachers
                                   join l in _context.Lessons on cm.LessonId equals l.LessonId
                                   join c in _context.Classes on cm.ClassId equals c.ClassId
                                   join cg in _context.Grades on c.GradeID equals cg.GradeId
                                   join cc in _context.ClassCodes on c.ClassCodeId equals cc.ClassCodeId
                                   join e in _context.Employees on cm.EmployeeId equals e.EmployeeId
                                   select new
                                   {
                                       cm.ClassTeacherId,
                                       c.ClassId,
                                       e.EmployeeId,
                                       l.LessonId,
                                       l.LessonName,
                                       cg.GradeNumber,
                                       cc.ClassCodeLetter,
                                       e.FirstName,
                                       e.LastName,

                                   }).ToList();
                var teacherList = dbRelations.Select(r => new
                {
                    ClassTeacherId = r.ClassTeacherId,
                    ClassId = r.ClassId,
                    EmployeeId = r.EmployeeId,
                    LessonId = r.LessonId,
                    DisplayText = $"{r.GradeNumber}-{r.ClassCodeLetter} {r.FirstName} {r.LastName} {r.LessonName}"
                }).ToList();

                dgvTeacherList.DataSource = teacherList;
                dgvTeacherList.Columns["DisplayText"].HeaderText = "Class Teacher";
                dgvTeacherList.Columns["ClassTeacherId"].Visible = false;
                dgvTeacherList.Columns["ClassId"].Visible = false;
                dgvTeacherList.Columns["EmployeeId"].Visible = false;
                dgvTeacherList.Columns["LessonId"].Visible = false;
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
           
        }
        private void StudentList()
        {
            dgvStudentList.DataSource = _classMemberService.GetAll();
        }
        private void cmbxTeacherId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddStudentToClass_Click(object sender, EventArgs e)
        {
            int classId = Convert.ToInt32(cmbxLClass.SelectedValue);
            int gradeId = Convert.ToInt32(cmbxLGrade.SelectedValue);
            _classMemberService.Add(new ClassMember
            {
                ClassId= Convert.ToInt32(_classService.GetClassId(classId, gradeId)),
                StudentId = Convert.ToInt32(cmbxLStudentName.SelectedValue)
            });
            MessageBox.Show($"{cmbxLStudentName.Text} has successfully been added to {cmbxLGrade.Text}-{cmbxLClass.Text} class!");
        }
    }
}
