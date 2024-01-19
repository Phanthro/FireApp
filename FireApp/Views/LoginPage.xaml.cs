namespace FireApp.Views;

public partial class LoginPage : ContentPage
{
    public LoginPage()
	{
		InitializeComponent();
        NavigationPage.SetHasNavigationBar( this, false );
    }

    private void Button_Clicked( object sender, EventArgs e )
    {
        Navigation.PushAsync( new Inicial() );

    }
}