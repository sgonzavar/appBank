using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleAppBank
{
    internal class Person
    {
        private string name;
        private string age;
        private decimal money;

        public Person()
        {
        }

        public Person(string name, string age, decimal money)
        {
            this.name = name;
            this.age = age;
            this.money = money;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Age
        {
            get { return age; }
            set { age = value; }
        }
        public decimal Money
        {
            get { return money; }
            set { money = value; }
        }
    }
}
