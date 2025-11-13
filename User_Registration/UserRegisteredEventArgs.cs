namespace Stepik
{
    public class UserRegisteredEventArgs : EventArgs
    { 
        public string Email { get; }
        public UserRegisteredEventArgs(string email)
        {
            Email = email;
        }
    }
}