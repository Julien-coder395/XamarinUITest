using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace UITest2.Pages
{
    public class AboutPage : BasePage
    {
        // Trait : permet de vérifier qu'on est sur la bonne page. 
        protected override PlatformQuery Trait => new PlatformQuery
        {
            Android = x => x.Marked("NoResourceEntry-32"),
            iOS = x => x.Marked("NoResourceEntry-32")
        };

        private Query LearnMoreButton;

        public AboutPage()
        {
            LearnMoreButton = x => x.Marked("Learn more");
        }

        public AboutPage TapLearnMoreButton()
        {

            app.WaitForElement(LearnMoreButton);
            app.Tap(LearnMoreButton);
            return this;
        }
    }
}
