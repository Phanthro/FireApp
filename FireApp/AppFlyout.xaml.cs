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
            // Verifica se a Detail já é um NavigationPage
            if (!(Detail is NavigationPage navigationPage))
            {
                // Se não for, cria um novo NavigationPage e atribui a Detail
                Detail = new NavigationPage( (Page)Activator.CreateInstance( item.TargetType ) );
            }
            else
            {
                // Verifica se a página atual é do mesmo tipo que a página que está sendo selecionada
                var currentPageType = navigationPage.CurrentPage.GetType();
                var targetPageType = item.TargetType;

                if (currentPageType != targetPageType)
                {
                    // Se não for, empilha a nova página
                    var nextPage = (Page)Activator.CreateInstance( targetPageType );
                    navigationPage.PushAsync( nextPage );
                }
                else
                {
                    // Se for a mesma página, desempilha e empilha novamente para recriá-la
                    var currentPage = navigationPage.CurrentPage;
                    navigationPage.PopAsync();
                    navigationPage.PushAsync( currentPage );
                }
            }

            IsPresented = false;
        }
    }
}