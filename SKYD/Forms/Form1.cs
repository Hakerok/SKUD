﻿using System;
using System.Windows.Forms;
using SKYD.Classes.SQL;
using SKYD.Forms;

namespace SKYD
{
    public partial class Form1 : Form
    {
        SqlClass sqlClass = new SqlClass();
        public Form1()
        {
            InitializeComponent();
            ComboBoxFilling();
            
            
        }
        private void импортИзExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (
                MessageBox.Show(@"Вы действительно хотите выйти", @"Выход", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }
        private void button6_Click(object sender, EventArgs e)
        {
            dorm.SelectedIndex = 0;
            department.SelectedIndex = 0;
            subdivision.Items.Clear();
            courses.Items.Clear();
            subdivision.Enabled = false;
            courses.Enabled = false;
        }
        public void ComboBoxFilling()
        {
            
            sqlClass.Combobox(department, dorm);
            department.DropDownStyle = ComboBoxStyle.DropDownList;
            subdivision.DropDownStyle = ComboBoxStyle.DropDownList;
            dorm.DropDownStyle = ComboBoxStyle.DropDownList;
            courses.DropDownStyle = ComboBoxStyle.DropDownList;
            subdivision.Enabled = false;
            courses.Enabled = false;
        }

        private void OpenEntry_Click(object sender, EventArgs e)
        {
            var openEntry = new OpenEntry {Owner = this};
            openEntry.ShowDialog();
           
        }

      private void department_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (department.SelectedIndex == 0 || department.SelectedIndex == 2 || department.SelectedIndex == 4)
              {
                  subdivision.Enabled = false;
                  courses.Enabled = false;
              }
            else
              {
                  subdivision.Enabled = true;
                  courses.Enabled = true;
              }
              courses.Items.Clear();
              sqlClass.Comboboxad(subdivision, department);
              
        }

      private void subdivision_SelectionChangeCommitted(object sender, EventArgs e)
      {
          
          if (department.SelectedIndex == 1)
          {
              sqlClass.Comboboxcourses(subdivision, courses);  
          }
      }

      private void состояниеТурникетовToolStripMenuItem_Click(object sender, EventArgs e)
      {
          var turnstiles = new turnstiles { Owner = this };
          turnstiles.ShowDialog();
      }

      private void добавтьТуToolStripMenuItem_Click(object sender, EventArgs e)
      {
          update_turnstiles updaturn = new update_turnstiles();
          updaturn.ShowDialog();
      }

       
    }
}                                           