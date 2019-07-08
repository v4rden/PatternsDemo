namespace Core.ChainOfResponsibility
{
    public interface ICombinationChecker
    {
        bool CheckCombination(ICombination combination);
    }
}