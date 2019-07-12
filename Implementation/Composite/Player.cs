namespace Implementation.Composite
{
    using System;

    public class Player : Party<Player>
    {
        public string Name { get; }
        public int Gold { get; set; }

        public Player(string name, int startGold)
        {
            Name = name;
            Gold = startGold;
            Individuals.Add(this); //will it work?
        }

        public override void GetStats()
        {
            foreach (Player individual in Individuals)
            {
                PerformAction<string>(
                    s => { Console.WriteLine($"Player {individual.Name} has {individual.Gold} gold."); },
                    null);
            }
        }

        public override void SplitLoot(int gold)
        {
            var share = gold / Individuals.Count;
            var leftOver = gold % Individuals.Count;

            foreach (Player individual in Individuals)
            {
                PerformAction(
                    g => { individual.Gold += g; },
                    share + leftOver);
                leftOver = 0;
            }
        }
    }
}