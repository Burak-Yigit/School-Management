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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
            _employeeService=InstanceFactory.GetInstance<IEmployeeService>();
            _positionService = InstanceFactory.GetInstance<IPositionService>();
            _branchService = InstanceFactory.GetInstance<IBranchService>();
            _departmentService = InstanceFactory.GetInstance<IDepartmentService>();
        }
        IEmployeeService _employeeService;
        IPositionService _positionService;
        IBranchService _branchService;
        IDepartmentService _departmentService;

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            try
            {
                _employeeService.Add(new Employee
                {
                    DepartmentId = Convert.ToInt32(cmbxDepartment.SelectedValue),
                    PositionId = Convert.ToInt32(cmbxPosition.SelectedValue),
                    BranchId = Convert.ToInt32(cmbxBranch.SelectedValue),
                    FirstName = tbxFirstName.Text,
                    LastName = tbxLastName.Text,
                    BirthDate = dtpBirthdate.Value,
                    HireDate = dtpHireDate.Value,
                    PhoneNumber = mtbxPhoneNumber.Text,
                    Salary = Convert.ToInt32(tbxSalary.Text),
                    IsMarried = rbtnSingle.Checked ? false : true,
                    IsEmployee = true

                }) ;
                MessageBox.Show("New Employee has been added to the database successfully");
                LoadEmployees();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
        }
        private void LoadEmployees()
        {
            dgvEmployee.DataSource = _employeeService.GetAll();
        }
        private void LoadPositions()
        {
            cmbxPosition.DataSource= _positionService.GetAll();
            cmbxPosition.DisplayMember = "PositionName";
            cmbxPosition.ValueMember = "PositionID";
        }
        private void LoadDepartments()
        {
            cmbxDepartment.DataSource= _departmentService.GetAll();
            cmbxDepartment.DisplayMember = "DepartmentName";
            cmbxDepartment.ValueMember = "DepartmentID";
        }
        private void LoadBranches()
        {
            cmbxBranch.DataSource= _branchService.GetAll();
            cmbxBranch.DisplayMember = "BranchName";
            cmbxBranch.ValueMember = "BranchID";
        }
        private void btnAddEmployee_Load(object sender, EventArgs e)
        {
            LoadEmployees();
            LoadPositions();
            LoadDepartments();
            LoadBranches();
        }

       
    }
}
