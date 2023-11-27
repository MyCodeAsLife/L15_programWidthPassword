using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L15_programWidthPassword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string secretPassword = "Пароль";
            string secretMessage = "Большой секрет";
            int countOfAttemps = 3;
            string userInput;

            for (int i = countOfAttemps; i > 0; i--)
            {
                Console.WriteLine($"У вас всего попыток: {i}.");
                Console.Write("Введите пароль: ");
                userInput = Console.ReadLine();

                if (secretPassword == userInput)
                {
                    Console.WriteLine($"Доступ к секретному сообщению: {secretMessage}.\n");
                    break;
                }
                else
                {
                    Console.WriteLine($"Вы ввели неверный пароль.\n");
                }
            }
        }
    }
}
