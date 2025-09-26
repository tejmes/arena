using Arena.Core;

namespace Arena.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Arena";

            Console.WriteLine("Enter the hero's name:");
            string name = Console.ReadLine();

            Sword sword = new Sword(20);
            Hero hero = new Hero(name, 100, 10, 20, sword);

            List<IDamageable> enemies = new List<IDamageable>
            {
                new Dragon("Smaug", 250, 10, 0),
                new Wolf("Wolf", 50, 5, 0),
                new Chest("Chest", 25)
            };

            RunGame(hero, enemies);
        }
        
        static void RunGame(Hero hero, List<IDamageable> enemies)
        {
            while (hero.IsAlive() && enemies.Count > 0)
            {
                IDamageable target = SelectTarget(enemies);
                int attackValue = hero.Attack(target);
                Console.WriteLine($"You did {attackValue} damage");
                if (target.Health <= 0)
                {
                    enemies.Remove(target);
                    Console.WriteLine($"{target.Name} was killed");
                }
                Console.ReadKey();
            }
        }

        static IDamageable SelectTarget(List<IDamageable> enemies)
        {
            Console.CursorVisible = false;

            int index = 0;

            ConsoleKey key;
            do
            {
                Console.Clear();
                Console.WriteLine("Choose your target:");

                for (int i = 0; i < enemies.Count; i++)
                {
                    string prefix = (i == index) ? "> " : "  ";
                    Console.WriteLine($"{prefix}{i + 1}. {enemies[i].ToString()}");
                }

                ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);
                key = keyInfo.Key;

                if (key == ConsoleKey.UpArrow) index = (index - 1 + enemies.Count) % enemies.Count;
                else if (key == ConsoleKey.DownArrow) index = (index + 1) % enemies.Count;

            } while (key != ConsoleKey.Enter);

            return enemies[index];
        }
    }
}
