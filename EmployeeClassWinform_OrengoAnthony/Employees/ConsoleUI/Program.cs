using EmployeeInformationForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeLibrary;
using EmployeeInformationForm;
using System.Windows.Forms;
namespace ConsoleUI
{
    class Program
    {
       
        static void Main(string[] args)
        {
            //Variable to get user input 
            string input;
            //Sentry for loop
            bool exit = false;                    
            
            int index = 0;
            int managerIndex = 0;
            
            List<Employee> employeeInfo = new List<Employee>();
            List<Manager> managerInfo = new List<Manager>();
            do
            {
                //Displays main menu
                Console.Write(EmployeeLibrary.StandardMessages.DisplayMainMenu());
                input = Console.ReadLine();
                //Switch to direct to proper process
                switch (input)
                {
                    case "1":
                        //Get employee's info                       
                        Application.EnableVisualStyles();
                        Application.Run(new displayList( ));

                        //GetEmployeeInformation.EnterEmployeeInformation(employeeInfo, input, index);
                        //index++;

                        break;
                    case "2":
                        //Get employee's info
                       GetManagerInformation.EnterManagerInformation(managerInfo, input, managerIndex);
                        managerIndex++;
                        break;
                    case "3":
                        //Display employee's information
                        DisplayEmployeeInformation.DisplayEmployee(employeeInfo);
                        break;
                    case "4":
                        //Display employee's information
                        DisplayManagerInformation.DisplayManager(managerInfo, employeeInfo);
                        break;
                    case "5":
                        //TODO Display average age of employee                       
                        DisplayAverageAge.EmployeeAverageAge(employeeInfo);
                        break;
                    case "6":
                        //exit program
                        exit = true;
                        break;
                    default:
                        //Create writeline invalid choice
                        EmployeeLibrary.StandardMessages.InvlaidNumber();
                        break;
                }
            } while (exit == false);
        }
        

        
    }
}
