
using System;
using Xamarin.Forms;
using static XamTrainKolkata.MainMenu;

namespace XamTrainKolkata
{
    public partial class MasterDetailEx : MasterDetailPage
    {
        public MasterDetailEx()
        {
            InitializeComponent();
            MenuPage.ListView.ItemSelected += OnItemSelected;
        }
        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as AppMenuItem;
            if (item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                MenuPage.ListView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}
