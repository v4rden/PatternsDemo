namespace Core.ChainOfResponsibility
{
    using Abstract;

    public class DuoChecker : ICombinationChecker, IMessageHandler<bool, ICombination>
    {
        public bool CheckCombination(ICombination combination)
        {
            return HandleMessage(combination);
        }

        public bool HandleMessage(ICombination input)
        {
            var numberOfMatches = 0;
            foreach (var i in input.Get())
            {
                if (i == 2)
                    numberOfMatches++;
            }

            return numberOfMatches == 2;
        }
    }
}