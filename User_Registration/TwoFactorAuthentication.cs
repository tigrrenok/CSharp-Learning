using static Stepik.Program;

namespace Stepik
{
    public class TwoFactorAuthentication
    { 
        public UserManager userManager { get; }

        public TwoFactorAuthentication(UserManager userManager)
        { this.userManager = userManager;}

        private void SendCode(Object user, UserRegisteredEventArgs userargs)
        {
            int code = CodeGenerator.Get();
            Console.WriteLine($"Код подтверждения: {code} отправлен на почту: {userargs.Email}");
        }

        public void TurnOn()
        {
            userManager.UserRegistered += SendCode;
        }
        public void TurnOff()
        {
            userManager.UserRegistered -= SendCode;
        }
    }
}