namespace Phoneword;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    string translatedNumber;

    private void OnTranslate(object sender, EventArgs e)
	{
		string enteredNumber = PhoneNumberText.Text;
		translatedNumber = Phoneword.PhonewordTranslator.ToNumber(enteredNumber);

		if (!string.IsNullOrEmpty(enteredNumber))
		{
            CallButton.IsEnabled = true;
            CallButton.Text = "Call " + translatedNumber;
        }
		else
		{
            CallButton.IsEnabled = false;
            CallButton.Text = "Call";
        }
	}

    async void OnCall(object sender, System.EventArgs e)
    {
        if (await this.DisplayAlert(
        "Dial a Number",
        "Would you like to call " + translatedNumber + "?",
        "Yes",
        "No"))
        {
            // TODO: dial the phone
        }
    }
}

