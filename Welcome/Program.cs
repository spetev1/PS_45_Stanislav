using Welcome.Model;
using Welcome.View;
using Welcome.ViewModel;

namespace Welcome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User()
            {
                Name = "Student1",
                Password = "password",

            };
            UserViewModel userviewm1 = new UserViewModel(user1);
            UserView userv1 = new UserView(userviewm1);
            userv1.Display();

        }
    }
}