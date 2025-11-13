namespace Stepik
{
    public class Advertisement
    { 
        private UserManager userManager { get; }
        public Advertisement(UserManager userManager)
        { this.userManager = userManager; }

        private void SendAds(Object user, UserRegisteredEventArgs userargs)
        {
            Console.WriteLine($"Последний день приобрести курс по скидке. Отправлено на почту {userargs.Email}");
        }

        public void TurnOn()
        {
            userManager.UserRegistered += SendAds;
        }
        public void TurnOff()
        {
            userManager.UserRegistered -= SendAds;
        }
    }
}