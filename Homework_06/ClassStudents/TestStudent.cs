using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStudents
{
    class TestStudent
    {
        static void Main()
        {
            //creating students
            Student Daniel = new Student("Daniel","Dimitrov",24,"104129","0885181621","Daniel@abv.bg",new List<int>{4,5,4,5,4,5,6},1);
            Student Pesho = new Student("Petyr", "Ivanov", 22, "104309", "0882181621", "Pepi@abv.bg", new List<int> { 4, 4, 4, 2, 6, 6, 6 }, 2);
            Student Vesy = new Student("Vesela", "Veselinova", 25, "104298", "0845181621", "Vesy@gmial.com", new List<int> { 4, 5, 3, 5, 4, 6, 6 }, 1);
            Student Ivan = new Student("Ivan", "Georgiev", 21, "104172", "0885451622", "Ivan@gmail.com", new List<int> { 4, 2, 4, 5, 3, 5, 6 },2);
            Student Goro = new Student("Georgi", "Georgiev", 21, "141014", "02/451622", "Goro@gmail.com", new List<int> { 4, 2, 4, 5, 3, 2, 6 }, 2);

            //combine them in list
            List<Student> MainList = new List<Student> { };
            MainList.Add(Daniel);
            MainList.Add(Pesho);
            MainList.Add(Vesy);
            MainList.Add(Ivan);
            MainList.Add(Goro);

            //test show all students
            MainList.ForEach(person => Console.WriteLine(person));
            Console.WriteLine();

            //Problem 4.	Students by Group
            var querryGroupTwo =
                from student in MainList
                where student.GroupNumber == 2
                orderby student.FirstName
                select student;

            foreach (var item in querryGroupTwo)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            //Problem 5.	Students by First and Last Name
            var nameQuerry =
                from student in MainList
                where student.FirstName[0] > student.LastName[0]
                select new { Fname = student.FirstName, Lname = student.LastName };
            foreach (var item in nameQuerry)
            {
                Console.WriteLine("{0} {1}",item.Fname,item.Lname);
            }
            Console.WriteLine();

            //Problem 6.	Students by Age
            var ageQuerry =
                from student in MainList
                where student.Age < 25 && student.Age > 18
                select new { Fname = student.FirstName, Lname = student.LastName, Age = student.Age };
            foreach (var item in ageQuerry)
            {
                Console.WriteLine("{0}, {1}, {2}",item.Fname,item.Lname,item.Age);
            }
            Console.WriteLine();

            //Problem 7.	Sort Students
            var sortQuerry =
                from student in MainList
                orderby student.FirstName, student.LastName descending
                select new { Fname = student.FirstName, Lname = student.LastName };
            foreach (var item in sortQuerry)
            {
                Console.WriteLine("{0} {1}",item.Fname,item.Lname);
            }
            Console.WriteLine();

            //Problem 8.	Filter Students by Email Domain
            var domainQuerry =
                from student in MainList
                where student.Email.Contains("@abv.bg")
                select new { Fname = student.FirstName, Lname = student.LastName, Email = student.Email };
            foreach (var item in domainQuerry)
            {
                Console.WriteLine("{0}, {1}, {2}", item.Fname, item.Lname, item.Email);
            }

            Console.WriteLine();

            //Problem 9.	Filter Students by Phone
            var phoneQuerry =
                from student in MainList
                where (student.Phone.Contains("02/") || student.Phone.Contains("+3592/") || student.Phone.Contains("+359 2"))
                select new { Fname = student.FirstName, Lname = student.LastName, Phone = student.Phone };
            foreach (var item in phoneQuerry)
            {
                Console.WriteLine("{0}, {1}, {2}",item.Fname, item.Lname, item.Phone);
            }
            Console.WriteLine();

            //Problem 10.	Excellent Students
            var excellentQuerry =
                from student in MainList
                where student.Marks.Contains(6)
                select new { fullName = student.FirstName + " " + student.LastName, student.Marks };
            foreach (var item in excellentQuerry)
            {
                string marks = string.Join(", ", item.Marks);
                Console.WriteLine("Student {0} has {1} marks",item.fullName, marks);
            }
            Console.WriteLine();

            //Problem 11.	Weak Students
            var bottomQuerry = 
                from student in MainList
                where student.Marks.Where(score => score == 2).Count() == 2
                select new { fullName = student.FirstName + " " + student.LastName, student.Marks };
            foreach (var item in bottomQuerry)
            {
                string marks = string.Join(", ", item.Marks);
                Console.WriteLine("Student {0} has {1} marks", item.fullName, marks);
            }
            Console.WriteLine();

            //Problem 12.	Students Enrolled in 2014
            var enrolledQuerry =
                from student in MainList
                where (student.FacultyNumber.ElementAt(4) == '1' && student.FacultyNumber.ElementAt(5) == '4')
                select new { fullName = student.FirstName + " " + student.LastName};
            foreach (var item in enrolledQuerry)
            {
                Console.WriteLine(item.fullName);
            }


            Console.ReadKey();
        }
    }
}
