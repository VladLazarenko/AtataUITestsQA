using Atata;
using _ = AtataUITestsQA.Components.LoginDashboard;

namespace AtataUITestsQA.Components
{
    [Url("login")]
    public class LoginDashboard : Page<_>
    {
        [FindById("Email")]
        public EmailInput<_> Email { get; private set; }

        [FindById("Password")]
        public PasswordInput<_> Password { get; private set; }

        [FindById("kt_login_signin_submit")]
        public Button<_> SignIn { get; private set; }
    }
}
