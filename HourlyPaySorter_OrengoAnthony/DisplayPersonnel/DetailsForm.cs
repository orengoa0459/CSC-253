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
namespace DisplayPersonnel
{
    public partial class DetailsForm : Form
    {        
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter displayAdapter;
        int convert = 0;
        public DetailsForm()
        {
            InitializeComponent();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.personnelDataSet);

        }

        private void DetailsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personnelDataSet.Employee' table. You can move, or remove it, as needed.
            //this.employeeTableAdapter.Fill(this.personnelDataSet.Employee);

        }

        private void addRecord_button_Click(object sender, EventArgs e)
        {
            //Create sql connection
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PersonalDatabase_OrengoAnthony\DisplayPersonnel\Personnel.mdf;Integrated Security=True;");
            //Open sql connection
            con.Open();
            double hourly = 0.0;

            if (double.TryParse(hourlyRateTextBox.Text, out hourly))
            {

            }
            else
            {
                MessageBox.Show("Invalid Hourly Rate");
            }
            //Insert data into table Employees
            string query = "INSERT INTO Employee (EmployeeID, Name, Position,HourlyRate) VALUES('" + employeeIdTextBox.Text + "','" + nameTextBox.Text + "', '" + positionTextBox.Text + "', '" + hourly.ToString("C3", System.Globalization.CultureInfo.CurrentCulture) + "')";
            displayAdapter = new SqlDataAdapter(query, con);
            displayAdapter.SelectCommand.ExecuteNonQuery();
            con.Close();


            //Clears text boxes
            employeeIdTextBox.Clear();
            nameTextBox.Clear();
            positionTextBox.Clear();
            hourlyRateTextBox.Clear();
        }

        private void close_button_Click_1(object sender, EventArgs e)
        {
            //Closes form
            this.Close();
        }        
    }
}
