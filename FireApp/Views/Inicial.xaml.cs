namespace FireApp.Views;

public partial class Inicial : ContentPage
{
	public Inicial()
	{
		InitializeComponent();
        NavigationPage.SetHasNavigationBar( this, false );
    }

    private void ImageButton_Clicked( object sender, EventArgs e )
    {
        var flyoutPage = ((Parent as NavigationPage).Parent as FlyoutPage);

        // Verifique se o pai é uma instância de FlyoutPage
        if (flyoutPage != null)
        {
            // Altere o valor de IsPresented
            flyoutPage.IsPresented = !flyoutPage.IsPresented;
        }
    }
}