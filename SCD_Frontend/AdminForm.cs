using SCD_Frontend.models;
using SCD_Frontend.services;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace SCD_Frontend
{
    public partial class AdminForm : Form
    {
        private string JWT;
        private string ALL_DEPARTMENTS_ENDPOINT = "http://localhost:8080/api/v1/department/allParentDepartments";
        private string DEPARTMENT_BY_NAME_ENDPOINT = "http://localhost:8080/api/v1/department/byName";
        private string CREATE_DEPARTMENT_ENDPOINT = "http://localhost:8080/api/v1/department";
        private string DELETE_DEPARTMENT_ENDPOINT = "http://localhost:8080/api/v1/department";
        private string currentSelectedItemId;


        List<DepartmentVO> allHeadDepartmentsWithChildren;
        public AdminForm(string jwt)
        {
            InitializeComponent();
            JWT = jwt;
            loadDepartmentData();
        }

        private void loadDepartmentData()
        {
            DepartmentService departmentService = new DepartmentService();
             allHeadDepartmentsWithChildren = departmentService.GetAllDepartments(ALL_DEPARTMENTS_ENDPOINT, JWT);
            BuildTreeView(allHeadDepartmentsWithChildren);
        }

        private void BuildTreeView(List<DepartmentVO> allHeadDepartmentsWithChildren)
        {
            department_treeView.Nodes.Clear();
            foreach (DepartmentVO department in allHeadDepartmentsWithChildren)
            {
                TreeNode parent = department_treeView.Nodes.Add(department.id.ToString(), department.name.ToString());
                foreach (Department childDepartment in department.childDepartments)
                {
                    parent.Nodes.Add(childDepartment.id.ToString(), childDepartment.name.ToString());   

                }
            }

            department_treeView.ExpandAll();
        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if(name_textBox.Text.Length < 1 || description_textBox.Text.Length < 1)
            {
                MessageBox.Show("Name and description cannot be empty!");
                return;
            }
            long parentId = 0;
            DepartmentService departmentService = new DepartmentService();
            string newDepartmentName = name_textBox.Text;
            // Verificam daca numele departamentului e deja folosit sau nu
            Department department = departmentService.findByName(DEPARTMENT_BY_NAME_ENDPOINT, newDepartmentName, JWT);
            if (department != null)
            {
                MessageBox.Show("Department name already exists! Choose another name!");
                return;
            }


            // Daca numele e disponibil, creem departamentul
            Department newDepartment = new Department();
            newDepartment.name = name_textBox.Text; 
            newDepartment.description = description_textBox.Text;   
            if (parent_textBox.Text.Length > 0)
            {
                Department parentDepartment = departmentService.findByName(DEPARTMENT_BY_NAME_ENDPOINT, parent_textBox.Text.ToString(), JWT);
                parentId = parentDepartment.id;
            }

            departmentService.createNewDepartment(CREATE_DEPARTMENT_ENDPOINT, newDepartment, parentId, JWT);
            loadDepartmentData();
        }

        private void department_treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            currentSelectedItemId = e.Node.Name;
            
            DepartmentService departmentService = new DepartmentService();
            Department department = departmentService.findByName(DEPARTMENT_BY_NAME_ENDPOINT,e.Node.Text, JWT);

            name_textBox.Text = department.name;
            description_textBox.Text = department.description;
            if (department.parentDepartment == null)
            {
                parent_textBox.Text = "";
            }
            else
            {
                parent_textBox.Text = department.parentDepartment.name;
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            Boolean isAnyDepartmentSelected = currentSelectedItemId != null;

            if (isAnyDepartmentSelected)
            {
                deleteSelectedDepartment();
            } else
            {
                MessageBox.Show("No department selected for deletion!");
            }
        }

        private void deleteSelectedDepartment()
        {
            DepartmentService departmentService = new DepartmentService();
            long departmentId = long.Parse(currentSelectedItemId);
            departmentService.deleteDepartment(DELETE_DEPARTMENT_ENDPOINT, departmentId, JWT);
            loadDepartmentData();
            parent_textBox.Text = "";
            name_textBox.Text = "";
            description_textBox.Text = "";
        }

        private void modify_button_Click(object sender, EventArgs e)
        {
           
            Boolean isAnyDepartmentSelected = currentSelectedItemId != null;

            if (isAnyDepartmentSelected)
            {
                editSelectedDepartment();
            }
            else
            {
                MessageBox.Show("No department selected for update!");
            }
        }

        private void editSelectedDepartment()
        {
            // @PutMapping("/{id}")
            // public ResponseEntity<Department> updateDepartment(@PathVariable Long id, @RequestBody DepartmentDTO departmentDTO)
            //
            
            DepartmentService departmentService = new DepartmentService();
            
            Department parentDepartment = departmentService.findByName(DEPARTMENT_BY_NAME_ENDPOINT, parent_textBox.Text, JWT);
            long departmentId = long.Parse(currentSelectedItemId);
            DepartmentDTO departmentDTO = new DepartmentDTO();
            departmentDTO.name = name_textBox.Text;
            departmentDTO.description = description_textBox.Text;
            if (parentDepartment != null)
            {
                departmentDTO.parentDepartmentId = parentDepartment.id;
            } else
            {
                departmentDTO.parentDepartmentId = 0;
            }
           
            departmentService.editDepartment(DELETE_DEPARTMENT_ENDPOINT, departmentDTO, departmentId, JWT);
            loadDepartmentData();
        }
    }
}
