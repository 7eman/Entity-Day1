using entity1.Models;
using System.Runtime.Intrinsics.Arm;

namespace entity1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            db = new ITIContext();
        }
        ITIContext db;
        private void Form1_Load(object sender, EventArgs e)
        {

            dgv_student.DataSource = db.Students.Select(n => new { n.St_Id, n.St_Fname, n.St_Lname, n.St_Age, n.St_Address, deptname = n.Dept.Dept_Name, supervisor = n.St_superNavigation.St_Fname }).ToList();
            cb_dept.DataSource = db.Departments.ToList();
            cb_dept.ValueMember = "Dept_Id";
            cb_dept.DisplayMember = "Dept_Name";

            cb_super.DataSource = db.Students.ToList();
            cb_super.ValueMember = "St_Id";
            cb_super.DisplayMember = "St_Fname";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Student s = new Student()
            {
                St_Fname = txt_fname.Text,
                St_Lname = txt_lname.Text,
                St_Age = int.Parse(txt_age.Text),
                St_Address = txt_address.Text,
                Dept_Id = (int)cb_dept.SelectedValue,
                St_super = (int)cb_super.SelectedValue,
            };
            db.Students.Add(s);
            db.SaveChanges();
            txt_address.Text = txt_age.Text = txt_fname.Text = txt_lname.Text = " ";
            dgv_student.DataSource = db.Students.Select(n => new { n.St_Id, n.St_Fname, n.St_Lname, n.St_Age, n.St_Address, deptname = n.Dept.Dept_Name, supervisor = n.St_superNavigation.St_Fname }).ToList();
            MessageBox.Show("Student added");
        }
        int id;
        private void dgv_student_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)dgv_student.SelectedRows[0].Cells[0].Value;
            Student s = db.Students.Where(n => n.St_Id == id).SingleOrDefault();
            txt_fname.Text = s.St_Fname;
            txt_lname.Text = s.St_Lname;
            txt_age.Text = s.St_Age.ToString();
            txt_address.Text = s.St_Address.ToString();
            cb_dept.SelectedValue = s.Dept.Dept_Id;
            cb_super.SelectedValue = s.St_super;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Student s = db.Students.Where(n => n.St_Id == id).SingleOrDefault();
            s.St_Fname = txt_fname.Text;
            s.St_Lname = txt_lname.Text;
            s.St_Age = int.Parse(txt_age.Text);
            s.St_Address = txt_address.Text;
            s.Dept_Id = (int)cb_dept.SelectedValue;
            s.St_super = (int)cb_super.SelectedValue;

            db.SaveChanges();
            txt_address.Text = txt_age.Text = txt_fname.Text = txt_lname.Text = " ";
            dgv_student.DataSource = db.Students.Select(n => new { n.St_Id, n.St_Fname, n.St_Lname, n.St_Age, n.St_Address, deptname = n.Dept.Dept_Name, supervisor = n.St_superNavigation.St_Fname }).ToList();
            MessageBox.Show("Student updated");

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Student s = db.Students.Where(n => n.St_Id == id).SingleOrDefault();
            if (s != null)
            {
                db.Students.Remove(s);
                db.SaveChanges();
                txt_address.Text = txt_age.Text = txt_fname.Text = txt_lname.Text = " ";
                dgv_student.DataSource = db.Students.Select(n => new { n.St_Id, n.St_Fname, n.St_Lname, n.St_Age, n.St_Address, deptname = n.Dept.Dept_Name, supervisor = n.St_superNavigation.St_Fname }).ToList();
                MessageBox.Show("Student deleted");
            } 
        }
    }
}
