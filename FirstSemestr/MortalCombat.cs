using System;

namespace MortalCombat
{
    class Game
    {
        static void Main()
        {
            var player1 = new Player();
            var player2 = new Player();
           
            InputInfo(player1, 1);

            InputInfo(player2, 2);

            Console.WriteLine("\r\n");

            Console.WriteLine("Суть игры : \n 1)Игра рассчитана на двоих игроков,каждый управляет своим персонажем \n 2)В игре присутствуют случайные события(Отдых/крит/зелья) \n 3)Побеждает игрок,опустивший здоровье врага до 0)");

            while (true)
            {
                
                if (!player1.IsDead())
                {
                    Console.WriteLine("---------------------------------------------------------");
                    Console.Write("Введите силу удара 1 игрока: ");
                    TryGetBonus(player1);
                    player1.Hit(player2);
                    Console.WriteLine("Здоровье вашего врага = " + player2.Health);
                    Console.WriteLine("---------------------------------------------------------");
                }
                else
                {
                    Console.WriteLine($"{player1.Name} is dead");
                    break;
                }

                if (!player2.IsDead())
                {
                    Console.WriteLine("---------------------------------------------------------");
                    Console.Write("Введите силу удара 2 игрока: ");
                    TryGetBonus(player2);
                    player2.Hit(player1);
                    Console.WriteLine("Здоровье вашего врага = " + player1.Health);
                    Console.WriteLine("---------------------------------------------------------");
                }
                else
                {
                    Console.WriteLine($"{player2.Name} is dead");
                    break;
                }
            }

            GetStatistic(player1, player2);
        }

        static void TryGetBonus(Player player)
        {
            var damage = int.Parse(Console.ReadLine());
            int Potion;
            Random random = new Random();
            var value = random.Next(0, 9);
            var value1 = random.Next(0, 4);
            
            if (value == 0)
            {
                player.Damage = 0;
                player.Health += 10;
                Console.WriteLine("Вы устали,вам нужно восстановить немного здоровья.(+хп;-весь урон)");
            }
            else if (value < 2)
            {
                Console.WriteLine("Крит!(+урон)");
                player.Damage = damage * 2;
            }
            else if(value == 3)
            {
                Console.WriteLine("Зелье!");
                Console.WriteLine("Вы нашли неопознанное зелье в вашем рюкзаке,нажмите 1 ,чтобы использовать его или 0 для игнорирования возможности : ");
                Potion=int.Parse(Console.ReadLine());
                
                if (value1 == 0 && Potion == 1)
                {
                    Console.WriteLine("Зелье силы!Ваш урон увеличен в этом ходу!");
                    player.Damage +=20;
                }
                else if (value1 == 1 && Potion == 1)
                {
                    player.Damage = damage;
                    player.Health += 50;
                    Console.WriteLine("Зелье гиганта.Ваше здоровье немного восстановилось!");
                }
                else if (value1 == 2 && Potion == 1)
                {
                    player.Damage = damage;
                    Console.WriteLine("Вы выпили яд !");
                    player.Health -= 25;
                }
                else if (Potion==0)
                {
                    Console.WriteLine("Ничего не произошло!Игра продолжается!");
                }    
                else
                {
                    player.Damage = damage;
                    Console.WriteLine("Вы выпили колбу с обыкновенной водой,неудача!");
                }

            }
            else
            {
                player.Damage = damage;
            }

        }

        static void GetStatistic(Player player1, Player player2)
        {
            Console.WriteLine();
            player1.GetInfo();

            Console.WriteLine();
            player2.GetInfo();

            Console.ReadLine();
        }

        static void InputInfo(Player player, int playerNumber)
        {
            Console.Write($"Введите имя {playerNumber} игрока: ");
            player.Name = Console.ReadLine();
            Console.Write($"Введите здоровье {playerNumber} игрока: ");
            player.Health = int.Parse(Console.ReadLine());
        }
    }

    public class Player
    {
        public string Name { get; set;}
        public int Health { get; set; }
        public int Damage { get; set; }

        public void GetInfo()
        {
            Console.WriteLine($"Имя: {Name}\r\nХп: {Health}\r\nУрон: {Damage}");
        }

        public bool IsDead()
        {
            return Health <= 0;
        }

        public void Hit(Player enemy)
        {
            enemy.Health -= Damage;
        }

    }
}