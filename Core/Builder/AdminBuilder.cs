namespace Core.Builder
{
    public class AdminBuilder : UserBuilder
    {
        protected override void SetAdminRight()
        {
            User.IsAdmin = true;
        }

        protected override void SetCallRight()
        {
            User.CanMakeOutgoingCalls = true;
        }
    }
}