class Smartphone : Appareil
{
    private int nbCapteursPhoto { get; set; }
    public int getNbCapteursPhoto()
    {
        return nbCapteursPhoto;
    }
    public void setNbCapteursPhoto(int nbCapteursPhoto)
    {
        this.nbCapteursPhoto = nbCapteursPhoto;
    }
    public smartphone(string marque, string modele, DateTime anneeFabrication, int nbCapteursPhoto) : base(marque, modele, anneeFabrication)
    {
        this.nbCapteursPhoto = nbCapteursPhoto;
    }
    public override TimeSpan CalculerAncienneté()
    {
        return DateTime.Now - getAnneeFabrication();
    }
    public override void AfficherInfos()
    {
        Console.WriteLine($"Marque: {getMarque()}");
        Console.WriteLine($"Modèle: {getModele()}");
        Console.WriteLine($"Année de fabrication: {getAnneeFabrication()}");
        Console.WriteLine($"Nombre de capteurs photo: {nbCapteursPhoto}");
        Console.WriteLine($"Ancienneté: {CalculerAncienneté().TotalDays / 365} ans");
    }
}