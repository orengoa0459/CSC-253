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
* 
* Revised Program*
* Date 11.27.2020
* -Added second form for details view and additional features 
* -Added Ascend and descend control buttons
* 
* Revised Program*
* Date 11.29.2020
*
*-Added highest and lowest pay rate control buttons
**/
namespace DisplayPersonnel
{
    public partial class displayEmployeeData_button : Form
    {        
        //String path location for the database
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Anthony\Desktop\HourlyPaySorter_OrengoAnthony\DisplayPersonnel\Personnel.mdf;Integrated Security=True;";
        
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
           // this.employeeTableAdapter.Fill(this.personnelDataSet.Employee);

        }
        private void showDetails_button_Click(object sender, EventArgs e)
        {
            //Create an instance of the Details form
            DetailsForm details = new DetailsForm();

            //Display the form
            details.ShowDialog();

            //Update the dataset
            this.employeeTableAdapter.Fill(this.personnelDataSet.Employee);
        }
        private void exit_button_Click(object sender, EventArgs e)
        {
            //Close form
            this.Close();
        }

        private void closeTable_button_Click(object sender, EventArgs e)
        {
            
        }

        private void ascendButton_Click(object sender, EventArgs e)
        {
            dataGridViewBox.Sort(dataGridViewBox.Columns[3], ListSortDirection.Ascending);
        }

        private void descendButton_Click(object sender, EventArgs e)
        {
            dataGridViewBox.Sort(dataGridViewBox.Columns[3], ListSortDirection.Descending);
        }

        private void highestPayRateButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connection))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDisplayAdapter = new SqlDataAdapter("SELECT MAX(HourlyRate) FROM Employee;", sqlCon);
                 
                DataTable dataTable = new DataTable();
                sqlDisplayAdapter.Fill(dataTable);


                dataGridViewBox.DataSource = dataTable;
            }
        }

        private void lowestPayRateButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connection))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDisplayAdapter = new SqlDataAdapter("SELECT MIN(HourlyRate) FROM Employee;", sqlCon);

                DataTable dataTable = new DataTable();
                sqlDisplayAdapter.Fill(dataTable);


                dataGridViewBox.DataSource = dataTable;
            }
        }
    }
}
