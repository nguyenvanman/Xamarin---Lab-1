using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercises
{
    class Student
    {
        private string name;
        private DateTime birthday;
        private double score;

        public string Name
        {
            get => name;
            set => name = value;
        }

        public DateTime Birthday
        {
            get => birthday;
            set => birthday = value;
        }

        public double Score
        {
            get => score;
            set => score = value;
        }

        public Student(string name, DateTime birthday, double score)
        {
            this.name = name;
            this.birthday = birthday;
            this.score = score;
        }
    }
}
