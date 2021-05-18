using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTableKGU.Interface;
using TimeTableKGU.Data;
using TimeTableKGU.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TimeTableKGU.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TimeTablePage : ContentPage
    {
        Grid grid;
        public TimeTablePage()
        {
            InitializeComponent();
            grid = new Grid
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                RowDefinitions =
                {
                    new RowDefinition { Height = 50 },
                    new RowDefinition { Height = 60 },
                    new RowDefinition { Height = 60 },
                    new RowDefinition { Height = 60 },
                    new RowDefinition { Height = 60 },
                    new RowDefinition { Height = 60},
                    new RowDefinition { Height = 60 },
                    new RowDefinition { Height = 60 },
                    new RowDefinition { Height = 60 },
                    new RowDefinition { Height = 60 },
                    new RowDefinition { Height = 60 },
                    new RowDefinition { Height = 60 },
                    //new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    //new RowDefinition { Height = new GridLength(100, GridUnitType.Absolute) }
                },
              
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = 45},
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
            int x = 0;int y = 0;
            var Day = from timatable in TimeTableData.TimeTables
                      where timatable.Parity == "числитель"
                      select timatable;

            if (picker.SelectedIndex == -1)
            {
                DependencyService.Get<IToast>().Show("Ошибка");
            }
            else

            if (picker.Items[picker.SelectedIndex] == "Числитель")
            {
                #region Понедельник
                grid.Children.Add(new Label { Text = "Понедельник", HorizontalTextAlignment = TextAlignment.Center, }, x+1, y);
                Day = from timatable in Day
                      where timatable.Week_day == "понедельник"
                      select timatable;
                y++;
                foreach (TimeTable timetables in Day)
                {
                    grid.Children.Add(new Label { Text = timetables.Time }, x, y);
                    x++;
                    grid.Children.Add(new Label
                    {
                        Text = timetables.Subject + " " +
                        timetables.Name_Group
                    }, x, y);
                    x++;
                    grid.Children.Add(new Label { Text = Convert.ToString(timetables.Room_Number) }, x, y);
                    x++;
                    y++; x = 0;
                }
                #endregion

                #region Вторник
                grid.Children.Add(new Label { Text = "Вторник", HorizontalTextAlignment = TextAlignment.Center, }, x + 1, y);
                Day = from timatable in TimeTableData.TimeTables
                      where timatable.Week_day == "вторник"
                      select timatable;
                y++;
                foreach (TimeTable timetables in Day)
                {
                    grid.Children.Add(new Label { Text = timetables.Time }, x, y);
                    x++;
                    grid.Children.Add(new Label
                    {
                        Text = timetables.Subject + " " +
                        timetables.Name_Group
                    }, x, y);
                    x++;
                    grid.Children.Add(new Label { Text = Convert.ToString(timetables.Room_Number) }, x, y);
                    x++;
                    y++; x = 0;
                }
                #endregion




            }
            else
            if (picker.Items[picker.SelectedIndex] == "Знаменатель")
            {
                DependencyService.Get<IToast>().Show("Знаменатель");
            }
        }
    }
}