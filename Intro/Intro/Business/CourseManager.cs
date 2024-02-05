using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Business;

public class CourseManager
{
    Course[] courses = new Course[3];
    public CourseManager()
    {

        Course course1 = new Course();
        course1.Id = 1;
        course1.Name = "C#";
        course1.Description = ".NET 8 vs ....";
        course1.Price = 0;

        Course course2 = new Course();
        course1.Id = 2;
        course1.Name = "JAVA";
        course1.Description = "Java 17 ....";
        course1.Price = 10;

        Course course3 = new Course();
        course1.Id = 3;
        course1.Name = "Python";
        course1.Description = "Python 3.12 ....";
        course1.Price = 20;

        courses[0] = course1;
        courses[1] = course2;
        courses[2] = course3;
    }

    public Course[] GetAll()
    {
        return courses;
    }
}
