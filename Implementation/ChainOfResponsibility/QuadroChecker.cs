namespace Implementation.ChainOfResponsibility
{
    using Core.ChainOfResponsibility;

    public class QuadroChecker : ICombinationChecker, IMessageHandler<bool, ICombination>
    {
        public bool CheckCombination(ICombination combination)
        {
            return HandleMessage(combination);
        }

        public bool HandleMessage(ICombination combination)
        {
            foreach (var i in combination.Get())
            {
                if (i != 4)
                    return false;
            }

            return true;
        }
    }
}