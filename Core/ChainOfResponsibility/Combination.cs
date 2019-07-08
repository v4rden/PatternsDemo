namespace Core.ChainOfResponsibility
{
    using System.Collections.Generic;
    using System.Linq;

    public class Combination : ICombination
    {
        private List<int> _list;

        public Combination(List<int> list)
        {
            _list = list;
        }

        public List<int> Get()
        {
            return _list;
        }

        public int GetFirst()
        {
            return _list[0];
        }

        public int GetSecond()
        {
            return _list[1];
        }

        public int GetThird()
        {
            return _list[2];
        }

        public int GetForth()
        {
            return _list[3];
        }
    }
}