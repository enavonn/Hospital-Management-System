
namespace Hospital_Management_System
{
    partial class Medicines
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medicines));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnPatients = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnDiagnosis = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnMedicines = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnLogout = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnDoctors = new Guna.UI.WinForms.GunaAdvenceButton();
            this.DGVMedicine = new Guna.UI.WinForms.GunaDataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnReload = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnDelete = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnUpdate = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnAdd = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txtByDoctor = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtMedicineType = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtMedicineName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtMedicineId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMedicine)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(150, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(786, 64);
            this.panel2.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(765, 2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(17, 19);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 5;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hospital Management System";
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnPatients);
            this.panel1.Controls.Add(this.btnDiagnosis);
            this.panel1.Controls.Add(this.btnMedicines);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnDoctors);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 605);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(11, 3);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // btnPatients
            // 
            this.btnPatients.AnimationHoverSpeed = 0.07F;
            this.btnPatients.AnimationSpeed = 0.03F;
            this.btnPatients.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPatients.BaseColor = System.Drawing.Color.Purple;
            this.btnPatients.BorderColor = System.Drawing.Color.Black;
            this.btnPatients.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnPatients.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnPatients.CheckedForeColor = System.Drawing.Color.White;
            this.btnPatients.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnPatients.CheckedImage")));
            this.btnPatients.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnPatients.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPatients.FocusedColor = System.Drawing.Color.Empty;
            this.btnPatients.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatients.ForeColor = System.Drawing.Color.White;
            this.btnPatients.Image = ((System.Drawing.Image)(resources.GetObject("btnPatients.Image")));
            this.btnPatients.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPatients.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnPatients.Location = new System.Drawing.Point(8, 128);
            this.btnPatients.Margin = new System.Windows.Forms.Padding(2);
            this.btnPatients.Name = "btnPatients";
            this.btnPatients.OnHoverBaseColor = System.Drawing.Color.Purple;
            this.btnPatients.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPatients.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPatients.OnHoverImage = null;
            this.btnPatients.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnPatients.OnPressedColor = System.Drawing.Color.Black;
            this.btnPatients.Size = new System.Drawing.Size(140, 29);
            this.btnPatients.TabIndex = 6;
            this.btnPatients.Text = "Patients";
            this.btnPatients.Click += new System.EventHandler(this.btnPatients_Click);
            // 
            // btnDiagnosis
            // 
            this.btnDiagnosis.AnimationHoverSpeed = 0.07F;
            this.btnDiagnosis.AnimationSpeed = 0.03F;
            this.btnDiagnosis.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDiagnosis.BaseColor = System.Drawing.Color.Purple;
            this.btnDiagnosis.BorderColor = System.Drawing.Color.Black;
            this.btnDiagnosis.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnDiagnosis.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnDiagnosis.CheckedForeColor = System.Drawing.Color.White;
            this.btnDiagnosis.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnDiagnosis.CheckedImage")));
            this.btnDiagnosis.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnDiagnosis.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDiagnosis.FocusedColor = System.Drawing.Color.Empty;
            this.btnDiagnosis.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiagnosis.ForeColor = System.Drawing.Color.White;
            this.btnDiagnosis.Image = ((System.Drawing.Image)(resources.GetObject("btnDiagnosis.Image")));
            this.btnDiagnosis.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDiagnosis.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDiagnosis.Location = new System.Drawing.Point(8, 161);
            this.btnDiagnosis.Margin = new System.Windows.Forms.Padding(2);
            this.btnDiagnosis.Name = "btnDiagnosis";
            this.btnDiagnosis.OnHoverBaseColor = System.Drawing.Color.Purple;
            this.btnDiagnosis.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDiagnosis.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDiagnosis.OnHoverImage = null;
            this.btnDiagnosis.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDiagnosis.OnPressedColor = System.Drawing.Color.Black;
            this.btnDiagnosis.Size = new System.Drawing.Size(140, 29);
            this.btnDiagnosis.TabIndex = 5;
            this.btnDiagnosis.Text = "Diagnosis";
            this.btnDiagnosis.Click += new System.EventHandler(this.btnDiagnosis_Click);
            // 
            // btnMedicines
            // 
            this.btnMedicines.AnimationHoverSpeed = 0.07F;
            this.btnMedicines.AnimationSpeed = 0.03F;
            this.btnMedicines.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnMedicines.BaseColor = System.Drawing.Color.Purple;
            this.btnMedicines.BorderColor = System.Drawing.Color.Black;
            this.btnMedicines.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnMedicines.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnMedicines.CheckedForeColor = System.Drawing.Color.White;
            this.btnMedicines.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnMedicines.CheckedImage")));
            this.btnMedicines.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnMedicines.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMedicines.FocusedColor = System.Drawing.Color.Empty;
            this.btnMedicines.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicines.ForeColor = System.Drawing.Color.White;
            this.btnMedicines.Image = ((System.Drawing.Image)(resources.GetObject("btnMedicines.Image")));
            this.btnMedicines.ImageSize = new System.Drawing.Size(20, 20);
            this.btnMedicines.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnMedicines.Location = new System.Drawing.Point(9, 194);
            this.btnMedicines.Margin = new System.Windows.Forms.Padding(2);
            this.btnMedicines.Name = "btnMedicines";
            this.btnMedicines.OnHoverBaseColor = System.Drawing.Color.Purple;
            this.btnMedicines.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMedicines.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMedicines.OnHoverImage = null;
            this.btnMedicines.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnMedicines.OnPressedColor = System.Drawing.Color.Black;
            this.btnMedicines.Size = new System.Drawing.Size(139, 29);
            this.btnMedicines.TabIndex = 4;
            this.btnMedicines.Text = "Medicines";
            // 
            // btnLogout
            // 
            this.btnLogout.AnimationHoverSpeed = 0.07F;
            this.btnLogout.AnimationSpeed = 0.03F;
            this.btnLogout.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLogout.BaseColor = System.Drawing.Color.Purple;
            this.btnLogout.BorderColor = System.Drawing.Color.Black;
            this.btnLogout.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnLogout.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnLogout.CheckedForeColor = System.Drawing.Color.White;
            this.btnLogout.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.CheckedImage")));
            this.btnLogout.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogout.FocusedColor = System.Drawing.Color.Empty;
            this.btnLogout.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLogout.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnLogout.Location = new System.Drawing.Point(9, 564);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.OnHoverBaseColor = System.Drawing.Color.Purple;
            this.btnLogout.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLogout.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLogout.OnHoverImage = null;
            this.btnLogout.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnLogout.OnPressedColor = System.Drawing.Color.Black;
            this.btnLogout.Size = new System.Drawing.Size(139, 29);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnDoctors
            // 
            this.btnDoctors.AnimationHoverSpeed = 0.07F;
            this.btnDoctors.AnimationSpeed = 0.03F;
            this.btnDoctors.BackColor = System.Drawing.Color.Purple;
            this.btnDoctors.BaseColor = System.Drawing.Color.Purple;
            this.btnDoctors.BorderColor = System.Drawing.Color.Black;
            this.btnDoctors.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnDoctors.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnDoctors.CheckedForeColor = System.Drawing.Color.White;
            this.btnDoctors.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnDoctors.CheckedImage")));
            this.btnDoctors.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnDoctors.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDoctors.FocusedColor = System.Drawing.Color.Empty;
            this.btnDoctors.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctors.ForeColor = System.Drawing.Color.White;
            this.btnDoctors.Image = ((System.Drawing.Image)(resources.GetObject("btnDoctors.Image")));
            this.btnDoctors.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDoctors.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDoctors.Location = new System.Drawing.Point(8, 96);
            this.btnDoctors.Margin = new System.Windows.Forms.Padding(2);
            this.btnDoctors.Name = "btnDoctors";
            this.btnDoctors.OnHoverBaseColor = System.Drawing.Color.Purple;
            this.btnDoctors.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDoctors.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDoctors.OnHoverImage = null;
            this.btnDoctors.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDoctors.OnPressedColor = System.Drawing.Color.Black;
            this.btnDoctors.Size = new System.Drawing.Size(140, 29);
            this.btnDoctors.TabIndex = 2;
            this.btnDoctors.Text = "Doctors";
            this.btnDoctors.Click += new System.EventHandler(this.btnDoctors_Click);
            // 
            // DGVMedicine
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DGVMedicine.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVMedicine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVMedicine.BackgroundColor = System.Drawing.Color.White;
            this.DGVMedicine.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVMedicine.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVMedicine.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVMedicine.ColumnHeadersHeight = 30;
            this.DGVMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVMedicine.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVMedicine.EnableHeadersVisualStyles = false;
            this.DGVMedicine.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVMedicine.Location = new System.Drawing.Point(169, 267);
            this.DGVMedicine.Name = "DGVMedicine";
            this.DGVMedicine.RowHeadersVisible = false;
            this.DGVMedicine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVMedicine.Size = new System.Drawing.Size(755, 326);
            this.DGVMedicine.TabIndex = 11;
            this.DGVMedicine.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DGVMedicine.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVMedicine.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVMedicine.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVMedicine.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVMedicine.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVMedicine.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVMedicine.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVMedicine.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DGVMedicine.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVMedicine.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVMedicine.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVMedicine.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVMedicine.ThemeStyle.HeaderStyle.Height = 30;
            this.DGVMedicine.ThemeStyle.ReadOnly = false;
            this.DGVMedicine.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVMedicine.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVMedicine.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVMedicine.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVMedicine.ThemeStyle.RowsStyle.Height = 22;
            this.DGVMedicine.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVMedicine.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVMedicine.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVMedicine_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(507, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Medicine List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Medicine Details";
            // 
            // panel3
            // 
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnReload);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Controls.Add(this.txtByDoctor);
            this.panel3.Controls.Add(this.txtMedicineType);
            this.panel3.Controls.Add(this.txtMedicineName);
            this.panel3.Controls.Add(this.txtMedicineId);
            this.panel3.Location = new System.Drawing.Point(169, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(755, 159);
            this.panel3.TabIndex = 9;
            // 
            // btnReload
            // 
            this.btnReload.AnimationHoverSpeed = 0.07F;
            this.btnReload.AnimationSpeed = 0.03F;
            this.btnReload.BackColor = System.Drawing.Color.Transparent;
            this.btnReload.BaseColor = System.Drawing.Color.Purple;
            this.btnReload.BorderColor = System.Drawing.Color.Black;
            this.btnReload.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnReload.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnReload.CheckedForeColor = System.Drawing.Color.White;
            this.btnReload.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnReload.CheckedImage")));
            this.btnReload.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnReload.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReload.FocusedColor = System.Drawing.Color.Empty;
            this.btnReload.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.ForeColor = System.Drawing.Color.White;
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.ImageSize = new System.Drawing.Size(20, 20);
            this.btnReload.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnReload.Location = new System.Drawing.Point(506, 89);
            this.btnReload.Margin = new System.Windows.Forms.Padding(2);
            this.btnReload.Name = "btnReload";
            this.btnReload.OnHoverBaseColor = System.Drawing.Color.Purple;
            this.btnReload.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnReload.OnHoverForeColor = System.Drawing.Color.White;
            this.btnReload.OnHoverImage = null;
            this.btnReload.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnReload.OnPressedColor = System.Drawing.Color.Black;
            this.btnReload.Radius = 15;
            this.btnReload.Size = new System.Drawing.Size(104, 38);
            this.btnReload.TabIndex = 7;
            this.btnReload.Text = "Reload";
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AnimationHoverSpeed = 0.07F;
            this.btnDelete.AnimationSpeed = 0.03F;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BaseColor = System.Drawing.Color.Purple;
            this.btnDelete.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnDelete.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnDelete.CheckedForeColor = System.Drawing.Color.White;
            this.btnDelete.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.CheckedImage")));
            this.btnDelete.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDelete.FocusedColor = System.Drawing.Color.Empty;
            this.btnDelete.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDelete.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDelete.Location = new System.Drawing.Point(383, 89);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OnHoverBaseColor = System.Drawing.Color.Purple;
            this.btnDelete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDelete.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDelete.OnHoverImage = null;
            this.btnDelete.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDelete.OnPressedColor = System.Drawing.Color.Black;
            this.btnDelete.Radius = 15;
            this.btnDelete.Size = new System.Drawing.Size(104, 38);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AnimationHoverSpeed = 0.07F;
            this.btnUpdate.AnimationSpeed = 0.03F;
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BaseColor = System.Drawing.Color.Purple;
            this.btnUpdate.BorderColor = System.Drawing.Color.Black;
            this.btnUpdate.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnUpdate.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnUpdate.CheckedForeColor = System.Drawing.Color.White;
            this.btnUpdate.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.CheckedImage")));
            this.btnUpdate.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdate.FocusedColor = System.Drawing.Color.Empty;
            this.btnUpdate.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUpdate.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnUpdate.Location = new System.Drawing.Point(257, 89);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.OnHoverBaseColor = System.Drawing.Color.Purple;
            this.btnUpdate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUpdate.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUpdate.OnHoverImage = null;
            this.btnUpdate.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnUpdate.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpdate.Radius = 15;
            this.btnUpdate.Size = new System.Drawing.Size(104, 38);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AnimationHoverSpeed = 0.07F;
            this.btnAdd.AnimationSpeed = 0.03F;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BaseColor = System.Drawing.Color.Purple;
            this.btnAdd.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnAdd.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAdd.CheckedForeColor = System.Drawing.Color.White;
            this.btnAdd.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.CheckedImage")));
            this.btnAdd.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdd.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAdd.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAdd.Location = new System.Drawing.Point(135, 89);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.Purple;
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Radius = 15;
            this.btnAdd.Size = new System.Drawing.Size(104, 38);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtByDoctor
            // 
            this.txtByDoctor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtByDoctor.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtByDoctor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtByDoctor.HintForeColor = System.Drawing.Color.Empty;
            this.txtByDoctor.HintText = "By Doctor";
            this.txtByDoctor.isPassword = false;
            this.txtByDoctor.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtByDoctor.LineIdleColor = System.Drawing.Color.Gray;
            this.txtByDoctor.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtByDoctor.LineThickness = 4;
            this.txtByDoctor.Location = new System.Drawing.Point(555, 17);
            this.txtByDoctor.Margin = new System.Windows.Forms.Padding(4);
            this.txtByDoctor.Name = "txtByDoctor";
            this.txtByDoctor.Size = new System.Drawing.Size(192, 42);
            this.txtByDoctor.TabIndex = 5;
            this.txtByDoctor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtMedicineType
            // 
            this.txtMedicineType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMedicineType.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedicineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMedicineType.HintForeColor = System.Drawing.Color.Empty;
            this.txtMedicineType.HintText = "Medicine Type";
            this.txtMedicineType.isPassword = false;
            this.txtMedicineType.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtMedicineType.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMedicineType.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtMedicineType.LineThickness = 4;
            this.txtMedicineType.Location = new System.Drawing.Point(344, 17);
            this.txtMedicineType.Margin = new System.Windows.Forms.Padding(4);
            this.txtMedicineType.Name = "txtMedicineType";
            this.txtMedicineType.Size = new System.Drawing.Size(203, 42);
            this.txtMedicineType.TabIndex = 4;
            this.txtMedicineType.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtMedicineName
            // 
            this.txtMedicineName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMedicineName.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedicineName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMedicineName.HintForeColor = System.Drawing.Color.Empty;
            this.txtMedicineName.HintText = "Medicine Name";
            this.txtMedicineName.isPassword = false;
            this.txtMedicineName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtMedicineName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMedicineName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtMedicineName.LineThickness = 4;
            this.txtMedicineName.Location = new System.Drawing.Point(157, 17);
            this.txtMedicineName.Margin = new System.Windows.Forms.Padding(4);
            this.txtMedicineName.Name = "txtMedicineName";
            this.txtMedicineName.Size = new System.Drawing.Size(179, 42);
            this.txtMedicineName.TabIndex = 3;
            this.txtMedicineName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtMedicineId
            // 
            this.txtMedicineId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMedicineId.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedicineId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMedicineId.HintForeColor = System.Drawing.Color.Empty;
            this.txtMedicineId.HintText = "Medicine Id";
            this.txtMedicineId.isPassword = false;
            this.txtMedicineId.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtMedicineId.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMedicineId.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtMedicineId.LineThickness = 4;
            this.txtMedicineId.Location = new System.Drawing.Point(4, 17);
            this.txtMedicineId.Margin = new System.Windows.Forms.Padding(4);
            this.txtMedicineId.Name = "txtMedicineId";
            this.txtMedicineId.Size = new System.Drawing.Size(145, 42);
            this.txtMedicineId.TabIndex = 2;
            this.txtMedicineId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Medicines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(936, 605);
            this.Controls.Add(this.DGVMedicine);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Medicines";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medicines";
            this.Load += new System.EventHandler(this.Medicines_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMedicine)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI.WinForms.GunaAdvenceButton btnPatients;
        private Guna.UI.WinForms.GunaAdvenceButton btnDiagnosis;
        private Guna.UI.WinForms.GunaAdvenceButton btnMedicines;
        private Guna.UI.WinForms.GunaAdvenceButton btnLogout;
        private Guna.UI.WinForms.GunaAdvenceButton btnDoctors;
        private Guna.UI.WinForms.GunaDataGridView DGVMedicine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI.WinForms.GunaAdvenceButton btnReload;
        private Guna.UI.WinForms.GunaAdvenceButton btnDelete;
        private Guna.UI.WinForms.GunaAdvenceButton btnUpdate;
        private Guna.UI.WinForms.GunaAdvenceButton btnAdd;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtByDoctor;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMedicineType;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMedicineName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMedicineId;
    }
}