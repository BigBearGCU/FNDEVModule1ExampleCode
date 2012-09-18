using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IComparableDemo
{
    class Student:IComparable<Student>
    {
        private int age;
        private string name;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        #region IComparable<Student> Members

        public int CompareTo(Student other)
        {
            return this.age.CompareTo(other.age);
        }

        #endregion
    }
}
