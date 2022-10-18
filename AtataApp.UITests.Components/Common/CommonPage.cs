using Atata;

namespace AtataUITestsQA
{
    using _ = CommonPage;

    [Url("")]
    public class CommonPage : Page<_>
    {
        [FindByCss("a.cookies-btn")]
        public Link<_> GotItCookies { get; private set; }





    }
}
