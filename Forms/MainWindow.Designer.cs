namespace Forms
{
    partial class MainWindow
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.orderDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.createOrderBtn = new System.Windows.Forms.Button();
            this.editOrderBtn = new System.Windows.Forms.Button();
            this.updateOrderBtn = new System.Windows.Forms.Button();
            this.deleteOrderBtn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.materialDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.createMaterialBtn = new System.Windows.Forms.Button();
            this.editMaterialBtn = new System.Windows.Forms.Button();
            this.updateMaterialBtn = new System.Windows.Forms.Button();
            this.deleteMaterialBtn = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.managersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.createManagerBtn = new System.Windows.Forms.Button();
            this.editManagerBtn = new System.Windows.Forms.Button();
            this.updateManagerBtn = new System.Windows.Forms.Button();
            this.deleteManagerBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialDataGridView)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.managersDataGridView)).BeginInit();
            this.tableLayoutPanel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1248, 838);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1240, 806);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Заказы";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.orderDataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.125F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.875F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1234, 800);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // orderDataGridView
            // 
            this.orderDataGridView.AllowUserToAddRows = false;
            this.orderDataGridView.AllowUserToDeleteRows = false;
            this.orderDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column11,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.orderDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderDataGridView.Location = new System.Drawing.Point(3, 68);
            this.orderDataGridView.Name = "orderDataGridView";
            this.orderDataGridView.ReadOnly = true;
            this.orderDataGridView.RowTemplate.Height = 25;
            this.orderDataGridView.Size = new System.Drawing.Size(1228, 729);
            this.orderDataGridView.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "№";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Название";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Дата";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Тираж";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Материал";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Менеджер";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.createOrderBtn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.editOrderBtn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.updateOrderBtn, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.deleteOrderBtn, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(561, 59);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // createOrderBtn
            // 
            this.createOrderBtn.BackColor = System.Drawing.Color.Transparent;
            this.createOrderBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createOrderBtn.Location = new System.Drawing.Point(3, 3);
            this.createOrderBtn.Name = "createOrderBtn";
            this.createOrderBtn.Size = new System.Drawing.Size(111, 49);
            this.createOrderBtn.TabIndex = 0;
            this.createOrderBtn.Text = "Создать";
            this.createOrderBtn.UseVisualStyleBackColor = false;
            this.createOrderBtn.Click += new System.EventHandler(this.OrderBtn_Click);
            // 
            // editOrderBtn
            // 
            this.editOrderBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editOrderBtn.Location = new System.Drawing.Point(120, 3);
            this.editOrderBtn.Name = "editOrderBtn";
            this.editOrderBtn.Size = new System.Drawing.Size(137, 49);
            this.editOrderBtn.TabIndex = 0;
            this.editOrderBtn.Text = "Редактировать";
            this.editOrderBtn.UseVisualStyleBackColor = true;
            this.editOrderBtn.Click += new System.EventHandler(this.OrderBtn_Click);
            // 
            // updateOrderBtn
            // 
            this.updateOrderBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateOrderBtn.Location = new System.Drawing.Point(263, 3);
            this.updateOrderBtn.Name = "updateOrderBtn";
            this.updateOrderBtn.Size = new System.Drawing.Size(137, 49);
            this.updateOrderBtn.TabIndex = 0;
            this.updateOrderBtn.Text = "Обновить";
            this.updateOrderBtn.UseVisualStyleBackColor = true;
            this.updateOrderBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // deleteOrderBtn
            // 
            this.deleteOrderBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteOrderBtn.Location = new System.Drawing.Point(406, 3);
            this.deleteOrderBtn.Name = "deleteOrderBtn";
            this.deleteOrderBtn.Size = new System.Drawing.Size(137, 49);
            this.deleteOrderBtn.TabIndex = 0;
            this.deleteOrderBtn.Text = "Удалить";
            this.deleteOrderBtn.UseVisualStyleBackColor = true;
            this.deleteOrderBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1240, 810);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Материал";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.materialDataGridView, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.125F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.875F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1234, 804);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // materialDataGridView
            // 
            this.materialDataGridView.AllowUserToAddRows = false;
            this.materialDataGridView.AllowUserToDeleteRows = false;
            this.materialDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.materialDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.materialDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materialDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Column9,
            this.Column10});
            this.materialDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialDataGridView.Location = new System.Drawing.Point(3, 68);
            this.materialDataGridView.Name = "materialDataGridView";
            this.materialDataGridView.ReadOnly = true;
            this.materialDataGridView.RowTemplate.Height = 25;
            this.materialDataGridView.Size = new System.Drawing.Size(1228, 733);
            this.materialDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "№";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Название";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Тип/Вид";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Размер";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.createMaterialBtn, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.editMaterialBtn, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.updateMaterialBtn, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.deleteMaterialBtn, 3, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(563, 59);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // createMaterialBtn
            // 
            this.createMaterialBtn.BackColor = System.Drawing.Color.Transparent;
            this.createMaterialBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createMaterialBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createMaterialBtn.Location = new System.Drawing.Point(3, 3);
            this.createMaterialBtn.Name = "createMaterialBtn";
            this.createMaterialBtn.Size = new System.Drawing.Size(111, 49);
            this.createMaterialBtn.TabIndex = 0;
            this.createMaterialBtn.Text = "Создать";
            this.createMaterialBtn.UseVisualStyleBackColor = false;
            this.createMaterialBtn.Click += new System.EventHandler(this.MaterialBtn_Click);
            // 
            // editMaterialBtn
            // 
            this.editMaterialBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editMaterialBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editMaterialBtn.Location = new System.Drawing.Point(120, 3);
            this.editMaterialBtn.Name = "editMaterialBtn";
            this.editMaterialBtn.Size = new System.Drawing.Size(137, 49);
            this.editMaterialBtn.TabIndex = 0;
            this.editMaterialBtn.Text = "Редактировать";
            this.editMaterialBtn.UseVisualStyleBackColor = true;
            this.editMaterialBtn.Click += new System.EventHandler(this.MaterialBtn_Click);
            // 
            // updateMaterialBtn
            // 
            this.updateMaterialBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateMaterialBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateMaterialBtn.Location = new System.Drawing.Point(263, 3);
            this.updateMaterialBtn.Name = "updateMaterialBtn";
            this.updateMaterialBtn.Size = new System.Drawing.Size(137, 49);
            this.updateMaterialBtn.TabIndex = 0;
            this.updateMaterialBtn.Text = "Обновить";
            this.updateMaterialBtn.UseVisualStyleBackColor = true;
            this.updateMaterialBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // deleteMaterialBtn
            // 
            this.deleteMaterialBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteMaterialBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteMaterialBtn.Location = new System.Drawing.Point(406, 3);
            this.deleteMaterialBtn.Name = "deleteMaterialBtn";
            this.deleteMaterialBtn.Size = new System.Drawing.Size(137, 49);
            this.deleteMaterialBtn.TabIndex = 0;
            this.deleteMaterialBtn.Text = "Удалить";
            this.deleteMaterialBtn.UseVisualStyleBackColor = true;
            this.deleteMaterialBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel7);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1240, 810);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Менеджеры";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.managersDataGridView, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel8, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.125F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.875F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(1240, 810);
            this.tableLayoutPanel7.TabIndex = 4;
            // 
            // managersDataGridView
            // 
            this.managersDataGridView.AllowUserToAddRows = false;
            this.managersDataGridView.AllowUserToDeleteRows = false;
            this.managersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.managersDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.managersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.managersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.Column7,
            this.Column8});
            this.managersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.managersDataGridView.Location = new System.Drawing.Point(3, 68);
            this.managersDataGridView.Name = "managersDataGridView";
            this.managersDataGridView.ReadOnly = true;
            this.managersDataGridView.RowTemplate.Height = 25;
            this.managersDataGridView.Size = new System.Drawing.Size(1234, 739);
            this.managersDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "№";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Отчество";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Должность";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 4;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.Controls.Add(this.createManagerBtn, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.editManagerBtn, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.updateManagerBtn, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.deleteManagerBtn, 3, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(557, 59);
            this.tableLayoutPanel8.TabIndex = 2;
            // 
            // createManagerBtn
            // 
            this.createManagerBtn.BackColor = System.Drawing.Color.Transparent;
            this.createManagerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createManagerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createManagerBtn.Location = new System.Drawing.Point(3, 3);
            this.createManagerBtn.Name = "createManagerBtn";
            this.createManagerBtn.Size = new System.Drawing.Size(111, 49);
            this.createManagerBtn.TabIndex = 0;
            this.createManagerBtn.Text = "Создать";
            this.createManagerBtn.UseVisualStyleBackColor = false;
            this.createManagerBtn.Click += new System.EventHandler(this.ManagerBtn_Click);
            // 
            // editManagerBtn
            // 
            this.editManagerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editManagerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editManagerBtn.Location = new System.Drawing.Point(120, 3);
            this.editManagerBtn.Name = "editManagerBtn";
            this.editManagerBtn.Size = new System.Drawing.Size(137, 49);
            this.editManagerBtn.TabIndex = 0;
            this.editManagerBtn.Text = "Редактировать";
            this.editManagerBtn.UseVisualStyleBackColor = true;
            this.editManagerBtn.Click += new System.EventHandler(this.ManagerBtn_Click);
            // 
            // updateManagerBtn
            // 
            this.updateManagerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateManagerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateManagerBtn.Location = new System.Drawing.Point(263, 3);
            this.updateManagerBtn.Name = "updateManagerBtn";
            this.updateManagerBtn.Size = new System.Drawing.Size(137, 49);
            this.updateManagerBtn.TabIndex = 0;
            this.updateManagerBtn.Text = "Обновить";
            this.updateManagerBtn.UseVisualStyleBackColor = true;
            this.updateManagerBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // deleteManagerBtn
            // 
            this.deleteManagerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteManagerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteManagerBtn.Location = new System.Drawing.Point(406, 3);
            this.deleteManagerBtn.Name = "deleteManagerBtn";
            this.deleteManagerBtn.Size = new System.Drawing.Size(137, 49);
            this.deleteManagerBtn.TabIndex = 0;
            this.deleteManagerBtn.Text = "Удалить";
            this.deleteManagerBtn.UseVisualStyleBackColor = true;
            this.deleteManagerBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 838);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ведение заказов для типографии";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.materialDataGridView)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.managersDataGridView)).EndInit();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView orderDataGridView;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private TableLayoutPanel tableLayoutPanel2;
        private Button createOrderBtn;
        private Button editOrderBtn;
        private Button updateOrderBtn;
        private Button deleteOrderBtn;
        private TabPage tabPage2;
        private TableLayoutPanel tableLayoutPanel3;
        private DataGridView materialDataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private TableLayoutPanel tableLayoutPanel4;
        private Button createMaterialBtn;
        private Button editMaterialBtn;
        private Button updateMaterialBtn;
        private Button deleteMaterialBtn;
        private TabPage tabPage3;
        private TableLayoutPanel tableLayoutPanel7;
        private DataGridView managersDataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private TableLayoutPanel tableLayoutPanel8;
        private Button createManagerBtn;
        private Button editManagerBtn;
        private Button updateManagerBtn;
        private Button deleteManagerBtn;
    }
}