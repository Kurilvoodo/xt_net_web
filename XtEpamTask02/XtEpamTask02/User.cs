using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtEpamTask02
{
    class User
    {
        private string _surname;
        private string _name;
        private DateTime _dateOfBirth;
        private int _age;

        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = value;
            }
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
        public DateTime DateOfBirth
        {
            get
            {
                return _dateOfBirth;
            }
            set
            {
                _dateOfBirth = value;
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
                if (value > 0)
                {
                    _age = value;
                }
                else
                {
                    DateTime servant = new DateTime();
                    servant = DateTime.Now;
                    if ((servant.Year - this.DateOfBirth.Year) == value)
                    {
                        _age = value;
                    }
                    else 
                    {
                        throw new Exception($"This must be mistake, age = {value} isn't equal to Date of Birth {this._dateOfBirth}");
                    }
                }
            }
        }
    }
}
