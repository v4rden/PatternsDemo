namespace Core.ChainOfResponsibility
{
    using System.Collections.Generic;

    public interface ICombination
    {
        List<int> Get();
        int GetFirst();
        int GetSecond();
        int GetThird();
        int GetForth();
    }
}