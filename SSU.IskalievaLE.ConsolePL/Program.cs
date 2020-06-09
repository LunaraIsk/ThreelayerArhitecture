using SSU.IskalievaLE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSU.IskalievaLE.ConsolePL
{
    class Program
    {
        static void Main(string[] args)
        
        {
            bool A = true;
            while (A)
            {
                Console.WriteLine("1 - добавить пользователя");
                Console.WriteLine("2 - удалить пользователя");
                Console.WriteLine("3 - вывести список пользователей");
                Console.WriteLine("4 - добавить новый тип наград");
                Console.WriteLine("5 - вывести список всех награды");
                Console.WriteLine("6 - просмотреть пользователей и все их награды");
                Console.WriteLine();
                Console.WriteLine("Введите действие:");
                var action = Console.ReadLine();

                switch (action)
                {
                    case "1":
                        LogicPL.AddUser();
                        break;
                    case "2":
                        LogicPL.DeleteUser();
                        break;
                    case "3":
                        LogicPL.GetAllUsers();
                        break;
                    case "4":
                        LogicPL.AddAward();
                        break;
                    case "5":
                        LogicPL.GetAllAwards();
                        break;
                    case "6":
                        LogicPL.GetAllUsersAwards();
                        break;
                    default:
                        A = false;
                        break;
                }
            }
        }
    }
}
