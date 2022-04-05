using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Fighting
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            //int value = rnd.Next();


            int playerHealth = 100;
            int playerEnergy = 100;

            int enemyHealth = 100;
            int enemyEnergy = 100;

            int action = -1;

            while (true)
            {
                // Отображене статов и скиллов

                Console.Clear();

                Console.WriteLine(@"      Жизни: {0}             Жизни вируса: {1}", playerHealth, enemyHealth);
                Console.WriteLine(@"      Энергия: {0}           Енергия вируса: {1}", playerEnergy, enemyEnergy);

                Console.WriteLine();

                Console.WriteLine("1. Почистить папку Temp (20 урона, -10 энергии) ");
                Console.WriteLine("2. Использовать Касперского (30 урона, -40 энергии) ");
                Console.WriteLine("3. Выпить кофе (+ 20 энергии) ");
                Console.WriteLine("4. Заказать доставку пиццы (+ 30 жизни, -20 энергии) ");

                Console.WriteLine();

                // Определение победы или поражение

                if (playerHealth <= 0)
                {
                    Console.WriteLine("Вирус победил!");
                    break;
                }

                if (enemyHealth <= 0)
                {
                    Console.WriteLine("Поздравляем!");
                    Console.WriteLine("Вы победили самый жестокий вирус на планете!");
                    break;
                }



                // Получение действия от игрока

                action = int.Parse(Console.ReadLine());

                //Описание скиллов игрока
                if (action == 1)
                {
                    if (playerEnergy >= 10)
                    {
                        enemyHealth -= 20;
                        playerEnergy -= 10;
                    }
                    else
                    {
                        Console.WriteLine("Не достаточно энергии. Ход пропущен!");
                        Console.ReadLine();
                    }  
                }

                if (action == 2)
                {
                    if (playerEnergy >= 40)
                    {
                        enemyHealth -= 30;
                        playerEnergy -= 40;
                    }
                    else
                    {
                        Console.WriteLine("Не достаточно энергии. Ход пропущен!");
                        Console.ReadLine();
                    }
                }

                if (action == 3)
                {
                    playerEnergy += 20;
                }

                if (action == 4)
                {
                    if (playerEnergy >= 20)
                    {
                        playerHealth += 30;
                        playerEnergy -= 20;
                        Console.WriteLine("Ты получил +30 к жизни!");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Не достаточно энергии. Ход пропущен!");
                        Console.ReadLine();
                    }
                }

                //Получение действий от противника

                action = rnd.Next(1, 4);

                if (enemyHealth <= 25)
                {
                    action = 2;
                }

                if (enemyEnergy <= 22)
                {
                    action = 4;
                }

                //Описание работы скиллов противника

                if (action ==1)
                {
                    if (enemyEnergy >= 12)
                    {
                        playerHealth -= 25;
                        enemyEnergy -= 12;
                        Console.WriteLine("Ты получил 25 урона!");
                        Console.ReadLine();
                    }
                }
 

                if (action == 2)
                {
                    enemyHealth += 10;
                }

                if (action == 3)
                {
                    if (enemyEnergy >= 20)
                    {
                        playerHealth -= 25;
                        enemyEnergy -= 20;
                        Console.WriteLine("Ты получил 25 урона!");
                        Console.ReadLine();
                    }
                }

                if (action == 4)
                {
                    enemyEnergy += 10;
                    Console.WriteLine("Осторожно, вирус накапливает енергию! + 10");
                    Console.ReadLine();
                }
            }
            Console.ReadKey();
        }
    }
}
