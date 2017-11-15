using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercises
{
    class Student
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public double Score { get; set; }
        public Student(string name, DateTime birthday, double score)
        {
            Name = name;
            Birthday = birthday;
            Score = score;
        }
    }
}
