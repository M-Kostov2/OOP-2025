using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_homework
{
     class Employee : Person
    {
        

        public Employee(string name,int age,string gender,string phone) :base(name,age,gender,phone)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.phone = phone;

        }
    }
}
