using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class Manager : Employee
    {
        #region Fields
        //Fields
        private string _dateOfPromotion;
        private double _basePayManager;
        #endregion

        #region Constructors
        //Constructors
        public Manager(string firstName, string lastName, string phoneNumber, int age, string email, double basePay,string phoneType, string dateOfPromotion, double basePayManager): base(firstName, lastName,phoneNumber,age,email,basePay,phoneType)        
        {
            DateOfPromotion = dateOfPromotion;
            BasePayManager = basePayManager;
        }

        public Manager()
        {
            DateOfPromotion = " ";
            BasePayManager = 0;
        }
        #endregion

        #region Properties
        //Properties
        public string DateOfPromotion
        {
            get
            {
                return _dateOfPromotion;
            }
            set
            {
                _dateOfPromotion = value;
            }
        }
        public double BasePayManager
        {
            get
            {
                return _basePayManager;
            }
            set
            {
                _basePayManager = value;
            }
        }

        public override string Email()
        {
            return LastName + "@manager.com";
        }
        #endregion
    }
}
