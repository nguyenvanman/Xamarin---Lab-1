using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> listStudents = new List<Student>();
            Console.Write("Enter the size of the list: ");
            var size = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter name of student {0}: ", i + 1);
                var name = Console.ReadLine();
                Console.Write("Enter the birthday (dd/MM/yyyy or dd-MM-yyyy): ");
                var birthday = GetDateFromString(Console.ReadLine());
                Console.Write("Enter the score: ");
                var score = Convert.ToDouble(Console.ReadLine());
                Student student = new Student(name, birthday, score);
                listStudents.Add(student);
            }
            SortListStudentsByScore(listStudents);
            foreach (var student in listStudents)
            {
                Console.WriteLine(student.Name + "\t" + student.Birthday.ToString("yyyy MMMM dd") + "\t" + student.Score);
            }
            Console.ReadKey();
        }
        static void SortListStudentsByScore(List<Student> listStudents)
        {
            for (int i = 0; i < listStudents.Count - 1; i++)
            {
                for (int j = i + 1; j < listStudents.Count; j++)
                {
                    if (listStudents[j].Score < listStudents[i].Score)
                    {
                        Student tempStudent = listStudents[i];
                        listStudents[i] = listStudents[j];
                        listStudents[j] = tempStudent;
                    }
                }
            }
        }
        static DateTime GetDateFromString(string strDate)
        {
            var tokens = strDate.Split('/', '-');
            var date = Convert.ToInt32(tokens[0]);
            var month = Convert.ToInt32(tokens[1]);
            var year = Convert.ToInt32(tokens[2]);
            return new DateTime(year, month, date);
        }
    }
}
