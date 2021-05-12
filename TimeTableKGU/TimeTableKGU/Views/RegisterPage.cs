using TimeTableKGU.Models;

using System;
using System.Collections.Generic;
using System.Text;

using Xamarin.Forms;

namespace TimeTableKGU.Views
{
    public partial class AuthorizationPage : ContentPage
    {
        public class RegisrationContrioolers
        {
            public Label labelMessage { get; set; }
            public Entry NameBox { get; set; }
            public Entry LoginBox { get; set; }
            public Entry PasswBox { get; set; }
            public Entry PasswCheckBox { get; set; }
            public Button RegisBtn { get; set; }
            public Button LoginBtn { get; set; }
            public Picker TypePick { get; set; }
            public Picker GroupPick { get; set; }
            public Entry DepartBox { get; set; }

            public RegisrationContrioolers()
            {

                labelMessage = new Label
                {
                    Text = "Регистрация",
                    Style = Device.Styles.TitleStyle,
                    HorizontalOptions = LayoutOptions.Center,
                    TextColor = Color.Black
                };

                NameBox = new Entry
                {
                    Text = "",
                    Placeholder = "ФИО пользователя",
                    Keyboard = Keyboard.Default,
                    TextColor = Color.Black,
                    PlaceholderColor = Color.Black,
                    ClearButtonVisibility = ClearButtonVisibility.WhileEditing,
                    Style = Device.Styles.BodyStyle,
                    HorizontalOptions = LayoutOptions.Fill
                };
                TypePick = new Picker { Title = "Должность", TextColor = Color.Black };
                TypePick.Items.Add("Студент");
                TypePick.Items.Add("Преподаватель");

                GroupPick = new Picker { Title = "Группа", TextColor = Color.Black };
                GroupPick.Items.Add("113");
                GroupPick.Items.Add("213");
                GroupPick.Items.Add("313");
                GroupPick.Items.Add("413");

                LoginBox = new Entry
                {
                    Text = "",
                    Placeholder = "Логин",
                    Keyboard = Keyboard.Default,
                    TextColor = Color.Black,
                    PlaceholderColor = Color.Black,
                    ClearButtonVisibility = ClearButtonVisibility.WhileEditing,
                    Style = Device.Styles.BodyStyle,
                    HorizontalOptions = LayoutOptions.Fill
                };
                PasswBox = new Entry
                {
                    Text = "",
                    Placeholder = "Пароль",
                    Keyboard = Keyboard.Default,
                    TextColor = Color.Black,
                    PlaceholderColor = Color.Black,
                    ClearButtonVisibility = ClearButtonVisibility.WhileEditing,
                    Style = Device.Styles.BodyStyle,
                    HorizontalOptions = LayoutOptions.Fill
                };
                PasswCheckBox = new Entry
                {
                    Text = "",
                    Placeholder = "Подтверждение пароля",
                    Keyboard = Keyboard.Default,
                    TextColor = Color.Black,
                    PlaceholderColor = Color.Black,
                    IsPassword = true,
                    ClearButtonVisibility = ClearButtonVisibility.WhileEditing,
                    Style = Device.Styles.BodyStyle,
                    HorizontalOptions = LayoutOptions.Fill
                };

                RegisBtn = new Button
                {
                    Text = "Зарегистрироваться",
                    BackgroundColor = Color.FromHex("#b3e5fc"),
                    TextColor = Color.Black,
                    BorderColor = Color.Black,
                };

                DepartBox = new Entry
                {
                    Text = "",
                    Placeholder = "Кафедра",
                    Keyboard = Keyboard.Default,
                    TextColor = Color.Black,
                    PlaceholderColor = Color.Black,
                    ClearButtonVisibility = ClearButtonVisibility.WhileEditing,
                    Style = Device.Styles.BodyStyle,
                    HorizontalOptions = LayoutOptions.Fill
                };
                LoginBtn = new Button
                {
                    Text = "Уже есть учетная запись",
                    BackgroundColor = Color.FromHex("#b3e5fc"),
                    TextColor = Color.Black,
                    BorderColor = Color.Black,
                };
                TypePick.SelectedIndexChanged += TypePick_Change;
            }

            private void TypePick_Change(object sender, EventArgs e)
            {
                if (TypePick.Items[TypePick.SelectedIndex] == "Студент")
                {

                    stackLayout.Children.Remove(DepartBox);
                    stackLayout.Children.Remove(LoginBtn);
                    stackLayout.Children.Remove(RegisBtn);
                    stackLayout.Children.Add(GroupPick);
                }

                else
                if (TypePick.Items[TypePick.SelectedIndex] == "Преподаватель")
                {
                    stackLayout.Children.Remove(GroupPick);
                    stackLayout.Children.Remove(LoginBtn);
                    stackLayout.Children.Remove(RegisBtn);
                    stackLayout.Children.Add(DepartBox);
                }

                stackLayout.Children.Add(RegisBtn);
                stackLayout.Children.Add(LoginBtn);
                //stackLayout.Children.Add(new BoxView { VerticalOptions = LayoutOptions.CenterAndExpand });
            }

            StackLayout stackLayout = new StackLayout();
            public ScrollView SetContent()
            {
                
                stackLayout.Margin = 20;

                stackLayout.Children.Add(new BoxView { VerticalOptions = LayoutOptions.CenterAndExpand });
                stackLayout.Children.Add(labelMessage);
                stackLayout.Children.Add(NameBox);
                stackLayout.Children.Add(TypePick);
                stackLayout.Children.Add(LoginBox);
                stackLayout.Children.Add(PasswBox);
                stackLayout.Children.Add(PasswCheckBox);
                
               

                ScrollView scroll = new ScrollView { Content = stackLayout };
                return scroll;
            }
        }

        public RegisrationContrioolers RegisrationPage;

        public void GetRegistrationPage()
        {
            Title = "Зарегистрироваться";

            RegisrationPage = new RegisrationContrioolers();
            RegisrationPage.SetContent();
            //RegisrationPage.RegisBtn.Clicked += RegistrClient;
            RegisrationPage.LoginBtn.Clicked += ToLoginPage;

            this.Content = new ScrollView { Content = RegisrationPage.SetContent() };
        }

        private void ToLoginPage(object sender, EventArgs e)
        {
            GetLoginPage();
        }
    }
}