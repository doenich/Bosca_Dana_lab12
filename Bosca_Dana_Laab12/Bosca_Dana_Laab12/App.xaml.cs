using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Bosca_Dana_Laab12.Data;
using Bosca_Dana_Laab12.Models;

namespace Bosca_Dana_Laab12
{
    public partial class App : Application
    {
        public static ShoppingListDatabase Database { get; private set; }
        public App()
        {
            Database = new ShoppingListDatabase(new RestService());
            MainPage = new NavigationPage(new ListEntryPage());

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
