using DungeonGame;
using Models;
using Models.Events;

List<Event> events = new() {
    new SystemEvent(),
    new SystemEvent(),
    new SystemEvent(),
    new SystemEvent()
};

var playerCreationResult = Player.Create(10, 0);

if (playerCreationResult.Item1 != null)
{
    Console.WriteLine(playerCreationResult.Item1);
    return;
}

if (playerCreationResult.Item2 != null)
{
    try
    {
        Helper.WelcomeMessage("Dungeon Gay");
        Menu menu = new(playerCreationResult.Item2);

        Array.ForEach(events.ToArray(), eventObj => {

            Console.WriteLine(playerCreationResult.Item2);
            Helper.PrintDevide();

            eventObj.EventBody(playerCreationResult.Item2);

            Helper.PrintDevide();

            menu.InvokeMenu();

        });

        Console.WriteLine("You win!");
    }
    catch
    {
        Console.WriteLine("Game over");
    }
}
