namespace Implementation.Command
{
    using System.Collections;
    using System.Collections.Generic;

    public class Repo : IRepo
    {
        private static IRepo _repo;
        private readonly List<string> _data;

        private Repo()
        {
            _data = new List<string>();
        }

        public static IRepo GetInstance()
        {
            if (_repo != null)
            {
                return _repo;
            }

            _repo = new Repo();
            return _repo;
        }

        public void Add(string itemToAdd)
        {
            _data.Add(itemToAdd);
        }

        public void Remove(string itemToRemove)
        {
            _data.Remove(itemToRemove);
        }
    }
}