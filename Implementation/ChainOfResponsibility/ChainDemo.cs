namespace Implementation.ChainOfResponsibility
{
    using System.Collections.Generic;

    public class ChainDemo
    {
        private readonly List<ICombinationChecker> _checkers;

        public ChainDemo()
        {
            _checkers = new List<ICombinationChecker>
            {
                new QuadroChecker(),
                new TrioChecker(),
                new DuoChecker()
            };
        }

        public string Demo(ICombination combination)
        {
            bool combinationChecked = false;

            foreach (var combinationChecker in _checkers)
            {
                combinationChecked = combinationChecker.CheckCombination(combination);

                if (combinationChecked == true)
                {
                    return "Combination checked";
                }
            }

            return "No checker was able to process combination";
        }
    }
}