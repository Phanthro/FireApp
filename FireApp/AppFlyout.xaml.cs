using FireApp.Dto;

namespace FireApp;

public partial class AppFlyout : FlyoutPage
{
	public AppFlyout()
	{
		InitializeComponent();
        flyoutPage.collectionView.SelectionChanged += OnSelectionChanged;

    }

    void OnSelectionChanged( object sender, SelectionChangedEventArgs e )
    {
        flyoutPage.collectionView.SelectedItem = null;
        var item = e.CurrentSelection.FirstOrDefault() as FlyoutPageItem;
        if (item != null)
        {
            // Verifica se a Detail j� � um NavigationPage
            if (!(Detail is NavigationPage navigationPage))
            {
                // Se n�o for, cria um novo NavigationPage e atribui a Detail
                Detail = new NavigationPage( (Page)Activator.CreateInstance( item.TargetType ) );
            }
            else
            {
                // Verifica se a p�gina atual � do mesmo tipo que a p�gina que est� sendo selecionada
                var currentPageType = navigationPage.CurrentPage.GetType();
                var targetPageType = item.TargetType;

                if (currentPageType != targetPageType)
                {
                    // Se n�o for, empilha a nova p�gina
                    var nextPage = (Page)Activator.CreateInstance( targetPageType );
                    navigationPage.PushAsync( nextPage );
                }
                else
                {
                    // Se for a mesma p�gina, desempilha e empilha novamente para recri�-la
                    var currentPage = navigationPage.CurrentPage;
                    navigationPage.PopAsync();
                    navigationPage.PushAsync( currentPage );
                }
            }

            IsPresented = false;
        }
    }
}