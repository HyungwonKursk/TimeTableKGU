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
using TimeTableKGU.Web.Services;

namespace TimeTableKGU.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TimeTablePage : ContentPage
    {
        Grid grid;
        public Button Mon { get; set; }
        public Button Tue { get; set; }
        public Button Wed { get; set; }
        public Button Thu { get; set; }
        public Button Fri { get; set; }
        public Button Sat { get; set; }
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
            Mon = new Button { Text = "ПОНЕДЕЛЬНИК" };
            Tue = new Button { Text = "ВТОРНИК" };
            Wed = new Button { Text = "СРЕДА" };
            Thu = new Button { Text = "ЧЕТВЕРГ" };
            Fri = new Button { Text = "ПЯТНИЦА" };
            Sat = new Button { Text = "СУББОТА" };
            ScrollView scrollView = new ScrollView { Content = grid };
            // Build the page.
            stackLayout.Children.Add(scrollView);

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

        }

         void picker_SelectedIndexChanged(object sender, EventArgs e)
        {

            int x = 0;int y = 0;

            if (picker.SelectedIndex == -1)
            {
                DependencyService.Get<IToast>().Show("Ошибка");
            }
            else

            if (picker.Items[picker.SelectedIndex] == "Числитель")
            {
                grid.Children.Clear();

                #region Понедельник
                grid.Children.Add(Mon, x + 1, y);
                var Day = from timatable in TimeTableData.TimeTables
                          where timatable.Parity == "Числитель"
                          where timatable.Week_day == "Понедельник"
                          select timatable;
                y++;
                foreach (TimeTable timetables in Day)
                {
                    grid.Children.Add(new Label { Text = timetables.Time, HorizontalTextAlignment = TextAlignment.Center }, x, y);
                    x++;
                    grid.Children.Add(new Label
                    {
                        Text = timetables.Subject + " " +
                        timetables.Name_Group,
                        // HorizontalTextAlignment = TextAlignment.Center
                    }, x, y);
                    x++;
                    if (timetables.Room_Number == 0)
                    {

                        grid.Children.Add(new Label { Text = Convert.ToString(timetables.Link), HorizontalTextAlignment = TextAlignment.Center }, x, y);
                    }
                    else
                        grid.Children.Add(new Label { Text = Convert.ToString(timetables.Room_Number), HorizontalTextAlignment = TextAlignment.Center }, x, y);

                    x++;
                    y++; x = 0;
                }
                #endregion

                #region Вторник
                grid.Children.Add(Tue, x + 1, y);
                Day = from timatable in TimeTableData.TimeTables
                      where timatable.Parity == "Числитель"
                      where timatable.Week_day == "Вторник"
                      select timatable;
                y++;
                foreach (TimeTable timetables in Day)
                {
                    grid.Children.Add(new Label { Text = timetables.Time, HorizontalTextAlignment = TextAlignment.Center }, x, y);
                    x++;
                    grid.Children.Add(new Label
                    {
                        Text = timetables.Subject + " " +
                        timetables.Name_Group,
                        // HorizontalTextAlignment = TextAlignment.Center
                    }, x, y);
                    x++;
                    if (timetables.Room_Number == 0)
                        grid.Children.Add(new Label { Text = Convert.ToString(timetables.Link), HorizontalTextAlignment = TextAlignment.Center }, x, y);

                    else
                        grid.Children.Add(new Label { Text = Convert.ToString(timetables.Room_Number), HorizontalTextAlignment = TextAlignment.Center }, x, y);

                    x++;
                    y++; x = 0;
                }
                #endregion
                #region Среда
                grid.Children.Add(Wed, x + 1, y);
                Day = from timatable in TimeTableData.TimeTables
                      where timatable.Parity == "Числитель"
                      where timatable.Week_day == "Среда"
                      select timatable;
                y++;
                foreach (TimeTable timetables in Day)
                {
                    grid.Children.Add(new Label { Text = timetables.Time, HorizontalTextAlignment = TextAlignment.Center }, x, y);
                    x++;
                    grid.Children.Add(new Label
                    {
                        Text = timetables.Subject + " " +
                        timetables.Name_Group,
                        //HorizontalTextAlignment = TextAlignment.Center
                    }, x, y);
                    x++;
                    if (timetables.Room_Number == 0)
                        grid.Children.Add(new Label { Text = Convert.ToString(timetables.Link), HorizontalTextAlignment = TextAlignment.Center }, x, y);

                    else
                        grid.Children.Add(new Label { Text = Convert.ToString(timetables.Room_Number), HorizontalTextAlignment = TextAlignment.Center }, x, y);
                    x++;
                    y++; x = 0;
                }
                #endregion
                #region Четверг
                grid.Children.Add(Thu, x + 1, y);
                Day = from timatable in TimeTableData.TimeTables
                      where timatable.Parity == "Числитель"
                      where timatable.Week_day == "Четверг"
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
                    if (timetables.Room_Number == 0)
                        grid.Children.Add(new Label { Text = Convert.ToString(timetables.Link), HorizontalTextAlignment = TextAlignment.Center }, x, y);

                    else
                        grid.Children.Add(new Label { Text = Convert.ToString(timetables.Room_Number), HorizontalTextAlignment = TextAlignment.Center }, x, y);
                    x++;
                    y++; x = 0;
                }
                #endregion
                #region Пятница
                grid.Children.Add(Fri, x + 1, y);
                Day = from timatable in TimeTableData.TimeTables
                      where timatable.Parity == "Числитель"
                      where timatable.Week_day == "Пятница"
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
                    if (timetables.Room_Number == 0)
                        grid.Children.Add(new Label { Text = Convert.ToString(timetables.Link), HorizontalTextAlignment = TextAlignment.Center }, x, y);

                    else
                        grid.Children.Add(new Label { Text = Convert.ToString(timetables.Room_Number), HorizontalTextAlignment = TextAlignment.Center }, x, y);
                    x++;
                    y++; x = 0;
                }
                #endregion
                #region Суббота
                grid.Children.Add(Sat, x + 1, y);
                Day = from timatable in TimeTableData.TimeTables
                      where timatable.Parity == "Числитель"
                      where timatable.Week_day == "суббота"
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
                    if (timetables.Room_Number == 0)
                        grid.Children.Add(new Label { Text = Convert.ToString(timetables.Link), HorizontalTextAlignment = TextAlignment.Center }, x, y);

                    else
                        grid.Children.Add(new Label { Text = Convert.ToString(timetables.Room_Number), HorizontalTextAlignment = TextAlignment.Center }, x, y);
                    x++;
                    y++; x = 0;
                }
                #endregion






            }
            else
            if (picker.Items[picker.SelectedIndex] == "Знаменатель")
            {
                grid.Children.Clear();

                #region Понедельник
                grid.Children.Add(Mon, x + 1, y);
                var Day = from timatable in TimeTableData.TimeTables
                          where timatable.Parity == "Знаменатель"
                          where timatable.Week_day == "Понедельник"
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
                grid.Children.Add(Tue, x + 1, y);
                Day = from timatable in TimeTableData.TimeTables
                      where timatable.Parity == "Знаменатель"
                      where timatable.Week_day == "Вторник"
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
                #region Среда
                grid.Children.Add(Wed, x + 1, y);
                Day = from timatable in TimeTableData.TimeTables
                      where timatable.Parity == "Знаменатель"
                      where timatable.Week_day == "Среда"
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
                #region Четверг
                grid.Children.Add(Thu, x + 1, y);
                Day = from timatable in TimeTableData.TimeTables
                      where timatable.Parity == "Знаменатель"
                      where timatable.Week_day == "Четверг"
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
                #region Пятница
                grid.Children.Add(Fri, x + 1, y);
                Day = from timatable in TimeTableData.TimeTables
                      where timatable.Parity == "Знаменатель"
                      where timatable.Week_day == "Пятница"
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
                #region Суббота
                grid.Children.Add(Sat, x + 1, y);
                Day = from timatable in TimeTableData.TimeTables
                      where timatable.Parity == "Знаменатель"
                      where timatable.Week_day == "Суббота"
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
        }
    }
}