namespace DungeonGame
{
    public class Menu
    {
        public Player player { get; set; }

        public Menu(Player playerValue) 
        {
            player = playerValue;
        }

        public void Shop()
        {
            Console.WriteLine("Нажмите 1 чтобы купить хп 1 хп - 1 говнокоин мы сегодня добрые))), 2 чтобы выйти");
            string? userAnswer = Console.ReadLine();

            switch (userAnswer)
            {
                case "1":
                {
                    if (player.Coins >= 1)
                    {
                        player.ReduceModey(1);
                        player.IncreaseHP(1);

                        Console.WriteLine("Вы приобрели 1 хп за 1 говноик капец вы лох))))");
                        Helper.PrintDevide();

                        break;
                    }

                    Console.WriteLine("Денег нет а вы держитесь");
                    break;
                }
                case "2":
                {
                    Console.WriteLine("Вы вышли из меню");
                    break;
                }
            }
        }

        public void InvokeMenu()
        {
            Console.WriteLine("Вы хотите что-нибудь купить?");
            Console.WriteLine("1 - магзин, 2 следующий ивент");

            string? userAnswer = Console.ReadLine();

            switch (userAnswer)
            {
                case "1": 
                {
                    Console.WriteLine("Вы вошли в магаз");
                    Helper.PrintDevide();

                    Shop();

                    break;
                }
                case "2":
                {
                    Console.WriteLine("Вы вышли из меню");
                    Helper.PrintDevide();

                    break;
                }
            }
        }
    }
}
