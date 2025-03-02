namespace URISignIn
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void SignUpBtn_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Username.Text) || string.IsNullOrEmpty(Email.Text) || string.IsNullOrEmpty(Password.Text))
            {
                DisplayAlert("Error", "Please Enter All Values", "OK");
            }
            else 
            {
                if (Password.Text.Equals(PasswordConfirm.Text))
                {
                    var myData = new Dictionary<string, object>
                    {
                        {"username",$"{Username.Text}"},
                        {"email",$"{Email.Text}"}
                    };
                    
                    Shell.Current.GoToAsync(nameof(ProfileView), myData);
                }
                else 
                {
                    DisplayAlert("Error", "Password does not equal Confirm Password", "OK");
                }
            }
        }
    }
}
