using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp
{
    class Student
    {
        private int id;
        private string rollNumber;
        private string name;

        public Student()
        {
            
        }

        public Student(string rollNumber, string name)
        {
            this.rollNumber = rollNumber;
            this.name = name;
        }

        public Student(int id, string rollNumber, string name)
        {
            this.Id = id;
            this.RollNumber = rollNumber;
            this.Name = name;
        }

        public int Id { get => id; set => id = value; }
        public string RollNumber { get => rollNumber; set => rollNumber = value; }
        public string Name { get => name; set => name = value; }
    }
}
