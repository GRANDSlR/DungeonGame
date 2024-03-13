using DungeonGame;

namespace Models.Events
{

    /// <summary>
    /// Это пример описывает то как вы можете создавать 
    /// уровни в игре здесь простой код котрый
    /// просит пользователя ввести ответ на вопрос
    /// если ввёл не правильно то снимаются хп
    /// иначе добавляются говнокоины
    /// </summary>
    public class SystemEvent : Event
    {
        public string? CorrectAnswer { get; private set; } = "гитлер";

        public override void EventBody(Player player)
        {
            Console.WriteLine("Отгадай загадку. Висит груша нельзя скушать!!!");
            Console.WriteLine("За неверный ответ снимаются 1 хп");

            Helper.PrintDevide();

            while (IsActive)
            {
                string? userAnswer = Console.ReadLine();

                if (userAnswer?.ToLower() == CorrectAnswer?.ToLower()) 
                {
                    player.IncreaseModey(1);
                    EndEvent();

                    Helper.PrintDevide();
                    Console.WriteLine("Правильно!");

                    return;
                }

                player.GetDamage(1);

                Helper.PrintDevide();
                Console.WriteLine("Неверно!");

                Helper.PrintDevide();
                Console.WriteLine(player);
            }   
        }
    }
}
