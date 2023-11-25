using SCD_Frontend.models;
using SCD_Frontend.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SCD_Frontend
{
    public partial class AdminForm : Form
    {
        private string JWT;
        private string ALL_DEPARTMENTS_ENDPOINT = "http://localhost:8080/api/v1/department/all";
        private string ALL_PARENT_DEPARTMENTS_ENDPOINT = "http://localhost:8080/api/v1/department/allParentDepartments";
        private string DEPARTMENT_BY_NAME_ENDPOINT = "http://localhost:8080/api/v1/department/byName";
        private string CREATE_DEPARTMENT_ENDPOINT = "http://localhost:8080/api/v1/department";
        private string DELETE_DEPARTMENT_ENDPOINT = "http://localhost:8080/api/v1/department";
        private string MANAGERS_BY_DEPARTMENT_ENDPOINT = "http://localhost:8080/api/v1/employee/byDepartament/managers";
        private string CREATE_EMPLOYEE_ENDPOINT = "http://localhost:8080/api/v1/employee";

        private string currentSelectedItemId;
        private string currentSelectedEmployeeId;

        List<Department> departments;
        List<Employee> employeesOfDepartment;
        List<DepartmentVO> allHeadDepartmentsWithChildren;
        public AdminForm(string jwt)
        {
            InitializeComponent();
            JWT = jwt;
            loadDepartmentData();
            loadDepartmentCategoriesInEmployeeSection();
        }


        private void loadDepartmentData()
        {
            DepartmentService departmentService = new DepartmentService();
             allHeadDepartmentsWithChildren = departmentService.GetAllParentDepartments(ALL_PARENT_DEPARTMENTS_ENDPOINT, JWT);
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

        private void loadDepartmentCategoriesInEmployeeSection()
        {
            DepartmentService departmentService = new DepartmentService();
            departments = departmentService.GetAllDepartments(ALL_DEPARTMENTS_ENDPOINT, JWT);
            List<string> departmentNames = departments.Select(d => d.name).ToList();
            department_comboBox.Items.Clear();
            department_comboBox.Items.AddRange(departmentNames.ToArray());
        }


        private void department_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string departmentName = department_comboBox.SelectedItem.ToString();
            department_textBox.Text = departmentName;
            Department selectedDepartment = departments.FirstOrDefault(d => d.name == departmentName);
            List<Employee> employees = selectedDepartment.employees;
            employeesOfDepartment = selectedDepartment.employees;

            List<Employee> managers = employees.Where(emp => emp.manager == null).ToList();
             employees = employees.Where(emp => emp.manager != null).ToList();

            buildTreeViewForEmployees(managers, employees);

        }

        private void buildTreeViewForEmployees(List<Employee> managers, List<Employee> employees)
        {
            employee_treeView.Nodes.Clear();

            foreach (Employee manager in managers)
            {
                TreeNode parent = employee_treeView.Nodes.Add(manager.id.ToString(), manager.name.ToString());
                
                foreach (Employee employee in employees)
                {
                    if (employee.manager.id == manager.id) {
                        parent.Nodes.Add(employee.id.ToString(), employee.name.ToString());
                    }
                }
            }

            employee_treeView.ExpandAll();
        }


        private void employee_treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            currentSelectedEmployeeId = e.Node.Name;

            String employeeName = e.Node.Text.ToString();
            Employee employee = employeesOfDepartment.Where(emp => emp.name.Equals(employeeName)).First();

            if (employee.manager == null)
            {
                manager_textBox.Text = "";
            }
            else
            {
                manager_textBox.Text = employee.manager.name;
            }

            employee_textBox.Text = employeeName;
            email_textBox.Text = employee.email;
        }

        private void add_employeee_button_Click(object sender, EventArgs e)
        {
            EmployeeService employeeService = new EmployeeService();
            long managerId = 0;
            long departmentId = 0;
            string email = "";
            string employeeName = "";


            if (email_textBox.Text.Length < 1 || employee_textBox.Text.Length < 1 || department_textBox.Text.Length < 1)
            {
                MessageBox.Show("Email, Name and Department are required!");
                return;
            }
           
                email = email_textBox.Text.ToString();
                   
                employeeName = employee_textBox.Text.ToString();
                    
                bool departmentExists = departments.Where(dep => dep.name.Equals(department_textBox.Text.ToString())).Any();
            if (!departmentExists)
            {
                MessageBox.Show("Department doesn't exist!");
                return;
            }
                    Department department = departments.Where(dep => dep.name.Equals(department_textBox.Text.ToString())).First();
                    departmentId = department.id;

            if (manager_textBox.Text.Length < 1)
            {
                managerId = 0;
            } else
            {
                List<Employee> managers
                    = employeeService.GetManagersByDepartment(department_textBox.Text.ToString(), MANAGERS_BY_DEPARTMENT_ENDPOINT, JWT);
                managerId = managers.Where(man => man.name.Equals(manager_textBox.Text.ToString())).First().id;
            }
            EmployeeRequest request = new EmployeeRequest();
            request.name = employeeName;
            request.email = email;
            request.departmentId = departmentId;
            request.managerId = managerId;

            employeeService.createEmployee(request, CREATE_EMPLOYEE_ENDPOINT, JWT);

            // now update the treeView
            loadDepartmentCategoriesInEmployeeSection();
            refreshEmployeeTree();
        }

        private void refreshEmployeeTree()
        {
            Department selectedDepartment = departments.FirstOrDefault(d => d.name == department_textBox.Text.ToString());
            List<Employee> employees = selectedDepartment.employees;
            employeesOfDepartment = selectedDepartment.employees;

            List<Employee> managerList = employees.Where(emp => emp.manager == null).ToList();
            employees = employees.Where(emp => emp.manager != null).ToList();

            buildTreeViewForEmployees(managerList, employees);
        }

        private void delete_employee_button_Click(object sender, EventArgs e)
        {
            // daca elementul selectat este manager atunci afisam mesaj de eroare ca nu poate fi sters, ci doar schimbat
            Employee employee = employeesOfDepartment.Where(em => em.id == long.Parse(currentSelectedEmployeeId)).FirstOrDefault(); 
            if (employee.manager == null) {
                MessageBox.Show("Managers cannot be deleted!");
                return; 
            }

            // sterge employee
            Console.WriteLine(currentSelectedEmployeeId);
            EmployeeService employeeService = new EmployeeService();    
            employeeService.deleteEmployee(currentSelectedEmployeeId, CREATE_EMPLOYEE_ENDPOINT, JWT);

            loadDepartmentCategoriesInEmployeeSection();
            refreshEmployeeTree();
            department_textBox.Text = "";
            manager_textBox.Text = "";
            employee_textBox.Text = "";
            email_textBox.Text = "";
        }

        private void edit_employee_button_Click(object sender, EventArgs e)
        {
            bool isAnyEmployeeSelected = currentSelectedEmployeeId != null;

            if (isAnyEmployeeSelected)
            {
                editSelectedEmployee();
            }
            else
            {
                MessageBox.Show("No Employee selected for update!");
            }
        }

        private void editSelectedEmployee()
        {
            EmployeeService employeeService = new EmployeeService();
            long managerId = 0;
            long departmentId = 0;
            string email = "";
            string employeeName = "";


            if (email_textBox.Text.Length < 1 || employee_textBox.Text.Length < 1 || department_textBox.Text.Length < 1)
            {
                MessageBox.Show("Email, Name and Department are required!");
                return;
            }

            email = email_textBox.Text.ToString();
            employeeName = employee_textBox.Text.ToString();


            bool departmentExists = departments.Where(dep => dep.name.Equals(department_textBox.Text.ToString())).Any();
            if (!departmentExists)
            {
                MessageBox.Show("Department doesn't exist!");
                return;
            }
                
            Department department = departments.Where(dep => dep.name.Equals(department_textBox.Text.ToString())).First();
            departmentId = department.id;

            if (manager_textBox.Text.Length < 1)
            {
                managerId = 0;
            }
            else
            {
                List<Employee> managers = employeeService.GetManagersByDepartment(department_textBox.Text.ToString(), MANAGERS_BY_DEPARTMENT_ENDPOINT, JWT);
                managerId = managers.Where(man => man.name.Equals(manager_textBox.Text.ToString())).First().id;
            }

            EmployeeRequest request = new EmployeeRequest();
            request.name = employeeName;
            request.email = email;
            request.departmentId = departmentId;
            request.managerId = managerId;

            employeeService.updateEmployee(request, currentSelectedEmployeeId, CREATE_EMPLOYEE_ENDPOINT, JWT);

            // now update the treeView
            loadDepartmentCategoriesInEmployeeSection();
            refreshEmployeeTree();
        }

    }
}
