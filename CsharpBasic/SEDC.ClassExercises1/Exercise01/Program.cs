
using Exercise01.Models.Interfaces;

var student1 = new Student { Id = 1, Name = "Tosho", Username = "tosho123", Password = "pass123", Grades = new List<int> { 90, 85, 78 } };
var student2 = new Student { Id = 2, Name = "Mario", Username = "mario123", Password = "pass456", Grades = new List<int> { 76, 88, 91 } };
var teacher1 = new Teacher { Id = 3, Name = "Petko", Username = "petko123", Password = "pass789", Subject = "Math" };
var teacher2 = new Teacher { Id = 4, Name = "Stanko", Username = "stanko123", Password = "pass012", Subject = "English" };

student1.PrintUser();
student2.PrintUser();
teacher1.PrintUser();
teacher2.PrintUser();