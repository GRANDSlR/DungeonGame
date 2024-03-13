using DungeonGame;

namespace Models
{
    abstract public class Event
    {
        public bool IsActive { get; set; } = true;

        public void Activate() => IsActive = true;
        public void EndEvent() => IsActive = false;

        abstract public void EventBody(Player player);
    }
}
