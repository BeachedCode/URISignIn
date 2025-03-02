namespace URISignIn;
[QueryProperty(nameof(User_Name),"username")]
[QueryProperty(nameof(User_Email),"email")]

public partial class ProfileView : ContentPage
{
	public string User_Name { get; set; }
	public string User_Email { get; set; }
	public ProfileView()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

        DisplayAlert("Success", "You have successfully signed up. \n" +
            "Username: " + User_Name + "\n" +
            "Email: " + User_Email, "OK");
    }
}