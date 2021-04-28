using System;
namespace StudentApi.Models
{
    public class Student
    {
       public long Id { get; set; }
       public string FirstName { get; set; }
       public string LastName { get; set; }
       public string Course { get; set; }
       public string Nationality { get; set; }
       public bool IsComplete { get; set; }
    }
}
