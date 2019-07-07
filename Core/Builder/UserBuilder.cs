namespace Core.Builder
{
    using Abstract;

    public abstract class UserBuilder : Builder<User>
    {
        protected User User;

        public UserBuilder()
        {
            User = new User();
        }

        public override void Create()
        {
            SetAdminRight();
            SetCallRight();
        }

        public override User Get()
        {
            return User;
        }

        protected abstract void SetAdminRight();

        protected abstract void SetCallRight();
    }
}