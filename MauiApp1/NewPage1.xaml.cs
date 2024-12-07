namespace MauiApp1;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        //ShowMessageBox();
        CustomMsgBox();
    }

    private async void ShowMessageBox()
    {
        bool result = await DisplayAlert(
            "Confirmation",  // Title
            "Do you want to proceed?", // Message
            "Yes",           // Accept button
            "No"             // Cancel button
        );

        if (result)
        {
            await DisplayAlert("Response", "You chose Yes.", "OK");
        }
        else
        {
            await DisplayAlert("Response", "You chose No.", "OK");
        }
    }

    async void CustomMsgBox()
    {
        string opt1 = "option 1\naaa";
        string opt2 = "option 2";
        string opt3 = "option 3";
        string action = await DisplayActionSheet(
            "Choose an option",  // Title
            "Cancel",            // Cancel button
            null,                // Destruction button
            opt1, opt2, opt3 // Other options
        );

        await DisplayAlert("You selected", action, "OK");
    }
}