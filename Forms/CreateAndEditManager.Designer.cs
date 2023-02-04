namespace Forms
{
    partial class CreateAndEditManager
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.appointmentTextBox = new System.Windows.Forms.TextBox();
            this.patronimycTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.appointmentTextBox);
            this.panel1.Controls.Add(this.patronimycTextBox);
            this.panel1.Controls.Add(this.surnameTextBox);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 311);
            this.panel1.TabIndex = 3;
            // 
            // appointmentTextBox
            // 
            this.appointmentTextBox.Location = new System.Drawing.Point(336, 135);
            this.appointmentTextBox.Name = "appointmentTextBox";
            this.appointmentTextBox.Size = new System.Drawing.Size(264, 26);
            this.appointmentTextBox.TabIndex = 6;
            // 
            // patronimycTextBox
            // 
            this.patronimycTextBox.Location = new System.Drawing.Point(28, 135);
            this.patronimycTextBox.Name = "patronimycTextBox";
            this.patronimycTextBox.Size = new System.Drawing.Size(264, 26);
            this.patronimycTextBox.TabIndex = 6;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(336, 56);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(264, 26);
            this.surnameTextBox.TabIndex = 6;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(28, 56);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(264, 26);
            this.nameTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Должность";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Имя";
            // 
            // saveBtn
            // 
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveBtn.Location = new System.Drawing.Point(28, 221);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(200, 43);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // CreateAndEditManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 311);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MaximumSize = new System.Drawing.Size(650, 350);
            this.MinimumSize = new System.Drawing.Size(650, 350);
            this.Name = "CreateAndEditManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ведение заказов для типографии - Создание и редактирование менеджера";
            this.Load += new System.EventHandler(this.WindowLoad);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox appointmentTextBox;
        private TextBox patronimycTextBox;
        private TextBox surnameTextBox;
        private TextBox nameTextBox;
        private Label label4;
        private Label label5;
        private Label label2;
        private Label label1;
        private Button saveBtn;
    }
}