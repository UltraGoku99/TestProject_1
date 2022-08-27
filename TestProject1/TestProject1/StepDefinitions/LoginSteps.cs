using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject1.CommonMethodObjects;
using TechTalk.SpecFlow;

namespace TestProject1.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        LoginObjects loginobj = new LoginObjects();

        [Given(@"User is on homepage")]
        public void GivenUserIsOnHomepage()
        {
            loginobj.VerifyHome();
        }

        [When(@"User enters username")]
        public void WhenUserEntersUsername()
        {
            loginobj.EnterUsername();
        }

        [When(@"User enters Password")]
        public void WhenUserEntersPassword()
        {
            loginobj.EnterPassword();
        }

        [When(@"User click on Login Button")]
        public void WhenUserClickOnLoginButton()
        {
            loginobj.Loginbtn();
        }

        [Then(@"User should be able to see demo site")]
        public void ThenUserShouldBeAbleToSeeDemoSite()
        {
            loginobj.VerifyDemoPage();
        }

    }
}
