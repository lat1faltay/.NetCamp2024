// See https://aka.ms/new-console-template for more information
using Intro.Business;
using Intro.Entities;

Console.WriteLine("Hello, World!");

Course course1 = new Course();
course1.Id = 1;
course1.Name = "C#";
course1.Description = ".NET 8 vs ....";
course1.Price = 0;

Course course2 = new Course();
course1.Id = 1;
course1.Name = "JAVA";
course1.Description = "Java 17 ....";
course1.Price = 10;

Course course3 = new Course();
course1.Id = 1;
course1.Name = "Python";
course1.Description = "Python 3.12 ....";
course1.Price = 20;

Course[] courses = { course1, course2, course3 };


CourseManager courseManager = new ();
Course[] courses2 = courseManager.GetAll();

for (int i = 0; i < courses2.Length; i++)
{
    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
}

Console.WriteLine("Kod bitti");
