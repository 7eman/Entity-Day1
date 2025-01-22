namespace entity1
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
            dgv_student = new DataGridView();
            btn_add = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            txt_fname = new TextBox();
            txt_address = new TextBox();
            txt_age = new TextBox();
            txt_lname = new TextBox();
            fname = new Label();
            lname = new Label();
            age = new Label();
            address = new Label();
            dept = new Label();
            super = new Label();
            cb_super = new ComboBox();
            cb_dept = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgv_student).BeginInit();
            SuspendLayout();
            // 
            // dgv_student
            // 
            dgv_student.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_student.Location = new Point(25, 240);
            dgv_student.Name = "dgv_student";
            dgv_student.Size = new Size(739, 189);
            dgv_student.TabIndex = 0;
            dgv_student.RowHeaderMouseDoubleClick += dgv_student_RowHeaderMouseDoubleClick;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(87, 65);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(75, 23);
            btn_add.TabIndex = 1;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(87, 132);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(75, 23);
            btn_update.TabIndex = 2;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(87, 186);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(75, 23);
            btn_delete.TabIndex = 3;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // txt_fname
            // 
            txt_fname.Location = new Point(654, 21);
            txt_fname.Name = "txt_fname";
            txt_fname.Size = new Size(100, 23);
            txt_fname.TabIndex = 4;
            // 
            // txt_address
            // 
            txt_address.Location = new Point(654, 158);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(100, 23);
            txt_address.TabIndex = 6;
            // 
            // txt_age
            // 
            txt_age.Location = new Point(654, 116);
            txt_age.Name = "txt_age";
            txt_age.Size = new Size(100, 23);
            txt_age.TabIndex = 7;
            // 
            // txt_lname
            // 
            txt_lname.Location = new Point(654, 65);
            txt_lname.Name = "txt_lname";
            txt_lname.Size = new Size(100, 23);
            txt_lname.TabIndex = 8;
            // 
            // fname
            // 
            fname.AutoSize = true;
            fname.Location = new Point(562, 24);
            fname.Name = "fname";
            fname.Size = new Size(43, 15);
            fname.TabIndex = 9;
            fname.Text = "Fname";
            // 
            // lname
            // 
            lname.AutoSize = true;
            lname.Location = new Point(562, 73);
            lname.Name = "lname";
            lname.Size = new Size(43, 15);
            lname.TabIndex = 10;
            lname.Text = "Lname";
            // 
            // age
            // 
            age.AutoSize = true;
            age.Location = new Point(562, 124);
            age.Name = "age";
            age.Size = new Size(28, 15);
            age.TabIndex = 11;
            age.Text = "Age";
            // 
            // address
            // 
            address.AutoSize = true;
            address.Location = new Point(562, 166);
            address.Name = "address";
            address.Size = new Size(49, 15);
            address.TabIndex = 12;
            address.Text = "Address";
            // 
            // dept
            // 
            dept.AutoSize = true;
            dept.Location = new Point(248, 116);
            dept.Name = "dept";
            dept.Size = new Size(32, 15);
            dept.TabIndex = 13;
            dept.Text = "Dept";
            // 
            // super
            // 
            super.AutoSize = true;
            super.Location = new Point(248, 52);
            super.Name = "super";
            super.Size = new Size(62, 15);
            super.TabIndex = 14;
            super.Text = "Supervisor";
            // 
            // cb_super
            // 
            cb_super.FormattingEnabled = true;
            cb_super.Location = new Point(343, 52);
            cb_super.Name = "cb_super";
            cb_super.Size = new Size(121, 23);
            cb_super.TabIndex = 15;
            // 
            // cb_dept
            // 
            cb_dept.FormattingEnabled = true;
            cb_dept.Location = new Point(343, 116);
            cb_dept.Name = "cb_dept";
            cb_dept.Size = new Size(121, 23);
            cb_dept.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cb_dept);
            Controls.Add(cb_super);
            Controls.Add(super);
            Controls.Add(dept);
            Controls.Add(address);
            Controls.Add(age);
            Controls.Add(lname);
            Controls.Add(fname);
            Controls.Add(txt_lname);
            Controls.Add(txt_age);
            Controls.Add(txt_address);
            Controls.Add(txt_fname);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(dgv_student);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_student).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_student;
        private Button btn_add;
        private Button btn_update;
        private Button btn_delete;
        private TextBox txt_fname;
        private TextBox txt_address;
        private TextBox txt_age;
        private TextBox txt_lname;
        private Label fname;
        private Label lname;
        private Label age;
        private Label address;
        private Label dept;
        private Label super;
        private ComboBox cb_super;
        private ComboBox cb_dept;
    }
}
