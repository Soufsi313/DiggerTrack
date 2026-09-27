using System.Collections.ObjectModel;
using DiggerTrack.App.Models;

namespace DiggerTrack.App.ViewModels;

/// <summary>
/// ViewModel responsable des produits favoris affichés
/// dans la page Favoris de DiggerTrack.
///
/// Un favori représente désormais un Product unique.
/// Chaque Product peut contenir plusieurs offres provenant
/// de différentes boutiques via sa collection Offers.
/// </summary>
public class FavoritesViewModel
{
    /// <summary>
    /// Collection des produits favoris de l'utilisateur.
    ///
    /// Un produit n'apparaît qu'une seule fois dans cette collection,
    /// même s'il est suivi sur plusieurs boutiques.
    /// </summary>
    public ObservableCollection<Product> Products { get; }

    /// <summary>
    /// Initialise le ViewModel des favoris.
    ///
    /// Les données utilisées actuellement sont fictives et servent
    /// uniquement à tester l'architecture et l'interface.
    /// Elles seront remplacées plus tard par de véritables données.
    /// </summary>
    public FavoritesViewModel()
    {
        Products = new ObservableCollection<Product>
        {
            new()
            {
                Name = "The Elder Scrolls IV: Oblivion Remastered",

                Description =
                    "Produit de démonstration utilisé pour tester " +
                    "le suivi multiboutique de DiggerTrack.",

                Category = "Jeu vidéo",

                IsFavorite = true,

                // Un seul produit peut être surveillé
                // simultanément auprès de plusieurs boutiques.
                Offers =
                [
                    new StoreOffer
                    {
                        StoreName = "Steam",
                        ProductUrl = string.Empty,
                        OriginalPrice = 54.99m,
                        CurrentPrice = 41.24m,
                        Currency = "EUR",
                        LastCheckedAt = DateTime.Now
                    },

                    new StoreOffer
                    {
                        StoreName = "Instant Gaming",
                        ProductUrl = string.Empty,
                        OriginalPrice = 54.99m,
                        CurrentPrice = 36.99m,
                        Currency = "EUR",
                        LastCheckedAt = DateTime.Now
                    },

                    new StoreOffer
                    {
                        StoreName = "Amazon",
                        ProductUrl = string.Empty,
                        OriginalPrice = 54.99m,
                        CurrentPrice = 49.99m,
                        Currency = "EUR",
                        LastCheckedAt = DateTime.Now
                    }
                ]
            }
        };
    }
}