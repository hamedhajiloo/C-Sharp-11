using CSharp11.Required;
using System.Diagnostics.CodeAnalysis;

var person = new Person("Hamed");

var teacher = new Teacher
{
    Name = "Hamed"
};


var student = new Student("Hamed");

public class Student
{
    [SetsRequiredMembers]
    public Student(string name)
    {
        Name = name;
    }
    public required string Name { get; set; }
}