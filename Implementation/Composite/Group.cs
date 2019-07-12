namespace Implementation.Composite
{
    using System;
    using System.Collections.Generic;

    public class Group : Party<Player>
    {
        public string Name { get; }

        public int Gold
        {
            get
            {
                var total = 0;
                foreach (var individual in Individuals)
                {
                    total += individual.Gold;
                }

                return total;
            }
        }

        public Group(string name)
        {
            Name = name;
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