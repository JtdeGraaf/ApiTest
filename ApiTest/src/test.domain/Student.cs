using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ApiTest.test.domain;

public class Student
{
    [Key]
    public long StudentId  { get; set; } = 1L ;
    
   
    public string Name { get; set; }

    public int Age { get; set; }

    public Student(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }
    
    public Student(){}
}