﻿using School.Business.Abstract;
using School.Business.DependencyResolvers.Ninject;
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
    public partial class UpdateParent : Form
    {
        public UpdateParent()
        {
            InitializeComponent();
            _motherService = InstanceFactory.GetInstance<IMotherService>();
            _fatherService = InstanceFactory.GetInstance<IFatherService>();
            _relationService = InstanceFactory.GetInstance<IRelationService>();
            ListMothers();
            ListFathers();
        }
        IMotherService _motherService;
        IFatherService _fatherService;
        IRelationService _relationService;
        private void ListMothers()
        {
            dgvMotherList.DataSource = _motherService.GetAll().Where(p => p.IsActive == true).ToList();
        }
        private void ListFathers()
        {
            dgvFatherList.DataSource = _fatherService.GetAll().Where(p=>p.IsActive==true).ToList();
        }
        private void btnUpdateMother_Click(object sender, EventArgs e)
        {
            if (dgvMotherList.CurrentRow == null)
            {
                MessageBox.Show("Choose a person from the list!");
            }
            else
            {
                try
                {
                    _motherService.Update(new Mother
                    {
                        MotherId = Convert.ToInt32(dgvMotherList.CurrentRow.Cells[0].Value),
                        FirstName = tbxMFirstName.Text,
                        LastName = tbxMLastName.Text,
                        PhoneNumber = mtbxMPhoneNumber.Text,
                        IsActive = true
                    });
                    MessageBox.Show($"The person whose ID is {Convert.ToInt32(dgvMotherList.CurrentRow.Cells[0].Value)} has been updated as '{tbxMFirstName.Text} {tbxMLastName.Text} {mtbxMPhoneNumber.Text}' ");
                    ListMothers();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }
        private void btnUpdateFather_Click(object sender, EventArgs e)
        {
            if (dgvFatherList.CurrentRow == null)
            {
                MessageBox.Show("Choose a person from the list!");
            }
            else
            {
                try
                {
                    _fatherService.Update(new Father
                    {
                        FatherId = Convert.ToInt32(dgvFatherList.CurrentRow.Cells[0].Value),
                        FirstName = tbxFFirstName.Text,
                        LastName = tbxFLastName.Text,
                        PhoneNumber = mtbxFPhoneNumber.Text,
                        IsActive = true
                    });
                    MessageBox.Show($"The person whose ID is {Convert.ToInt32(dgvFatherList.CurrentRow.Cells[0].Value)} has been updated as '{tbxFFirstName.Text} {tbxFLastName.Text} {mtbxFPhoneNumber.Text}' ");
                    ListFathers();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }
        private void dgvMotherList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvMotherList.CurrentRow;
            tbxMFirstName.Text = row.Cells[1].Value.ToString();
            tbxMLastName.Text  = row.Cells[2].Value.ToString();
            mtbxMPhoneNumber.Text = row.Cells[3].Value.ToString();
        }

        private void dgvFatherList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvFatherList.CurrentRow;
            tbxFFirstName.Text = row.Cells[1].Value.ToString();
            tbxFLastName.Text = row.Cells[2].Value.ToString();
            mtbxFPhoneNumber.Text = row.Cells[3].Value.ToString();
        }

        private void btnDeleteMother_Click(object sender, EventArgs e)
        {
            if (dgvMotherList.CurrentRow == null)
            {
                MessageBox.Show("Choose a person from the list!");
            }
            else
            {
                try
                {
                    _motherService.Update(new Mother
                    {
                        MotherId = Convert.ToInt32(dgvMotherList.CurrentRow.Cells[0].Value),
                        FirstName = tbxMFirstName.Text,
                        LastName = tbxMLastName.Text,
                        PhoneNumber = mtbxMPhoneNumber.Text,
                        IsActive = false
                    });
                    MessageBox.Show($"The person whose ID is {Convert.ToInt32(dgvMotherList.CurrentRow.Cells[0].Value)} has been updated as '{tbxMFirstName.Text} {tbxMLastName.Text} {mtbxMPhoneNumber.Text}' ");
                    ListMothers();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void btnDeleteFather_Click(object sender, EventArgs e)
        {
            if (dgvFatherList.CurrentRow == null)
            {
                MessageBox.Show("Choose a person from the list!");
            }
            else
            {
                try
                {
                    _fatherService.Update(new Father
                    {
                        FatherId = Convert.ToInt32(dgvFatherList.CurrentRow.Cells[0].Value),
                        FirstName = tbxFFirstName.Text,
                        LastName = tbxFLastName.Text,
                        PhoneNumber = mtbxFPhoneNumber.Text,
                        IsActive = false
                    });
                    MessageBox.Show($"The person whose ID is {Convert.ToInt32(dgvFatherList.CurrentRow.Cells[0].Value)} has been deleted as '{tbxFFirstName.Text} {tbxFLastName.Text} {mtbxFPhoneNumber.Text}' ");
                    ListFathers();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }
    }
}
