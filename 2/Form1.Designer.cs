﻿namespace _2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            update_button = new Button();
            groupBox1 = new GroupBox();
            delete_landing_button = new Button();
            edit_landing_button = new Button();
            add_landing_button = new Button();
            tabPage2 = new TabPage();
            dataGridView2 = new DataGridView();
            update_button_knigi = new Button();
            groupBox2 = new GroupBox();
            delete_landing2_button = new Button();
            edit_landing2_button = new Button();
            add_landing2_button = new Button();
            tabPage3 = new TabPage();
            dataGridView3 = new DataGridView();
            update_button_chitateli = new Button();
            groupBox3 = new GroupBox();
            delete_landing3_button = new Button();
            edit_landing3_button = new Button();
            add_landing3_button = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(949, 573);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged_1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(update_button);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 3, 3, 3);
            tabPage1.Size = new Size(941, 540);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Выдача";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 81);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(929, 451);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // update_button
            // 
            update_button.Location = new Point(325, 32);
            update_button.Name = "update_button";
            update_button.Size = new Size(94, 29);
            update_button.TabIndex = 1;
            update_button.Text = "Обновить";
            update_button.UseVisualStyleBackColor = true;
            update_button.Click += update_button_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(delete_landing_button);
            groupBox1.Controls.Add(edit_landing_button);
            groupBox1.Controls.Add(add_landing_button);
            groupBox1.Location = new Point(8, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(311, 69);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Управление";
            // 
            // delete_landing_button
            // 
            delete_landing_button.Location = new Point(208, 27);
            delete_landing_button.Name = "delete_landing_button";
            delete_landing_button.Size = new Size(94, 29);
            delete_landing_button.TabIndex = 2;
            delete_landing_button.Text = "Удалить";
            delete_landing_button.UseVisualStyleBackColor = true;
            // 
            // edit_landing_button
            // 
            edit_landing_button.Location = new Point(106, 27);
            edit_landing_button.Name = "edit_landing_button";
            edit_landing_button.Size = new Size(94, 29);
            edit_landing_button.TabIndex = 1;
            edit_landing_button.Text = "Изменит";
            edit_landing_button.UseVisualStyleBackColor = true;
            // 
            // add_landing_button
            // 
            add_landing_button.Location = new Point(6, 27);
            add_landing_button.Name = "add_landing_button";
            add_landing_button.Size = new Size(94, 29);
            add_landing_button.TabIndex = 0;
            add_landing_button.Text = "Добавить";
            add_landing_button.UseVisualStyleBackColor = true;
            add_landing_button.Click += add_landing_button_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Controls.Add(update_button_knigi);
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 3, 3, 3);
            tabPage2.Size = new Size(941, 540);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Книги";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(6, 83);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(930, 451);
            dataGridView2.TabIndex = 3;
            // 
            // update_button_knigi
            // 
            update_button_knigi.Location = new Point(325, 32);
            update_button_knigi.Name = "update_button_knigi";
            update_button_knigi.Size = new Size(94, 29);
            update_button_knigi.TabIndex = 2;
            update_button_knigi.Text = "Обновить";
            update_button_knigi.UseVisualStyleBackColor = true;
            update_button_knigi.Click += update_button_knigi_Click_1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(delete_landing2_button);
            groupBox2.Controls.Add(edit_landing2_button);
            groupBox2.Controls.Add(add_landing2_button);
            groupBox2.Location = new Point(8, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(311, 69);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Управление";
            // 
            // delete_landing2_button
            // 
            delete_landing2_button.Location = new Point(208, 27);
            delete_landing2_button.Name = "delete_landing2_button";
            delete_landing2_button.Size = new Size(94, 29);
            delete_landing2_button.TabIndex = 2;
            delete_landing2_button.Text = "Удалить";
            delete_landing2_button.UseVisualStyleBackColor = true;
            // 
            // edit_landing2_button
            // 
            edit_landing2_button.Location = new Point(106, 27);
            edit_landing2_button.Name = "edit_landing2_button";
            edit_landing2_button.Size = new Size(94, 29);
            edit_landing2_button.TabIndex = 1;
            edit_landing2_button.Text = "Изменит";
            edit_landing2_button.UseVisualStyleBackColor = true;
            // 
            // add_landing2_button
            // 
            add_landing2_button.Location = new Point(6, 27);
            add_landing2_button.Name = "add_landing2_button";
            add_landing2_button.Size = new Size(94, 29);
            add_landing2_button.TabIndex = 0;
            add_landing2_button.Text = "Добавить";
            add_landing2_button.UseVisualStyleBackColor = true;
            add_landing2_button.Click += add_landing2_button_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dataGridView3);
            tabPage3.Controls.Add(update_button_chitateli);
            tabPage3.Controls.Add(groupBox3);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(941, 540);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Читатели";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(3, 79);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.ReadOnly = true;
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.RowTemplate.Height = 29;
            dataGridView3.Size = new Size(930, 451);
            dataGridView3.TabIndex = 4;
            // 
            // update_button_chitateli
            // 
            update_button_chitateli.Location = new Point(325, 29);
            update_button_chitateli.Name = "update_button_chitateli";
            update_button_chitateli.Size = new Size(94, 29);
            update_button_chitateli.TabIndex = 3;
            update_button_chitateli.Text = "Обновить";
            update_button_chitateli.UseVisualStyleBackColor = true;
            update_button_chitateli.Click += update_button_chitateli_Click_1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(delete_landing3_button);
            groupBox3.Controls.Add(edit_landing3_button);
            groupBox3.Controls.Add(add_landing3_button);
            groupBox3.Location = new Point(8, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(311, 69);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Управление";
            // 
            // delete_landing3_button
            // 
            delete_landing3_button.Location = new Point(208, 27);
            delete_landing3_button.Name = "delete_landing3_button";
            delete_landing3_button.Size = new Size(94, 29);
            delete_landing3_button.TabIndex = 2;
            delete_landing3_button.Text = "Удалить";
            delete_landing3_button.UseVisualStyleBackColor = true;
            // 
            // edit_landing3_button
            // 
            edit_landing3_button.Location = new Point(106, 27);
            edit_landing3_button.Name = "edit_landing3_button";
            edit_landing3_button.Size = new Size(94, 29);
            edit_landing3_button.TabIndex = 1;
            edit_landing3_button.Text = "Изменит";
            edit_landing3_button.UseVisualStyleBackColor = true;
            // 
            // add_landing3_button
            // 
            add_landing3_button.Location = new Point(6, 27);
            add_landing3_button.Name = "add_landing3_button";
            add_landing3_button.Size = new Size(94, 29);
            add_landing3_button.TabIndex = 0;
            add_landing3_button.Text = "Добавить";
            add_landing3_button.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 573);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Библиотека";
            Load += Form1_Load_1;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button update_button;
        private GroupBox groupBox1;
        private Button delete_landing_button;
        private Button edit_landing_button;
        private Button add_landing_button;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private DataGridView dataGridView2;
        private Button update_button_knigi;
        private GroupBox groupBox2;
        private Button delete_landing2_button;
        private Button edit_landing2_button;
        private Button add_landing2_button;
        private GroupBox groupBox3;
        private Button delete_landing3_button;
        private Button edit_landing3_button;
        private Button add_landing3_button;
        private DataGridView dataGridView3;
        private Button update_button_chitateli;
        private DataGridView dataGridView1;
    }
}