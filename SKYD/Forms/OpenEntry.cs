using System;
using System.Windows.Forms;
using SKYD.Classes.SQL;
using  MetroFramework.Forms;

namespace SKYD.Forms
{
    public partial class OpenEntry : MetroForm
    {
        
        public readonly SqlClass SqlClass = new SqlClass();
        public OpenEntry()
        {
            InitializeComponent();
            Form1 main = new Form1();
            main.Hide();
            SqlClass.Combobox(comboBox2, comboBox1);
            Checbox();
            
        }

        public OpenEntry(string idstring)
        {
            InitializeComponent();
            Form1 main = new Form1();
            main.Hide();
            btadd_edit.Text = @"Обновить данные";
            Text = @"Обновление записи";
            exit.Text = @"Отменить изменения";
        }
        private void OpenEntry_Load(object sender, EventArgs e)
        {
           
        }

        private void Checbox()
        {
            checkBox1.Text = @"Главный корпус";
            checkBox2.Text = @"Морфологический корус";
            checkBox3.Text = @"Санитарно-гигиенический корпус";
            checkBox4.Text = @"Фармацевтический корпус";
            checkBox5.Text = @"Общежитие №1";
            checkBox6.Text = @"Общежитие №2";
            checkBox7.Text = @"Общежитие №4";
            checkBox1.Checked = true;
            checkBox2.Checked = true;
            checkBox3.Checked = true;
            checkBox4.Checked = true;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox5.Checked) return;
            comboBox1.SelectedIndex = 1;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
               checkBox5.Checked = false;
               checkBox6.Checked = false;
               checkBox7.Checked = false;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                checkBox5.Checked = true;
                checkBox6.Checked = false;
                checkBox7.Checked = false;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                checkBox6.Checked = true;
                checkBox5.Checked = false;
                checkBox7.Checked = false;
            }
            if (comboBox1.SelectedIndex == 3)
            {
                checkBox7.Checked = true;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox6.Checked) return;
            comboBox1.SelectedIndex = 2;
            checkBox5.Checked = false;
            checkBox7.Checked = false;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox7.Checked) return;
            comboBox1.SelectedIndex = 3;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void Skip_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch))
            {
                e.Handled = true;

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlClass.Comboboxad(comboBox5,comboBox2);
            
        }

        private void exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Сохранить значения?", @"Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

            }
            else
            {
                Close();
            }
        }

       
    }
}
