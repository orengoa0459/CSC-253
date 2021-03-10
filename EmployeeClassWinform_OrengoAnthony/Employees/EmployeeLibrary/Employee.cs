using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class Employee
    {
        #region Fields
        private string _firstName;
        private string _lastName;
        private string _phoneNumber;
        private int _age;
        private string _email;
        private double _basePay;
        private string _phoneType;
        #endregion

        #region Constructors
        //Constructor
        public Employee()
        {
            FirstName = "";
            LastName = "";
            PhoneNumber = "";
            Age = 0;
            EmployeeEmail = "";
            BasePay = BasePay * 5;
            PhoneType = "";
        }
        //Constructor
        public Employee(string firstName,string lastName, string phoneNumber, int age,string email, double basePay, string phoneType)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Age = age;
            EmployeeEmail = email;
            BasePay = basePay;
            phoneType = phoneType;
        }
        #endregion

        #region Properties
        //Properties

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                _phoneNumber = value;
            }
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }
        public string EmployeeEmail
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }
        public double BasePay
        {
            get
            {
                return _basePay;
            }
            set
            {
                _basePay = value;
            }
        }
        public virtual string Email()
        {
            return LastName + "@worker.com";
        }
        public string PhoneType
        {
            get
            {
                return _phoneType;
            }
            set
            {
                _phoneType = value;
            }
        }
        #endregion
    }
}
