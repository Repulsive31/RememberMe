using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BelajarYok
{
    public partial class App : Application
    {
        private static Database db;
        public static Database MyDatabase
        {
            get
            {
                if (db == null)
                {
                    db = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                        "MyStore.db3"));
                }
                return db;
            }
        }
        public App()
        {
            InitializeComponent();
            Color WarnaItemGajelas = Color.FromHex("#2b2c30");

            MainPage = new NavigationPage(new MainPage())
            {
                BarBackgroundColor = WarnaItemGajelas,
                BarTextColor = Color.White
            };
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
