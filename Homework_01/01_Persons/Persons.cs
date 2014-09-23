using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_01._01_Persons
{
    class Persons
    {   
        //define fields
        private string name;
        private int age;
        private string email;

        //define constructors

        public Persons (string name,int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public Persons(string name, int age) : this(name,age,null)
        {
        }

        //define properties
        public string Name
        { 
            get{ return this.name;}
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentException("Name can't be empty!");
                this.name = value;
            }
        }

        public string Email
        {
            get { return this.email; }
            set
            {
                if (null != value && (!value.Contains("@") || value.Length == 0)){
                    throw new ArgumentException("Email is invalid!");
                }
                this.email = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentException("Age should be in the range [1..100]");
                }
                this.age = value;
            }
        }

        //print setup
        public override string ToString()
        {
            return string.Format("Name: {0}, age: {1}, email: {2}", this.name, this.age, this.email ?? "[no email]");
        }
    }
}
