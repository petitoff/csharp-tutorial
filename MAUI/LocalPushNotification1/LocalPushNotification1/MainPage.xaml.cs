using Plugin.LocalNotification;

namespace LocalPushNotification1;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        var notification = new NotificationRequest
        {
            NotificationId = 0,
            Title = "Test",
            Description = "Test",
            Schedule =
            {
                NotifyTime = DateTime.Now.AddSeconds(10) // schedule notification
			}
        };
        await NotificationCenter.Current.Show(notification);
    }
}

