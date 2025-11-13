namespace Stepik
{
    public class UserManager
    {
        public List<User> Users { get; } = new List<User>();
        public event EventHandler<UserRegisteredEventArgs> UserRegistered;

        public void Register(User user)
        {
            Users.Add(user);
            //UserRegistered
            UserRegistered(this, new UserRegisteredEventArgs(user.Email));
        }

    }
}