
using System;

class Student
{
    private int studentId;
    private string name;
    private int age;
    private string department;
    private string enrolledCourse;

    public Student(int studentId, string name, int age, string department)
    {
        this.studentId = studentId;
        this.name = name;
        this.age = age;
        this.department = department;
        this.enrolledCourse = "Not enrolled";
    }

    public void EnrollCourse(string courseName)
    {
        enrolledCourse = courseName;
        Console.WriteLine(name + " enrolled in " + courseName);
    }

    public void Study()
    {
        Console.WriteLine(name + " is studying.");
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Student ID: " + studentId);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Department: " + department);
        Console.WriteLine("Course: " + enrolledCourse);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student(101, "Ali", 21, "Computer Engineering");

        student1.DisplayInfo();
        student1.EnrollCourse("Object Oriented Programming");
        student1.Study();

        Console.WriteLine();

        student1.DisplayInfo();
    }
}
