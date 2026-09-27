namespace DiggerTrack.App.Models;

/// <summary>
/// Représente une offre commerciale pour un produit
/// dans une boutique précise.
///
/// Un même Product peut posséder plusieurs StoreOffer.
///
/// Exemple :
/// Oblivion Remastered
///     → Steam : 41,24 €
///     → Instant Gaming : 36,99 €
///     → Amazon : 49,99 €
/// </summary>
public class StoreOffer
{
    /// <summary>
    /// Identifiant unique de l'offre.
    /// </summary>
    public Guid Id { get; set; } = Guid.NewGuid();

    /// <summary>
    /// Nom de la boutique proposant l'offre.
    /// </summary>
    public string StoreName { get; set; } = string.Empty;

    /// <summary>
    /// Adresse permettant d'accéder à la page
    /// du produit sur la boutique.
    /// </summary>
    public string ProductUrl { get; set; } = string.Empty;

    /// <summary>
    /// Prix de référence utilisé pour calculer
    /// une éventuelle réduction.
    /// </summary>
    public decimal OriginalPrice { get; set; }

    /// <summary>
    /// Prix actuellement observé.
    /// </summary>
    public decimal CurrentPrice { get; set; }

    /// <summary>
    /// Devise utilisée par cette offre.
    /// </summary>
    public string Currency { get; set; } = "EUR";

    /// <summary>
    /// Date et heure auxquelles le prix
    /// a été vérifié pour la dernière fois.
    /// </summary>
    public DateTime LastCheckedAt { get; set; } = DateTime.Now;

    /// <summary>
    /// Calcule automatiquement le pourcentage
    /// de réduction de l'offre.
    /// </summary>
    public decimal DiscountPercentage
    {
        get
        {
            if (OriginalPrice <= 0 || CurrentPrice >= OriginalPrice)
            {
                return 0;
            }

            return Math.Round(
                ((OriginalPrice - CurrentPrice) / OriginalPrice) * 100,
                2);
        }
    }
}