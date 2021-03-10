using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeLibrary;
namespace ConsoleUI
{
    public class DisplayEmployeeInformation
    {
        public static void DisplayEmployee(List<Employee> employeeInfo)
        {
            //Display employee's information
            foreach (Employee employData in employeeInfo)
            {
                Console.WriteLine($"Name: {employData.FirstName} Phone Number: {employData.PhoneNumber} Age: {employData.Age} Email: {employData.Email()}");
            }
            Console.ReadLine();
        }
    }
}
