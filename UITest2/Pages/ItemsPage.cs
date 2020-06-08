
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace UITest2.Pages
{
    public class ItemsPage : BasePage
    {
        // Trait : permet de vérifier qu'on est sur la bonne page. 
        protected override PlatformQuery Trait => new PlatformQuery
        {
            Android = x => x.Marked("NoResourceEntry-18"),
            iOS = x => x.Marked("NoResourceEntry-18")
        };

        private Query List, ViewCell, AddButton, MenuHamburgerButton, AboutButton;

        public ItemsPage()
        {
            List = x => x.Class("ListView");
            ViewCell = x => x.Class("ItemContentView").Index(0);
            AddButton = x => x.Marked("AddButton");
            MenuHamburgerButton = x => x.Marked("OK");
            AboutButton = x => x.Marked("About");
        }

        // Méthode fluent qui permet "d'enchainer". 
        public ItemsPage DisplayItemPage()
        {
            app.WaitForElement(List);
            return this;
        }

        public ItemsPage DisplayAddItemPage()
        {
            app.WaitForElement(AddButton);
            app.Tap(AddButton);
            return this;
        }

        public ItemsPage SelectAboutMenuItem()
        {
            app.WaitForElement(MenuHamburgerButton);
            app.Tap(MenuHamburgerButton);
            app.WaitForElement(AboutButton);
            app.Tap(AboutButton);
            return this;
        }

        public ItemsPage SelectFirstItem()
        {
            app.WaitForElement(ViewCell);
            app.Tap(ViewCell);
            return this;
        }
    }
}
