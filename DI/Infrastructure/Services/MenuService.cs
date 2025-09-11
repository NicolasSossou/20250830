
using Infrastructure.Managers;
using Infrastructure.Models;

namespace Infrastructure.Services
{
    public class MenuService
    {
        private readonly UserManager _userManager = new UserManager();
        public void ShowMainMenu()
        {
            var user = new User();

            Console.Write("Enter First Name: ");

            user.FirstName = Console.ReadLine()!;

            _userManager.CreateUser(user);

            Console.WriteLine("User was created.");
            Console.ReadKey();
        }
    }
}
