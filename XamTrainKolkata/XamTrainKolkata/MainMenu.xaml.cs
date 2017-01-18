using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamTrainKolkata
{
    public partial class MainMenu : ContentPage
    {
        public ListView ListView { get { return lstMenuItems; } }

        public MainMenu()
        {
            InitializeComponent();
            var vMenuItems = new List<AppMenuItem>();
            vMenuItems.Add(new AppMenuItem
            {
                Title = "TabbedEx",
                IconSource = "Cloud.png",
                TargetType = typeof(TabbedEx)
            });
            vMenuItems.Add(new AppMenuItem
            {
                Title = "Absolute Frame",
                IconSource = "Sun.png",
                TargetType = typeof(AbsFrameEx)
            });
            vMenuItems.Add(new AppMenuItem
            {
                Title = "Frame Example",
                IconSource = "Cloud.png",
                TargetType = typeof(FrameEx)
            });
            vMenuItems.Add(new AppMenuItem
            {
                Title = "Grid Example",
                IconSource = "Sun.png",
                TargetType = typeof(GridEx)
            });

            lstMenuItems.ItemsSource = vMenuItems;
        }

        public class AppMenuItem
        {
            public string Title { get; set; }

            public string IconSource { get; set; }

            public Type TargetType { get; set; }
        }
    }
}
