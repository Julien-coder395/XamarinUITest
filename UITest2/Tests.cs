using NUnit.Framework;
using UITest2.Pages;
using Xamarin.UITest;

namespace UITest2
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests : BaseTestFixture
    {
        public Tests(Platform platform) : base(platform)
        {
        }

        public void Repl()
        {
            if (TestEnvironment.IsTestCloud)
                Assert.Ignore("Local only");
            app.Repl();
        }

        //[Test]
        //[Category(name: "BaseTest")]
        //public void WelcomeTextIsDisplayed()
        //{
        //    AppResult[] results = app.WaitForElement(c => c.Marked("Welcome to Xamarin.Forms!"));
        //    app.Screenshot("Welcome screen.");

        //    Assert.IsTrue(results.Any());
        //}

        [Test]
        [Category(name: "BaseTest")]
        public void OpenRepl()
        {
            Repl();
        }

        [Test]
        [Category(name: "BaseTest")]
        public void DisplayAddItemPage()
        {
            new ItemsPage().DisplayAddItemPage();
            Repl();
        }

        [Test]
        [Category(name: "BaseTest")]
        public void AddItem()
        {
            var itemsPage = new ItemsPage();
            itemsPage.DisplayAddItemPage();
            var itemPage = new ItemPage();
            itemPage.EnterItemInformation("Item 1", "Cet item a été saisi automatiquement").SaveItem();
            app.Screenshot("Screenshot").CopyTo(@"C:\Users\julien.defforge\Desktop\Screenshot.png");
        }

        [Test]
        [Category(name: "BaseTest")]
        public void ButtonLearnMoreTest()
        {
            new ItemsPage().SelectAboutMenuItem();
            new AboutPage().TapLearnMoreButton();
        }

        [Test]
        [Category(name: "BaseTest")]
        public void SelectFirstItem()
        {
            new ItemsPage().SelectFirstItem();
        }
    }
}
