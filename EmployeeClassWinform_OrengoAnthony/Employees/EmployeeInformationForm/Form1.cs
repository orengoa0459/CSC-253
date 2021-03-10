using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeLibrary;
namespace EmployeeInformationForm
{
    public partial class displayList : Form
    {        
        public displayList()
        {
            InitializeComponent();            
        }
        #region Variables,Objects,Sentinels
        int age = 0;
        int index = 1;
        string phoneType = " ";        
        bool loop = false;
        List<Employee> employee = new List<Employee>();
        #endregion

        //Submit button actions
        private void submit_button_Click(object sender, EventArgs e)
        {
            #region Add Employee to List
            //Get user input for employee information
            do
            {
                if (firstNameBox.Text == "" || lastNameBox.Text == "" || phoneNumBox.Text == "" || ageBox.Text == "" || emailBox.Text == "")
                {
                    MessageBox.Show("Invalid Form! All boxes must be complete.");
                    #region Clear entries
                    firstNameBox.Clear();
                    lastNameBox.Clear();
                    phoneNumBox.Clear();
                    ageBox.Clear();
                    emailBox.Clear();
                    Employees.Items.Clear();
                    #endregion
                    loop = true;
                }
                else if (int.TryParse(ageBox.Text, out age))
                {
                    //Declare and initialize employee object
                    //Add employee infromation to employee list
                    employee.Add(new Employee(){FirstName = firstNameBox.Text, LastName = lastNameBox.Text, PhoneNumber = phoneNumBox.Text,
                    Age = age, EmployeeEmail = emailBox.Text });
                    loop = true;
                }
                else
                {
                    //Clear form if entries are invalid
                    MessageBox.Show("Invalid entry! Age must be a number!");
                    #region Clear entries
                    firstNameBox.Clear();
                    lastNameBox.Clear();
                    phoneNumBox.Clear();
                    ageBox.Clear();
                    emailBox.Clear();
                    Employees.Items.Clear();
                    #endregion
                    loop = true;
                }
            } while (loop == false);
            #endregion

            #region Clear Entries
            firstNameBox.Clear();
            lastNameBox.Clear();
            phoneNumBox.Clear();
            ageBox.Clear();
            emailBox.Clear();
            Employees.Items.Clear();
            #endregion            
        }
        #region Display Employee List
        private void displayEmployees_button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < employee.Count; i++)
            {//Adds employee information to list box                
                Employees.Items.Add($"Employee {i + 1}");
                Employees.Items.Add($"First Name: {employee.ElementAt(i).FirstName}");
                Employees.Items.Add($"Last Name: {employee.ElementAt(i).LastName}");
                Employees.Items.Add($"Phone Number {employee.ElementAt(i).PhoneNumber}");
                Employees.Items.Add($"Age: {employee.ElementAt(i).Age}");
                Employees.Items.Add($"Email: {employee.ElementAt(i).EmployeeEmail}");
                Employees.Items.Add($"*******************************");
            }
            #endregion
        }
        //Clear items from list box
        private void clearList_Click(object sender, EventArgs e)
        {
            Employees.Items.Clear();            
        }
        //Reset employee information
        private void resetEmployeeInfo_button_Click(object sender, EventArgs e)
        {
            #region Clear Entries
            firstNameBox.Clear();
            lastNameBox.Clear();
            phoneNumBox.Clear();
            ageBox.Clear();
            emailBox.Clear();
            Employees.Items.Clear();
            #endregion  
        }        
    }
}
