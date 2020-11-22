using NUnit.Framework;
using UnitTestExample.Controllers;

namespace UnitTestExample.Test
{

    public class AccountControllerTestFixture
    {



       

        public void TestValidateEmail(string email, bool expectedResult)
        {
            var accountController = new AccountController();
            var actualResult = accountController.ValidateEmail(email);
            Assert.AreEqual(expectedResult, actualResult);
        }
        
        [

               Test,
               TestCase("abcdefgh", false),
               TestCase("ABCD1234", false),
               TestCase("abcd1234", false),
               TestCase("abcd123", false),
               TestCase("Abcd1234", true)


          ]


  
        public void TestValidatePassword(string password, bool expectedResult)
        { 
        
        
        }
    }
}
