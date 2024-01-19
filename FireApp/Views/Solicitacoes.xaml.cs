using CommunityToolkit.Maui.Views;
using FireApp.ViewModels;

namespace FireApp.Views;

public partial class Solicitacoes : ContentPage
{
	public Solicitacoes()
	{
		InitializeComponent();
        BindingContext = new SolicitacoesViewModel();
        NavigationPage.SetHasNavigationBar( this, false );
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        SolicitacoesViewModel vm = BindingContext as SolicitacoesViewModel;
        vm.CarrgarSolicitacoes();

        
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