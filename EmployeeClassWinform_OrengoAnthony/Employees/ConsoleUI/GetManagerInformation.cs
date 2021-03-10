using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeLibrary;
namespace ConsoleUI
{
    public class GetManagerInformation
    {
        public static void EnterManagerInformation(List<Manager> managerData, string input, int index)
        {
            //Get employee information and store in list
            int number = 0;

            Console.Write(EmployeeLibrary.StandardMessages.GetEmployeesFirstName());
            input = Console.ReadLine();
            managerData.Add(new Manager());
            managerData[index].FirstName = input;
            Console.Write(EmployeeLibrary.StandardMessages.GetEmployeesLastName());
            input = Console.ReadLine();
            managerData.Add(new Manager());
            managerData[index].LastName = input;
            Console.Write(EmployeeLibrary.StandardMessages.GetPhoneNumber());
            input = Console.ReadLine();
            managerData[index].PhoneNumber = input;
            Console.Write(EmployeeLibrary.StandardMessages.GetEmployeesAge());
            number = int.Parse(Console.ReadLine());
            managerData[index].Age = number;
            Console.Write(EmployeeLibrary.StandardMessages.GetManagersPromotionDate());
            input = Console.ReadLine();
            managerData.Add(new Manager());
            managerData[index].DateOfPromotion = input;


        }
    }
}
