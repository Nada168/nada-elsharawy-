
 using System;
namespace OssTask;

public  class Person
{
    public string Name;
    public int Age;
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public virtual void Print()


    {
        Console.WriteLine($"My name is {Name}, my age is {Age}");
    }

}
public class Student : Person
{
    public int Year;
    public float Gpa;
    public Student(string name, int age, int year, float gpa) : base(name, age)
    {
        Year = year;
        Gpa = gpa;
    }
    public override void Print()
    {
        Console.WriteLine($"my name is{Name},my age is {Age},and gpa is {Gpa}");

    }
}
public class Staff : Person
{
    public double Salary;
    public int JoinYear;
    public Staff(string name, int age, double salary, int jyear) : base(name, age)
    {
        Salary = salary;
        JoinYear = jyear;
    }
    public override void Print()
    {
        Console.WriteLine($"my name is {Name},my age is {Age},and my salary is {Salary}");

    }
}

    public class Database
    {
        private int _currentIndex;
        public Person[] People = new Person[30];

        public void AddStudent(Student student)
        {

            People[_currentIndex++] = student;
        }
        public void AddStaff(Staff staff)
        {

            People[_currentIndex++] = staff;
        }
        public void AddPerson(Person person)
        {
            People[_currentIndex++] = person;
        }
        public void PrintAll()
        {
            for (int i = 0; i < _currentIndex; i++)
            { People[i].Print(); }
        }

    }

    public class program
    {
        private static void Main()
        {
            Console.WriteLine("hello world");
            var database = new Database();
            while (true)
            {
                Console.WriteLine("press :/1/- for adding student /2/- for adding a stuff /3/- for adding person /4/- for printing out all people in people array  ");
                Console.Write("option: ");
                var x = Convert.ToInt32(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        Console.Write("Name: ");
                        var name = Console.ReadLine();
                        Console.Write("age: ");
                        var age = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Year: ");
                        var year = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Gpa: ");
                        var gpa = Convert.ToSingle(Console.ReadLine());
                        var student = new Student(name, age, year, gpa);
                        database.AddStudent(student);
                        break;
                    case 2:
                        Console.Write("Name: ");
                        var name1 = Console.ReadLine();
                        Console.Write("age: ");
                        var age1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Salary: ");
                        var Salary = Convert.ToInt32(Console.ReadLine());
                        Console.Write("JoinYear: ");
                        var JoinYear = Convert.ToInt32(Console.ReadLine());
                    var staff= new Staff(name1, age1, Salary, JoinYear);
                        database.AddStaff(staff);
                        break;
                    case 3:
                        Console.Write("Name: ");
                        var name2 = Console.ReadLine();
                        Console.Write("age: ");
                        var age2 = Convert.ToInt32(Console.ReadLine());
                        var person = new Person(name2, age2);
                        database.AddPerson(person);

                        break;
                    case 4:

                        database.PrintAll();
                        break;

                    default:

                        return;


                }

            }
        }
    }





