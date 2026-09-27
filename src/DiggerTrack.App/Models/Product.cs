namespace DiggerTrack.App.Models;

/// <summary>
/// Représente un produit unique suivi dans DiggerTrack.
///
/// Un produit correspond à l'article lui-même et non à une offre
/// particulière proposée par une boutique.
///
/// Exemple :
/// "The Elder Scrolls IV: Oblivion Remastered" est un produit.
/// Ses offres Steam, Amazon ou Instant Gaming seront représentées
/// séparément par des objets StoreOffer.
/// </summary>
public class Product
{
    /// <summary>
    /// Identifiant unique du produit.
    /// </summary>
    public Guid Id { get; set; } = Guid.NewGuid();

    /// <summary>
    /// Nom du produit.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Description facultative du produit.
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Catégorie du produit.
    ///
    /// Exemples :
    /// Jeu vidéo, composant informatique, vêtement, console...
    ///
    /// Nous utiliserons une chaîne de caractères pour le moment.
    /// Une catégorie structurée pourra être créée ultérieurement.
    /// </summary>
    public string Category { get; set; } = string.Empty;

    /// <summary>
    /// Indique si le produit fait partie des favoris
    /// de l'utilisateur.
    /// </summary>
    public bool IsFavorite { get; set; }

    /// <summary>
    /// Ensemble des offres actuellement connues
    /// pour ce produit.
    /// </summary>
    public List<StoreOffer> Offers { get; set; } = [];
}