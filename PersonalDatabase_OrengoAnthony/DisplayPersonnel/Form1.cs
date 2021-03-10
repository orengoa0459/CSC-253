using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
/*
* Date 11.07.2020
* CSC 153
* Anthony Orengo
* Program description: This program contains a database named Personnel.mdf
* and displays the Employee table using a form application.
*/
namespace DisplayPersonnel
{
    public partial class displayEmployeeData_button : Form
    {
        
        //String path location for the database
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PersonalDatabase_OrengoAnthony\DisplayPersonnel\Personnel.mdf;Integrated Security=True;";
        
        public displayEmployeeData_button()
        {
            InitializeComponent();
        }
        //Loads the tabel into the data grid
        private void displayEmployee_button_Click(object sender, EventArgs e)
        {
            using(SqlConnection sqlCon = new SqlConnection(connection))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDisplayAdapter = new SqlDataAdapter("SELECT * FROM Employee", sqlCon);

                DataTable dataTable = new DataTable();
                sqlDisplayAdapter.Fill(dataTable);


                dataGridViewBox.DataSource = dataTable;
            }
        }

        private void displayEmployeeData_button_Load(object sender, EventArgs e)
        {
            //Loads the tabel into the data grid
            this.employeeTableAdapter.Fill(this.personnelDataSet.Employee);

        }

        
    }
}
