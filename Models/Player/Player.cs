namespace DungeonGame
{
    public class Player
    {
        public int HealthPoints { get; private set; }
        public int Coins { get; private set; }

        private Player() { }

        public void GetDamage(int damage)
        {
            HealthPoints -= damage;

            if (HealthPoints < 0)
            {
                throw new Exception("Game over");
            }
        }

        public void ReduceModey(int modey)
        {
            Coins -= modey;

            if (Coins < 0)
            {
                throw new Exception("Game over");
            }
        }

        public void IncreaseModey(int coins)
            => Coins += coins;

        public void IncreaseHP(int points) 
            => HealthPoints += points;

        public static (string?, Player?) Create(int healthPoints, int coins)
        {
            if (healthPoints < 0)
            {
                return ("Invalid HealthPoints", null);
            }

            if (coins < 0)
            {
                return ("Invalid coins", null);
            }

            return (null, new Player()
            {
                HealthPoints = healthPoints,
                Coins = coins
            });
        }

        public override string ToString()
            => $"Ваша статистика - Здоровье {HealthPoints}, Говнокоинов {Coins}";
    }
}
