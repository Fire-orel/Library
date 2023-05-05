namespace _2
{
    partial class vidacha
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            kniga_edit_vidacha = new TextBox();
            chitatel_edit_vadacha = new TextBox();
            data_vidachi_edit_vidacha = new TextBox();
            data_vozvrata_edit_vidacha = new TextBox();
            save_vidacha = new Button();
            Exit_vidacha = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(51, 21);
            label1.TabIndex = 0;
            label1.Text = "Книга";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 1;
            label2.Text = "Читатель";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 109);
            label3.Name = "label3";
            label3.Size = new Size(102, 21);
            label3.TabIndex = 2;
            label3.Text = "Дата выдачи";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 154);
            label4.Name = "label4";
            label4.Size = new Size(102, 21);
            label4.TabIndex = 3;
            label4.Text = "Дата выдачи";
            // 
            // kniga_edit_vidacha
            // 
            kniga_edit_vidacha.Location = new Point(128, 24);
            kniga_edit_vidacha.Name = "kniga_edit_vidacha";
            kniga_edit_vidacha.Size = new Size(100, 23);
            kniga_edit_vidacha.TabIndex = 4;
            // 
            // chitatel_edit_vadacha
            // 
            chitatel_edit_vadacha.Location = new Point(128, 67);
            chitatel_edit_vadacha.Name = "chitatel_edit_vadacha";
            chitatel_edit_vadacha.Size = new Size(100, 23);
            chitatel_edit_vadacha.TabIndex = 5;
            // 
            // data_vidachi_edit_vidacha
            // 
            data_vidachi_edit_vidacha.Location = new Point(128, 111);
            data_vidachi_edit_vidacha.Name = "data_vidachi_edit_vidacha";
            data_vidachi_edit_vidacha.Size = new Size(100, 23);
            data_vidachi_edit_vidacha.TabIndex = 6;
            // 
            // data_vozvrata_edit_vidacha
            // 
            data_vozvrata_edit_vidacha.Location = new Point(128, 156);
            data_vozvrata_edit_vidacha.Name = "data_vozvrata_edit_vidacha";
            data_vozvrata_edit_vidacha.Size = new Size(100, 23);
            data_vozvrata_edit_vidacha.TabIndex = 7;
            // 
            // save_vidacha
            // 
            save_vidacha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            save_vidacha.Location = new Point(22, 210);
            save_vidacha.Name = "save_vidacha";
            save_vidacha.Size = new Size(92, 31);
            save_vidacha.TabIndex = 8;
            save_vidacha.Text = "Сохранить";
            save_vidacha.UseVisualStyleBackColor = true;
            save_vidacha.Click += save_vidacha_Click;
            // 
            // Exit_vidacha
            // 
            Exit_vidacha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Exit_vidacha.Location = new Point(136, 210);
            Exit_vidacha.Name = "Exit_vidacha";
            Exit_vidacha.Size = new Size(92, 31);
            Exit_vidacha.TabIndex = 9;
            Exit_vidacha.Text = "Отмена";
            Exit_vidacha.UseVisualStyleBackColor = true;
            Exit_vidacha.Click += Exit_vidacha_Click;
            // 
            // vidacha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(264, 266);
            Controls.Add(Exit_vidacha);
            Controls.Add(save_vidacha);
            Controls.Add(data_vozvrata_edit_vidacha);
            Controls.Add(data_vidachi_edit_vidacha);
            Controls.Add(chitatel_edit_vadacha);
            Controls.Add(kniga_edit_vidacha);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "vidacha";
            Text = "Выдача";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox kniga_edit_vidacha;
        private TextBox chitatel_edit_vadacha;
        private TextBox data_vidachi_edit_vidacha;
        private TextBox data_vozvrata_edit_vidacha;
        private Button save_vidacha;
        private Button Exit_vidacha;
    }
}