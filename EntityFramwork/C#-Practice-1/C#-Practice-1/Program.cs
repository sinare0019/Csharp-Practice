using C__Practice_1.DataLayer;
using C__Practice_1.Domain;

ContextClass context = new ContextClass();
Teacher teacher = new Teacher() { Name= "Sina",FamilyName="Rezaei"};
context.Teachers.Add(teacher);
context.SaveChanges();

//Student student = new Student() { Name= "reza" , FamilyName="Samodi", Teacher_Id=teacher.Id};