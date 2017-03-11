using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using SKYD.Classes.SQL;
using System.Threading;
using  MetroFramework.Forms;
namespace SKYD.Forms
{
    public partial class Form1 : MetroForm
    {
       
      readonly SqlClass _sqlClass = new SqlClass();

      public Form1()
        {
            InitializeComponent();
            ComboBoxFilling();
            KeyPreview = true;
           // sqlClass.tablemain(mainDataGrid);
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(60);
                Opacity = Opacity + 0.1;
            }
           
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

      public void ComboBoxFilling()
        {
            
            _sqlClass.Combobox(department, dorm);
            department.DropDownStyle = ComboBoxStyle.DropDownList;
            subdivision.DropDownStyle = ComboBoxStyle.DropDownList;
            dorm.DropDownStyle = ComboBoxStyle.DropDownList;
            courses.DropDownStyle = ComboBoxStyle.DropDownList;
            subdivision.Enabled = false;
            courses.Enabled = false;
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
              _sqlClass.Comboboxad(subdivision, department);
              
        }

      private void subdivision_SelectionChangeCommitted(object sender, EventArgs e)
      {
          
          if (department.SelectedIndex == 1)
          {
              _sqlClass.Comboboxcourses(subdivision, courses);  
          }
      }

      private void состояниеТурникетовToolStripMenuItem_Click(object sender, EventArgs e)
      {
          var turnstiles = new Turnstiles { Owner = this };
          turnstiles.ShowDialog();
      }

      private void добавтьТуToolStripMenuItem_Click(object sender, EventArgs e)
      {
          UpdateTurnstiles updaturn = new UpdateTurnstiles();
          updaturn.ShowDialog();
      }

      private void добавитьНовогоПользователяToolStripMenuItem_Click(object sender, EventArgs e)
      {
            var openEntry = new OpenEntry { Owner = this };
              openEntry.ShowDialog();
       
      }

      private void Form1_KeyDown(object sender, KeyEventArgs e)
      {
           if (e.KeyCode ==Keys.A && e.Control)
           {
               addperson.PerformClick();
           }
          if (e.KeyCode == Keys.F1)
          {
              reference.PerformClick();
          }
          if (e.KeyCode == Keys.F2)
          {
              reference.PerformClick();
          }
          if (e.KeyCode == Keys.X && e.Control)
          {
              exitm.PerformClick();
          }
          if (e.KeyCode == Keys.E && e.Control)
          {
              addturn.PerformClick();
          }
          if (e.KeyCode == Keys.R && e.Control)
          {
              statuturn.PerformClick();
          }
      }

      private void reference_Click(object sender, EventArgs e)
      {
          var reference = new reference { Owner = this };
            reference.ShowDialog();
      }

      private void просмотрДанныхToolStripMenuItem_Click(object sender, EventArgs e)
      {
          if (mainDataGrid.CurrentRow != null)
          {
              var openEntry = new OpenEntry(mainDataGrid[0, mainDataGrid.CurrentRow.Index].Value.ToString());
              openEntry.ShowDialog();
          }
          else
          {
              MessageBox.Show(@"Не выбранно не одного поля",@"Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
          }
      }

      private void просмотрПользователейToolStripMenuItem_Click(object sender, EventArgs e)
      {
         Authorizationdatabase authorization = new Authorizationdatabase();
          authorization.ShowDialog();
      }

      private void button2_Click(object sender, EventArgs e)
      {
        
          if (radioButton3.Checked)
          {  
              textBox1.Text = @"Номер зачетной книжки";
          }
          if (radioButton2.Checked)
          {
              textBox1.Text = @"Номер пропуска";
          }
          if (radioButton1.Checked)
          {
              textBox1.Text = @"Фамилия";
          }
          if (radioButton4.Checked)
          {
              textBox1.Text = @"Группа";
          }
      }

      private void Form1_FormClosed(object sender, FormClosedEventArgs e)
      {
          if (
               MessageBox.Show(@"Вы действительно хотите выйти", @"Выход", MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question) == DialogResult.Yes)
          {
              Application.Exit();
          }
      }

      private void courses_SelectedIndexChanged(object sender, EventArgs e)
      {

      }

        private void SortReset_Click(object sender, EventArgs e)
        {

        }

        private void редакторСправочникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Directory formDirectory = new Directory();
            formDirectory.ShowDialog();
        }

      

       
    }
}                                           
