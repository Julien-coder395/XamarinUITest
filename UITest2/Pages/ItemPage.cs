using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace UITest2.Pages
{
    public class ItemPage : BasePage
    {

        // Trait : permet de vérifier qu'on est sur la bonne page. 
        protected override PlatformQuery Trait => new PlatformQuery
        {
            Android = x => x.Marked("New Item"),
            iOS = x => x.Marked("New Item")
        };

        private Query entryItemName, entryDescription, saveButton, cancelButton;

        public ItemPage()
        {
            entryItemName = x => x.Marked("entryItemName");
            entryDescription = x => x.Marked("entryDescription");
            saveButton = x => x.Marked("Save");
            cancelButton = x => x.Marked("Cancel");
        }

        public ItemPage EnterItemInformation(string s_itemName, string s_description)
        {
            app.WaitForElement(entryItemName);
            app.ClearText(entryItemName);
            app.EnterText(entryItemName, s_itemName);
            app.WaitForElement(entryDescription);
            app.ClearText(entryDescription);
            app.EnterText(entryDescription, s_description);
            return this;
        }

        public ItemPage SaveItem()
        {
            app.WaitForElement(saveButton);
            app.Tap(saveButton);
            return this;
        }

        public ItemPage CancelAddItem()
        {
            app.WaitForElement(cancelButton);
            app.Tap(cancelButton);
            return this;
        }
    }
}
