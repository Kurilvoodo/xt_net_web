using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtEpamTask06.Entities
{
    class User
    {
        public int Id { get; set; }
        public string Name { get; private set; }
        private DateTime _dateOfBirth;
        
        public DateTime DateOfBirth
        {
            get => _dateOfBirth;
            private set
            {
                if (value < DateTime.Now)
                    _dateOfBirth = value;
                else
                    throw new ArgumentOutOfRangeException("Date of birth don't be more than the current date");
            }
        }
        public double Age { get => (int)DateTime.Now.Subtract(DateOfBirth).TotalDays / 365; }

        public User(string name, DateTime dateOfBirth)
        {
            Name = name;
            _dateOfBirth = dateOfBirth;
            
        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder($"Id: {Id}" + Environment.NewLine +
                $"Name: {Name}" + Environment.NewLine +
                $"DateOfBirth: {DateOfBirth}" + Environment.NewLine +
                $"Age: {Age}" + Environment.NewLine);
          return info.ToString();
        }
    }
}
