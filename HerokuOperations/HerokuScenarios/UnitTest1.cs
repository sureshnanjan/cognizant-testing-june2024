using HerokuOperations;
using HerokuWebApplication;
namespace HerokuScenarios
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void HerokuHomepageTitleIsOK()
        {
            IHomePageOperations aut = new HomePage();
            /// Arrange
            string expectedTitle = "Welcome to the-internet";
            /// Act
            string actualTitle = aut.getTitle();
            /// Assert
            /// 
            Assert.AreEqual(expectedTitle, actualTitle);
        }
    }
}