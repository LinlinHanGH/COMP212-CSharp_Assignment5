using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linlin_Han_Lab05_Ex03
{
    class Student
    {
        //properties
        public string Id { get; set; }
        public string Name { get; set; }

        //construsctor
        public Student(string id, string name) {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return String.Format("\nStudent ID: {0}, Name:{1}", Name, Id);
        }
    }
}
