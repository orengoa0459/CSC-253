using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class Mobs
    {
        //fields
        private string _name;
        private string _description;
        private int _attackPoints;
        private int _health;

        // Default constructors
        public Mobs()
        {
            Name = "";
            Description = "";
            AttackPoints = 0;
            Health = 0;
        }
        //Custom constructors
        public Mobs(string name, string description, int AP, int health)
        {
            Name = name;
            Description = description;
            AttackPoints = AP;
            Health = health;
        }


        //properties

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }
        public string Description
        {
            get
            {
                return _description;
            }

            set
            {
                _description = value;
            }
        }
        public int AttackPoints
        {
            get
            {
                return _attackPoints;
            }

            set
            {
                _attackPoints = value;
            }
        }
        public int Health
        {
            get
            {
                return _health;
            }

            set
            {
                _health = value;
            }
        }
    }
}
