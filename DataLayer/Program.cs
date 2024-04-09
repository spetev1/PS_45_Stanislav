
using DataLayer.DataBase;
using DataLayer.Model;
using System.Data;
using System.Xml.Linq;
using Welcome.Others;

using (var context = new DatabaseContext())
{
    context.Database.EnsureCreated();
    context.Add<DatabaseUser>(new DatabaseUser()
    {
        Name = "user",
        Password = "password",
        expires = DateTime.Now,
        Role = UserRolesEnum.STUDENT,
        email = "email",
        facNumber = "1234"
        
    });
    context.SaveChanges();
    var users = context.Users.ToList(); 
    Console.ReadKey();
}
