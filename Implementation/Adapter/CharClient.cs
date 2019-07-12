namespace Implementation.Adapter
{
    public class CharClient
    {
        private readonly IConcreteAdapter _adapter;

        public CharClient(IConcreteAdapter adapter)
        {
            _adapter = adapter;
        }

        private char ToUpper(char c)
        {
            return _adapter.ToUpper(c);
        }
    }
}