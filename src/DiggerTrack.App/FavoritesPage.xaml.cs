using DiggerTrack.App.ViewModels;

namespace DiggerTrack.App;

/// <summary>
/// Page affichant les produits favoris suivis
/// par l'utilisateur dans DiggerTrack.
/// </summary>
public partial class FavoritesPage : ContentPage
{
    /// <summary>
    /// Initialise la page des favoris.
    ///
    /// Le FavoritesViewModel est défini comme BindingContext
    /// afin que le XAML puisse accéder à sa collection Products.
    /// </summary>
    public FavoritesPage()
    {
        InitializeComponent();

        // Connecte la page au ViewModel.
        BindingContext = new FavoritesViewModel();
    }
}