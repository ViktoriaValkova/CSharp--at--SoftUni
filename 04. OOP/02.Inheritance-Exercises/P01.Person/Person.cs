using System;
using System.Text;

namespace Person
{
    public class Person
    {
        private string _name;
        private int _age;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public int Age
        {
            get { return _age; }
            set
            {
                if (value >= 0)
                {
                    this._age = value;
                }
            }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(String.Format("Name: {0}, Age: {1}",
                                 this.Name,
                                 this.Age));

            return stringBuilder.ToString();
        }

    }
}
