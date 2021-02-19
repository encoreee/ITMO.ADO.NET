using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace ITMO.ADO.NET.CourseManager
{
    public partial class CourseViewer : Form
    {

        private SchoolEntities schoolContext;
        public CourseViewer()
        {
            InitializeComponent();
        }

        private void CourseViewer_Load(object sender, EventArgs e)
        {
            schoolContext = new SchoolEntities();
            //var departments = from d in schoolContext.Departments.Include("Courses")
            //                  orderby d.Name
            //                  select d;

            var departments = schoolContext.Departments.Include(x => x.Courses).OrderBy(x => x.Name);
            

            try
            {
                this.departmentList.DisplayMember = "Name";
                this.departmentList.DataSource = departments.ToList();
                dataGridView1.DataSource = schoolContext.Courses.Local.ToBindingList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void departmentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Department department = (Department)this.departmentList.SelectedItem;
                courseGridView.DataSource = department.Courses.ToList();
             
                courseGridView.Columns["Department"].Visible = false;
                courseGridView.Columns["StudentGrades"].Visible = false;
                courseGridView.Columns["OnlineCourse"].Visible = false;
                courseGridView.Columns["OnsiteCourse"].Visible = false;
                courseGridView.Columns["People"].Visible = false;
                courseGridView.Columns["DepartmentId"].Visible = false;
                courseGridView.AllowUserToDeleteRows = false;
                courseGridView.AllowUserToAddRows = true;

                courseGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                schoolContext.SaveChanges();
                MessageBox.Show("Changes saved to the database.");
                this.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CourseViewer_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            schoolContext.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int crsid = int.Parse(this.textBox1.Text);
            string title = this.textBox2.Text;
            int cred = int.Parse(this.textBox3.Text);

            Department department = (Department)this.departmentList.SelectedItem;

            Course course = new Course
            {
                CourseID = crsid,
                Title = title,
                Credits = cred,
                DepartmentID = department.DepartmentID
            };

            schoolContext.Courses.Add(course);
            schoolContext.SaveChanges();
            MessageBox.Show("Changes saved to the database.");
            this.Refresh();

            try
            {
                courseGridView.DataSource = department.Courses.ToList();
                courseGridView.Columns["Department"].Visible = false;
                courseGridView.Columns["StudentGrades"].Visible = false;
                courseGridView.Columns["OnlineCourse"].Visible = false;
                courseGridView.Columns["OnsiteCourse"].Visible = false;
                courseGridView.Columns["People"].Visible = false;
                courseGridView.Columns["DepartmentId"].Visible = false;
                courseGridView.AllowUserToDeleteRows = false;
                courseGridView.AllowUserToAddRows = true;

                courseGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void viewOffices_Click(object sender, EventArgs e)
        {
            OfficeAssignment officeForm = new OfficeAssignment();
            officeForm.Visible = true;
        }
    }
}
