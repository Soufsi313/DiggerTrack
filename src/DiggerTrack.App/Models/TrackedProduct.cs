namespace DiggerTrack.App.Models;

/// <summary>
/// Représente un produit suivi par l'utilisateur dans DiggerTrack.
///
/// Ce modèle contient les informations principales nécessaires
/// au suivi d'un produit sur une boutique.
///
/// Il sera enrichi progressivement lorsque nous ajouterons
/// la base de données, l'historique des prix et les alertes.
/// </summary>
public class TrackedProduct
{
    /// <summary>
    /// Identifiant unique du produit suivi.
    /// </summary>
    public Guid Id { get; set; } = Guid.NewGuid();

    /// <summary>
    /// Nom du produit.
    /// Exemple : The Elder Scrolls IV: Oblivion Remastered.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Nom de la boutique sur laquelle le produit est suivi.
    /// Exemple : Steam, Amazon ou Instant Gaming.
    /// </summary>
    public string StoreName { get; set; } = string.Empty;

    /// <summary>
    /// Adresse de la page du produit sur la boutique.
    /// </summary>
    public string ProductUrl { get; set; } = string.Empty;

    /// <summary>
    /// Prix de référence du produit avant réduction.
    /// </summary>
    public decimal OriginalPrice { get; set; }

    /// <summary>
    /// Prix actuellement observé sur la boutique.
    /// </summary>
    public decimal CurrentPrice { get; set; }

    /// <summary>
    /// Devise utilisée pour le prix.
    ///
    /// EUR est utilisé par défaut puisque DiggerTrack
    /// est actuellement développé dans un contexte européen.
    /// </summary>
    public string Currency { get; set; } = "EUR";

    /// <summary>
    /// Date et heure de la dernière vérification du prix.
    /// </summary>
    public DateTime LastCheckedAt { get; set; } = DateTime.Now;

    /// <summary>
    /// Indique si le produit fait partie des favoris
    /// actuellement suivis par l'utilisateur.
    /// </summary>
    public bool IsFavorite { get; set; } = true;

    /// <summary>
    /// Calcule automatiquement le pourcentage de réduction
    /// à partir du prix de référence et du prix actuel.
    ///
    /// Cette propriété n'est pas stockée :
    /// elle est calculée à partir des prix.
    /// </summary>
    public decimal DiscountPercentage
    {
        get
        {
            // Évite notamment une division par zéro
            // lorsque le prix de référence n'est pas encore connu.
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