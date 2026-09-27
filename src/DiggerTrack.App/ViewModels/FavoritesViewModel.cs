using System.Collections.ObjectModel;
using DiggerTrack.App.Models;

namespace DiggerTrack.App.ViewModels;

/// <summary>
/// ViewModel responsable des données affichées
/// sur la page des favoris de DiggerTrack.
///
/// Il fait le lien entre l'interface FavoritesPage
/// et les produits suivis par l'utilisateur.
/// </summary>
public class FavoritesViewModel
{
    /// <summary>
    /// Liste observable des produits favoris.
    ///
    /// ObservableCollection permet à l'interface MAUI
    /// d'être automatiquement informée lorsqu'un produit
    /// est ajouté ou supprimé de la collection.
    /// </summary>
    public ObservableCollection<TrackedProduct> Products { get; }

    /// <summary>
    /// Initialise le ViewModel des favoris.
    ///
    /// Pour le moment, nous utilisons des produits
    /// de démonstration afin de construire et tester
    /// l'interface avant l'arrivée de la base de données.
    /// </summary>
    public FavoritesViewModel()
    {
        Products = new ObservableCollection<TrackedProduct>
        {
            new()
            {
                Name = "The Elder Scrolls IV: Oblivion Remastered",
                StoreName = "Steam",
                ProductUrl = string.Empty,
                OriginalPrice = 54.99m,
                CurrentPrice = 41.24m,
                Currency = "EUR",
                LastCheckedAt = DateTime.Now,
                IsFavorite = true
            },

            new()
            {
                Name = "The Elder Scrolls IV: Oblivion Remastered",
                StoreName = "Instant Gaming",
                ProductUrl = string.Empty,
                OriginalPrice = 54.99m,
                CurrentPrice = 36.99m,
                Currency = "EUR",
                LastCheckedAt = DateTime.Now,
                IsFavorite = true
            },

            new()
            {
                Name = "The Elder Scrolls IV: Oblivion Remastered",
                StoreName = "Amazon",
                ProductUrl = string.Empty,
                OriginalPrice = 54.99m,
                CurrentPrice = 49.99m,
                Currency = "EUR",
                LastCheckedAt = DateTime.Now,
                IsFavorite = true
            }
        };
    }
}