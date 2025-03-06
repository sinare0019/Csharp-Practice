using C__Practice_1.DataLayer;
using C__Practice_1.Domain;

ContextClass context = new ContextClass();
var allTeachers = context.Teachers.OrderBy(x => x.Name).ToList();
var allTeachersNotRepet = context.Teachers.DistinctBy(x => x.Name);
var teacher = context.Teachers.Where(x => x.Id > 3).FirstOrDefault();
var teacherLast = context.Teachers.Where(x => x.Id > 3).LastOrDefault();
var student = from y in context.Students
              where y.Id > 2
              select new Student
              {
                  Id = y.Id,
                  Name = y.Name,
                  FamilyName = y.FamilyName,
                  Teacher_Id = y.Teacher_Id
              };
var studentGroup = student.GroupBy(x => x.Teacher_Id);
