namespace Implementation.Adapter
{
    using System;
    using Core.Adapter;

    public class ConcreteAdapter : Adapter<StringAdaptee>, IConcreteAdapter
    {
        public ConcreteAdapter(StringAdaptee adaptee) : base(adaptee)
        {
        }

        public char ToUpper(char c)
        {
            return AdaptedOperation<char, char>(c);
        }

        protected override TReturnValue AdaptedOperation<TReturnValue, TInputParameter>(TInputParameter param)
        {
            var result = Adaptee.ToUpper(param.ToString());
            return (TReturnValue) Convert.ChangeType(result, typeof(TReturnValue));
        }
    }
}