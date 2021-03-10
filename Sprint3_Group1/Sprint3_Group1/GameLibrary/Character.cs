using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class Character
    {
        private string _name;
        private string _playerRace;
        private string _playerClass;
        private string _playerPassword;
        private int _healthPoints;
        private int _coins;
        private int _potion;

        public Character()
        {
            Name = "";
            PlayerRace = "";
            PlayerClass = "";
            PlayerPassword = "";
            HealthPoints = 100;
            Coins = 0;
            Potion = 0;
        }
        public Character(string name, string playerRace, string playerClass, string playerPassword,int healthPoints,int coins, int potion)
        {
            Name = name;
            PlayerRace = playerRace;
            PlayerClass = playerClass;
            PlayerPassword = playerPassword;
            HealthPoints = healthPoints;
            Coins = coins;
            Potion = potion;

        }

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
        public string PlayerRace
        {
            get
            {
                return _playerRace;
            }
            set
            {
                _playerRace = value;
            }
        }
        public string PlayerClass
        {
            get
            {
                return _playerClass;
            }
            set
            {
                _playerClass = value;
            }
        }
        public string PlayerPassword
        {
            get
            {
                return _playerPassword;
            }
            set
            {
                _playerPassword = value;
            }
        }

        public int HealthPoints
        {
            get
            {
                return _healthPoints;
            }
            set
            {
                _healthPoints = value;
            }
        }
        public int Coins
        {
            get
            {
                return _coins;
            }
            set
            {
                _coins = value;
            }
        }
        public int Potion
        {
            get
            {
                return _potion;
            }
            set
            {
                _potion = value;
            }
        }

    }
}
