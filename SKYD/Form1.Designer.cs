﻿namespace SKYD
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выгрузитьВБазуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экспортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экспортВKSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экспортВExelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.импортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.импортИзKSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.импортИзExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.терникетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавтьТуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.состояниеТурникетовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.SortReset = new System.Windows.Forms.Button();
            this.dorm = new System.Windows.Forms.ComboBox();
            this.OpenEntry = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.courses = new System.Windows.Forms.ComboBox();
            this.subdivision = new System.Windows.Forms.ComboBox();
            this.department = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.skydDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skydDataSet = new SKYD.skydDataSet();
            this.unitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unitTableAdapter = new SKYD.skydDataSetTableAdapters.unitTableAdapter();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skydDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skydDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.терникетыToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(932, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выгрузитьВБазуToolStripMenuItem,
            this.экспортToolStripMenuItem,
            this.импортToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выгрузитьВБазуToolStripMenuItem
            // 
            this.выгрузитьВБазуToolStripMenuItem.Name = "выгрузитьВБазуToolStripMenuItem";
            this.выгрузитьВБазуToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.выгрузитьВБазуToolStripMenuItem.Text = "Выгрузить в базу";
            // 
            // экспортToolStripMenuItem
            // 
            this.экспортToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.экспортВKSVToolStripMenuItem,
            this.экспортВExelToolStripMenuItem});
            this.экспортToolStripMenuItem.Name = "экспортToolStripMenuItem";
            this.экспортToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.экспортToolStripMenuItem.Text = "Экспорт";
            // 
            // экспортВKSVToolStripMenuItem
            // 
            this.экспортВKSVToolStripMenuItem.Name = "экспортВKSVToolStripMenuItem";
            this.экспортВKSVToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.экспортВKSVToolStripMenuItem.Text = "Экспорт в KCV";
            // 
            // экспортВExelToolStripMenuItem
            // 
            this.экспортВExelToolStripMenuItem.Name = "экспортВExelToolStripMenuItem";
            this.экспортВExelToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.экспортВExelToolStripMenuItem.Text = "Экспорт в Excel";
            // 
            // импортToolStripMenuItem
            // 
            this.импортToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.импортИзKSVToolStripMenuItem,
            this.импортИзExcelToolStripMenuItem});
            this.импортToolStripMenuItem.Name = "импортToolStripMenuItem";
            this.импортToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.импортToolStripMenuItem.Text = "Импорт";
            // 
            // импортИзKSVToolStripMenuItem
            // 
            this.импортИзKSVToolStripMenuItem.Name = "импортИзKSVToolStripMenuItem";
            this.импортИзKSVToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.импортИзKSVToolStripMenuItem.Text = "Импорт из KSV";
            // 
            // импортИзExcelToolStripMenuItem
            // 
            this.импортИзExcelToolStripMenuItem.Name = "импортИзExcelToolStripMenuItem";
            this.импортИзExcelToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.импортИзExcelToolStripMenuItem.Text = "Импорт из Excel";
            this.импортИзExcelToolStripMenuItem.Click += new System.EventHandler(this.импортИзExcelToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // терникетыToolStripMenuItem
            // 
            this.терникетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавтьТуToolStripMenuItem,
            this.состояниеТурникетовToolStripMenuItem});
            this.терникетыToolStripMenuItem.Name = "терникетыToolStripMenuItem";
            this.терникетыToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.терникетыToolStripMenuItem.Text = "Турникеты";
            // 
            // добавтьТуToolStripMenuItem
            // 
            this.добавтьТуToolStripMenuItem.Name = "добавтьТуToolStripMenuItem";
            this.добавтьТуToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.добавтьТуToolStripMenuItem.Text = "Добавить турникет";
            // 
            // состояниеТурникетовToolStripMenuItem
            // 
            this.состояниеТурникетовToolStripMenuItem.Name = "состояниеТурникетовToolStripMenuItem";
            this.состояниеТурникетовToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.состояниеТурникетовToolStripMenuItem.Text = "Состояние турникетов";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem1,
            this.оПрограммеToolStripMenuItem2});
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // оПрограммеToolStripMenuItem1
            // 
            this.оПрограммеToolStripMenuItem1.Name = "оПрограммеToolStripMenuItem1";
            this.оПрограммеToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem1.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem2
            // 
            this.оПрограммеToolStripMenuItem2.Name = "оПрограммеToolStripMenuItem2";
            this.оПрограммеToolStripMenuItem2.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem2.Text = "О программе";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(908, 436);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(900, 410);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Новые заявки";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(6, 221);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(885, 183);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(7, 21);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(875, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Новые абоненты системы:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 209);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(748, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Одобрить изменения";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(881, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Предоставление и блокировка доступа:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.SortReset);
            this.tabPage2.Controls.Add(this.dorm);
            this.tabPage2.Controls.Add(this.OpenEntry);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.dataGridView3);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(900, 410);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Общая база";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // SortReset
            // 
            this.SortReset.Location = new System.Drawing.Point(570, 71);
            this.SortReset.Name = "SortReset";
            this.SortReset.Size = new System.Drawing.Size(122, 23);
            this.SortReset.TabIndex = 3;
            this.SortReset.Text = "cброс сортировки";
            this.SortReset.UseVisualStyleBackColor = true;
            this.SortReset.Click += new System.EventHandler(this.button6_Click);
            // 
            // dorm
            // 
            this.dorm.FormattingEnabled = true;
            this.dorm.Location = new System.Drawing.Point(443, 73);
            this.dorm.Name = "dorm";
            this.dorm.Size = new System.Drawing.Size(121, 21);
            this.dorm.TabIndex = 5;
            // 
            // OpenEntry
            // 
            this.OpenEntry.Location = new System.Drawing.Point(7, 71);
            this.OpenEntry.Name = "OpenEntry";
            this.OpenEntry.Size = new System.Drawing.Size(117, 23);
            this.OpenEntry.TabIndex = 4;
            this.OpenEntry.Text = "открыть запись";
            this.OpenEntry.UseVisualStyleBackColor = true;
            this.OpenEntry.Click += new System.EventHandler(this.OpenEntry_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(756, 72);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "проверить изменения";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(7, 101);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(887, 303);
            this.dataGridView3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.courses);
            this.panel4.Controls.Add(this.subdivision);
            this.panel4.Controls.Add(this.department);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(436, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(458, 59);
            this.panel4.TabIndex = 1;
            // 
            // courses
            // 
            this.courses.FormattingEnabled = true;
            this.courses.Location = new System.Drawing.Point(301, 20);
            this.courses.Name = "courses";
            this.courses.Size = new System.Drawing.Size(121, 21);
            this.courses.TabIndex = 3;
            // 
            // subdivision
            // 
            this.subdivision.FormattingEnabled = true;
            this.subdivision.Location = new System.Drawing.Point(134, 20);
            this.subdivision.Name = "subdivision";
            this.subdivision.Size = new System.Drawing.Size(161, 21);
            this.subdivision.TabIndex = 2;
            this.subdivision.SelectionChangeCommitted += new System.EventHandler(this.subdivision_SelectionChangeCommitted);
            // 
            // department
            // 
            this.department.FormattingEnabled = true;
            this.department.Location = new System.Drawing.Point(7, 20);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(121, 21);
            this.department.TabIndex = 1;
            this.department.SelectionChangeCommitted += new System.EventHandler(this.department_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Сортировка абонентов";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.radioButton2);
            this.panel3.Controls.Add(this.radioButton1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(7, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(422, 59);
            this.panel3.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(342, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Найти";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(236, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(102, 21);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(127, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "по номеру пропуска";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(86, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "по фамилии";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Поиск абонента:";
            // 
            // skydDataSetBindingSource
            // 
            this.skydDataSetBindingSource.DataSource = this.skydDataSet;
            this.skydDataSetBindingSource.Position = 0;
            // 
            // skydDataSet
            // 
            this.skydDataSet.DataSetName = "skydDataSet";
            this.skydDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // unitBindingSource
            // 
            this.unitBindingSource.DataMember = "unit";
            this.unitBindingSource.DataSource = this.skydDataSetBindingSource;
            // 
            // unitTableAdapter
            // 
            this.unitTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 475);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skydDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skydDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button OpenEntry;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox subdivision;
        private System.Windows.Forms.ComboBox department;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SortReset;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem экспортToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem экспортВKSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem экспортВExelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem импортToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem импортИзKSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem импортИзExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem терникетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавтьТуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem состояниеТурникетовToolStripMenuItem;
        private System.Windows.Forms.ComboBox dorm;
        private System.Windows.Forms.ToolStripMenuItem выгрузитьВБазуToolStripMenuItem;
        private System.Windows.Forms.BindingSource skydDataSetBindingSource;
        private skydDataSet skydDataSet;
        private System.Windows.Forms.BindingSource unitBindingSource;
        private skydDataSetTableAdapters.unitTableAdapter unitTableAdapter;
        private System.Windows.Forms.ComboBox courses;
    }
}

