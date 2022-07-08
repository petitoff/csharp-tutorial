using Plugin.LocalNotification;

namespace LocalPushNotification1;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        var notification = new NotificationRequest
        {
            BadgeNumber = 1,
            Description = "Text description",
            Title = "Notification!",
            Schedule =
            {
                NotifyTime = DateTime.Now.AddSeconds(10) // schedule notification
			}
        };
        NotificationCenter.Current.Show(notification);
    }
}

