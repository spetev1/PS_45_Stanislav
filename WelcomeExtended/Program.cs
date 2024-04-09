using Welcome.Model;
using Welcome.View;
using Welcome.ViewModel;
using Welcome.Others;
using WelcomeExtended.Others;


namespace WelcomeExtended
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                User user = new User()
                {
                    Name = "John Smith",
                    Password = "password123",
                    Role = UserRolesEnum.STUDENT,
                    email = "123@gmail.com",
                    facNumber = "1234"

                };
                var viewModel = new UserViewModel(user);
                var view = new UserView(viewModel);
                view.Display();
            }
            catch (Exception e)
            {
                var log = new ActionOnError(Delegates.Log);
                log(e.Message);
            }
            finally
            {
                Console.WriteLine("Executed in any case!");
            }
        }
    }
}