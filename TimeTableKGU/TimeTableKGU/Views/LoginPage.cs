using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TimeTableKGU.Views
{
    public partial class AuthorizationPage : ContentPage
    {
        public class LoginControls
        {
            public Image LogoImage { get; set; }
            public Label TitleLab { get; set; }
            public Entry LoginBox { get; set; }
            public Entry PasswBox { get; set; }
            public Button LoginBtn { get; set; }
            public Button RegisBtn { get; set; }

            public LoginControls()
            {
                LogoImage = new Image
                {
                    Source = "Logotip.jpg"
                };
                TitleLab = new Label
                {
                    Text = "Вход",
                    Style = Device.Styles.TitleStyle,
                    HorizontalOptions = LayoutOptions.Center,
                };

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
                    IsPassword = true,
                    ClearButtonVisibility = ClearButtonVisibility.WhileEditing,
                    Style = Device.Styles.BodyStyle,
                    HorizontalOptions = LayoutOptions.Fill
                };

                LoginBtn = new Button
                {
                    Text = "Войти",
                    //BackgroundColor = Color.FromHex("#BFD9B6"),
                    TextColor = Color.White,
                    BorderColor = Color.Black,
                };
                RegisBtn = new Button
                {
                    Text = "Зарегистрироваться",
                    //BackgroundColor = Color.FromHex("#BFD9B6"),
                    TextColor = Color.White,
                    BorderColor = Color.Black,
                };
            }

            public StackLayout SetContent()
            {
                StackLayout stackLayout = new StackLayout();
                stackLayout.Margin = 20;

                stackLayout.Children.Add(new BoxView { VerticalOptions = LayoutOptions.CenterAndExpand });
                stackLayout.Children.Add(LogoImage);
                //stackLayout.Children.Add(TitleLab);
                stackLayout.Children.Add(LoginBox);
                stackLayout.Children.Add(PasswBox);
                stackLayout.Children.Add(LoginBtn);
                stackLayout.Children.Add(RegisBtn);
                stackLayout.Children.Add(new BoxView { VerticalOptions = LayoutOptions.CenterAndExpand });

                return stackLayout;
            }
        }

        private LoginControls LoginPage;
        public void GetLoginPage()
        {
            Title = "Войти";

            LoginPage = new LoginControls();

            //LoginPage.LoginBtn.Clicked += LoginIn;
            LoginPage.RegisBtn.Clicked += ToRegistrationPage;

            this.Content = LoginPage.SetContent();
        }
        private void ToRegistrationPage(object sender, EventArgs e)
        {
            /*if (isLoading)
            {
                DependencyService.Get<IToast>().Show("Дождитесь окончания загрузки");
                return;
            }*/
            GetRegistrationPage();
        }

    }
}
