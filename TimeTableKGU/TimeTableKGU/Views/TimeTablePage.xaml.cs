using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TimeTableKGU.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TimeTablePage : ContentPage
    {
        public TimeTablePage()
        {
            InitializeComponent();
            Grid grid = new Grid
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                RowDefinitions =
                {
                    new RowDefinition { Height = 50 },
                    new RowDefinition { Height = 40 },
                    new RowDefinition { Height = 40 },
                    new RowDefinition { Height = 40 },
                    new RowDefinition { Height = 40 },
                    new RowDefinition { Height = 50},
                    new RowDefinition { Height = 40 },
                    new RowDefinition { Height = 40 },
                    new RowDefinition { Height = 40 },
                    new RowDefinition { Height = 50 },
                    new RowDefinition { Height = 40 },
                    new RowDefinition { Height = 40 },
                    //new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    //new RowDefinition { Height = new GridLength(100, GridUnitType.Absolute) }
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = GridLength.Auto },
                    new ColumnDefinition { Width = 250 },
                    new ColumnDefinition { Width = 50 }
                }

            };
            
            ScrollView scrollView = new ScrollView { Content = grid };
            // Build the page.
            stackLayout.Children.Add(scrollView);

        }
        void picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = 0;
        }
    }
}