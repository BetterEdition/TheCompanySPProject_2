using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheCompanySPProject.Model;
namespace TheCompanySPProject
{
    public partial class Dashboard : Form
    {
        DataAccess db = new DataAccess();
        List<Department> departs = new List<Department>();
        public Dashboard()
        {
            InitializeComponent();
            displayData();
        }
       

       
        public void displayData()
        {
            DepartmentEmployeesList.DataSource = departs;
            DepartmentEmployeesList.DisplayMember = "DepartmentEmployeeCount";

        }
        
        private void getDataBtn_Click(object sender, EventArgs e)
        {
            
            departs = db.getDepartment(DepartmentText.Text);

            displayData();
        }
        

       
        private void getAllDepBtn_Click(object sender, EventArgs e)
        {

            departs = db.getAllDepartments();

            displayData();
        }

        

        private void DepartmentText_TextChanged(object sender, EventArgs e)
        {

        }

        private void editTextBox_TextChanged(object sender, EventArgs e)
        {

        }

     

        private void EditDepBtn_Click(object sender, EventArgs e)
        {
            db.updateDepartment(editTextBox.Text, int.Parse(DepartmentText.Text));
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            db.createDepartment(editTextBox.Text, int.Parse(managertextbox.Text));
        }

        private void deleteSelectedBtn_Click(object sender, EventArgs e)
        {
            int index = DepartmentEmployeesList.SelectedIndex;
            db.deleteDepartment(departs[index].DNumber);
        }
    }
}
