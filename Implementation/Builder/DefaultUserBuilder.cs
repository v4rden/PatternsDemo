namespace Implementation.Builder.Abstract
{
    public class DefaultUserBuilder : UserBuilder
    {
        protected override void SetAdminRight()
        {
            User.IsAdmin = false;
        }

        protected override void SetCallRight()
        {
            User.CanMakeOutgoingCalls = true;
        }
    }
}