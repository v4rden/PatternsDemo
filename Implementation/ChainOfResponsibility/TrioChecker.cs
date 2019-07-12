namespace Implementation.ChainOfResponsibility
{
    using Core.ChainOfResponsibility;

    public class TrioChecker : ICombinationChecker, IMessageHandler<bool, ICombination>
    {
        public bool CheckCombination(ICombination combination)
        {
            return HandleMessage(combination);
        }

        public bool HandleMessage(ICombination input)
        {
            var numberOfMathes = 0;
            foreach (var i in input.Get())
            {
                if (i == 3)
                    numberOfMathes++;
            }

            return numberOfMathes == 3;
        }
    }
}