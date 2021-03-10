using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeLibrary;
namespace ConsoleUI
{
    public class DisplayManagerInformation
    {
        public static void DisplayManager(List<Manager> managerInfo, List<Employee> emploInfo)
        {
            
            //Display employee's information
            foreach (Manager managerData in managerInfo)
            {
                Console.WriteLine($"Name: {managerData.FirstName} Phone Number: {managerData.PhoneNumber} Age: {managerData.Age} Email: {managerData.Email()}");
            }
            Console.ReadLine();
        }
    }
}
