using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeLibrary;
namespace ConsoleUI
{
    public class GetEmployeeInformation
    {
        public static void EnterEmployeeInformation(List<Employee> employeeData, string input, int index)
        {
            //Get employee information and store in list
            int number = 0;
            double num = 0.0;
            Console.Write(EmployeeLibrary.StandardMessages.GetEmployeesFirstName());
            input = Console.ReadLine();
            employeeData.Add(new Employee());
            employeeData[index].FirstName = input;
            Console.Write(EmployeeLibrary.StandardMessages.GetEmployeesLastName());
            input = Console.ReadLine();
            employeeData.Add(new Employee());
            employeeData[index].LastName = input;
            Console.Write(EmployeeLibrary.StandardMessages.GetPhoneNumber());
            input = Console.ReadLine();
            employeeData[index].PhoneNumber = input;
            Console.Write(EmployeeLibrary.StandardMessages.GetEmployeesAge());
            //s
            //    number = int.Parse(Console.ReadLine());
            //employeeData[index].Age = number;
            //Console.Write(EmployeeLibrary.StandardMessages.GetEmployeesBasePay());
            //num = double.Parse(Console.ReadLine());
            //employeeData[index].BasePay = num;         
            
           

        }
    }
}
