using SSU.IskalievaLE.BLL;
using SSU.IskalievaLE.BLL.Interface;
using SSU.IskalievaLE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSU.IskalievaLE.ConsolePL
{
    public static class LogicPL
    {
        private static IUserLogic userLogic = new UserLogic();

        private static IAwardLogic awardLogic = new AwardLogic();

        private static IUserAwardLogic userawardLogic = new UserAwardLogic();
        public static void AddUser()
        {
            Console.WriteLine("Введите имя");
            var firstName = Console.ReadLine();

            Console.WriteLine("Введите фамилию");
            var lastName = Console.ReadLine();

            Console.WriteLine("Введите дату рождения");
            var dateOfBirth = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Введите возраст");
            var age = byte.Parse(Console.ReadLine());

            var currentUser = new User
            {
                FirstName = firstName,
                LastName = lastName,
                DateOfBirth = dateOfBirth,
                Age = age,
            };

            userLogic.AddUser(currentUser);
        }

        public static void DeleteUser()
        {
            Console.WriteLine("Введите номер клиента для удаления:");
            int value = int.Parse(Console.ReadLine());

            userLogic.DeleteUser(value);
        }

        public static void GetAllUsers()
        {
            var collection = userLogic.GetAllUsers();
            foreach (var item in userLogic.GetAllUsers())
            {
                Console.WriteLine(item);
            }
        }

        public static void AddAward()
        {
            Console.WriteLine("Введите название");
            var title = Console.ReadLine();

            var currentAward = new Award
            {
                Title = title,
            };

            awardLogic.AddAward(currentAward);
        }
        public static void GetAllAwards()
        {
            var collection = awardLogic.GetAllAwards();
            foreach (var item in awardLogic.GetAllAwards())
            {
                Console.WriteLine(item);
            }
        }

        public static void GetAllUsersAwards()
        {
            var collection = userawardLogic.GetAllUsersAwards();
            foreach (var item in userawardLogic.GetAllUsersAwards())
            {
                Console.WriteLine(item);
            }
        }


    }
}
