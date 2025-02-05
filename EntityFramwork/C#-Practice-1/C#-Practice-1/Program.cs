using C__Practice_1.DataLayer;
using C__Practice_1.Domain;

ContextClass context = new ContextClass();
Teacher teacher = new Teacher() { Name= "Sina",FamilyName="Rezaei"};
context.Teachers.Add(teacher);
context.SaveChanges();
var teachers = context.Teachers.FirstOrDefault();
Console.WriteLine(teachers.Name + teachers.FamilyName);
//Student student = new Student() { Name= "reza" , FamilyName="Samodi", Teacher_Id=teacher.Id};