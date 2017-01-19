using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SKYD.Classes.SQL
{
    internal class SqlClass
    {
        public SqlConnection SqlCon =
            new SqlConnection(
                @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\User\documents\visual studio 2013\Projects\SKYD\SKYD\DataBase\skyd.mdf;Integrated Security=True");

        public void Combobox(ComboBox unitcb, ComboBox dormcb)
        {
            unitcb.Items.Add(@"Подразделения");
            dormcb.Items.Add(@"Номер общежития");

            unitcb.SelectedIndex = 0;
            dormcb.SelectedIndex = 0;

            const string sql = "SELECT * FROM dbo.unit";
            const string sql1 = "SELECT * FROM dbo.dorm";
            var sqlDa = new SqlDataAdapter(sql, SqlCon);
            var dtMain = new DataTable();
            try
            {
                sqlDa.Fill(dtMain);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            for (int i = 0; i < dtMain.Rows.Count; i++)
            {
                var temp = new BdClass.Unit
                {
                    Id = (int) dtMain.Rows[i]["id_Unit"],
                    Name = dtMain.Rows[i]["name_Unit"].ToString(),
                };
                unitcb.Items.AddRange(new object[] {temp.Name});
            }
            var sqlDa1 = new SqlDataAdapter(sql1, SqlCon);
            var dtMain1 = new DataTable();
            try
            {
                sqlDa1.Fill(dtMain1);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            for (int i = 0; i < dtMain1.Rows.Count; i++)
            {
                var temp = new BdClass.Dorm
                {
                    Id = (int) dtMain1.Rows[i]["id_dorm"],
                    Name = dtMain1.Rows[i]["name_dorm"].ToString(),

                };
                dormcb.Items.AddRange(new object[] {temp.Name});
            }


        }

        public void Comboboxad(ComboBox subdivisioncb, ComboBox unitcb)
        {
            subdivisioncb.Items.Clear();
            if (unitcb.SelectedIndex == 1)
            {
                subdivisioncb.Items.Add(@"Факультеты");
                subdivisioncb.SelectedIndex = 0;
                const string sql = "SELECT * FROM dbo.faculties";
                var sqlDa = new SqlDataAdapter(sql, SqlCon);
                var dtMain = new DataTable();
                try
                {
                    sqlDa.Fill(dtMain);
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
                for (int i = 0; i < dtMain.Rows.Count; i++)
                {
                    var temp = new BdClass.Faculties
                    {
                        Id = (int) dtMain.Rows[i]["id_faculties"],
                        Name = dtMain.Rows[i]["name_faculties"].ToString(),
                    };
                    subdivisioncb.Items.AddRange(new object[] {temp.Name});
                }
            }
            if (unitcb.SelectedIndex == 3)
            {
                subdivisioncb.Items.Add(@"Факультеты");
                subdivisioncb.SelectedIndex = 0;
                const string sql = "SELECT * FROM dbo.fpps";
                var sqlDa = new SqlDataAdapter(sql, SqlCon);
                var dtMain = new DataTable();
                try
                {
                    sqlDa.Fill(dtMain);
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
                for (int i = 0; i < dtMain.Rows.Count; i++)
                {
                    var temp = new BdClass.Fpps
                    {
                        Id = (int)dtMain.Rows[i]["id_fpps"],
                        Name = dtMain.Rows[i]["name_fpps"].ToString(),
                    };
                    subdivisioncb.Items.AddRange(new object[] { temp.Name });
                }
            }

        }

        public void Comboboxcourses(ComboBox subdivisioncb, ComboBox coursescb)
        {
            coursescb.Items.Clear();
            if (subdivisioncb.SelectedIndex == 1 || subdivisioncb.SelectedIndex == 2 || subdivisioncb.SelectedIndex == 4)
            {
                coursescb.Items.Add(@"Курс");
                coursescb.SelectedIndex = 0;
                const string sql = "SELECT * FROM dbo.courses";
                var sqlDa = new SqlDataAdapter(sql, SqlCon);
                var dtMain = new DataTable();
                try
                {
                    sqlDa.Fill(dtMain);
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
                for (int i = 0; i < dtMain.Rows.Count; i++)
                {
                    var temp = new BdClass.Courses
                    {
                        Id = (int) dtMain.Rows[i]["id_courses"],
                        Name = dtMain.Rows[i]["name_courses"].ToString(),
                    };
                    coursescb.Items.AddRange(new object[] {temp.Name});
                }
            }
            if (subdivisioncb.SelectedIndex == 3 || subdivisioncb.SelectedIndex == 5)
            {
              coursescb.Items.Add(@"Курс");
                coursescb.SelectedIndex = 0;
                const string sql = "SELECT * FROM dbo.courses";
                var sqlDa = new SqlDataAdapter(sql, SqlCon);
                var dtMain = new DataTable();
                try
                {
                    sqlDa.Fill(dtMain);
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
                for (int i = 0; i < dtMain.Rows.Count; i++)
                {
                    var temp = new BdClass.Courses
                    {
                        Id = (int) dtMain.Rows[i]["id_courses"],
                        Name = dtMain.Rows[i]["name_courses"].ToString(),
                    };
                    coursescb.Items.AddRange(new object[] {temp.Name});
                }
                coursescb.Items.RemoveAt(6);
            }
            if (subdivisioncb.SelectedIndex == 6)
            {
                coursescb.Items.Add(@"Курс");
                coursescb.SelectedIndex = 0;
                const string sql = "SELECT * FROM dbo.courses";
                var sqlDa = new SqlDataAdapter(sql, SqlCon);
                var dtMain = new DataTable();
                try
                {
                    sqlDa.Fill(dtMain);
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
                for (int i = 0; i < dtMain.Rows.Count; i++)
                {
                    var temp = new BdClass.Courses
                    {
                        Id = (int)dtMain.Rows[i]["id_courses"],
                        Name = dtMain.Rows[i]["name_courses"].ToString(),
                    };
                    coursescb.Items.AddRange(new object[] { temp.Name });
                }
                coursescb.Items.RemoveAt(6);
                coursescb.Items.RemoveAt(5);

                }
            }
        }
    }
