namespace Forms
{
    partial class CreateAndEditOrderWindow
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
            this.volumeNumeric = new System.Windows.Forms.NumericUpDown();
            this.managerComboBox = new System.Windows.Forms.ComboBox();
            this.materialComboBox = new System.Windows.Forms.ComboBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumeNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.volumeNumeric);
            this.panel1.Controls.Add(this.managerComboBox);
            this.panel1.Controls.Add(this.materialComboBox);
            this.panel1.Controls.Add(this.datePicker);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 311);
            this.panel1.TabIndex = 1;
            // 
            // volumeNumeric
            // 
            this.volumeNumeric.Location = new System.Drawing.Point(336, 56);
            this.volumeNumeric.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.volumeNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.volumeNumeric.Name = "volumeNumeric";
            this.volumeNumeric.Size = new System.Drawing.Size(264, 26);
            this.volumeNumeric.TabIndex = 9;
            this.volumeNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // managerComboBox
            // 
            this.managerComboBox.FormattingEnabled = true;
            this.managerComboBox.Location = new System.Drawing.Point(336, 231);
            this.managerComboBox.Name = "managerComboBox";
            this.managerComboBox.Size = new System.Drawing.Size(264, 27);
            this.managerComboBox.TabIndex = 8;
            // 
            // materialComboBox
            // 
            this.materialComboBox.FormattingEnabled = true;
            this.materialComboBox.Location = new System.Drawing.Point(336, 135);
            this.materialComboBox.Name = "materialComboBox";
            this.materialComboBox.Size = new System.Drawing.Size(264, 27);
            this.materialComboBox.TabIndex = 8;
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(28, 135);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 26);
            this.datePicker.TabIndex = 7;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(28, 56);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(264, 26);
            this.nameTextBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Менеджер";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Материал";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Дата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Тираж";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название";
            // 
            // saveBtn
            // 
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveBtn.Location = new System.Drawing.Point(28, 221);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(111, 43);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // CreateAndEditOrderWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 311);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MaximumSize = new System.Drawing.Size(650, 350);
            this.MinimumSize = new System.Drawing.Size(650, 350);
            this.Name = "CreateAndEditOrderWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ведение заказов для типографии - Создание и редактирование заказа";
            this.Load += new System.EventHandler(this.WindowLoad);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumeNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private NumericUpDown volumeNumeric;
        private ComboBox managerComboBox;
        private ComboBox materialComboBox;
        private DateTimePicker datePicker;
        private TextBox nameTextBox;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button saveBtn;
    }
}