using Plugin.LocalNotification;

namespace LocalPushNotification1;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		var notification = new NotificationRequest
		{
			BadgeNumber = 1,
			Description = "Text description",
			Title = "Notification!",
			ReturningData = "Dummy Data",
			Schedule =
			{
				NotifyTime = DateTime.Now.AddSeconds(5)
			}
        };
		NotificationCenter.Current.Show(notification);
	}
}

