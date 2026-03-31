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
    public Smartphone(string marque, string modele, DateTime anneeFabrication, int nbCapteursPhoto) : base(marque, modele, anneeFabrication)
    {
        this.nbCapteursPhoto = nbCapteursPhoto;
    }
    public override TimeSpan CalculerAncienneté()
    {
        // Calcul de l'ancienneté en années
        Console.WriteLine($"Calcul de l'ancienneté pour le smartphone {getMarque()} {getModele()}");
        return TimeSpan.FromDays((DateTime.Now - getAnneeFabrication()).TotalDays / 365);
    }
    public override void AfficherType()
    {
        Console.WriteLine("Ceci est un smartphone.");
    }
    public override void AfficherInfos()
    {
        Console.WriteLine($"Marque: {getMarque()}");
        Console.WriteLine($"Modèle: {getModele()}");
        Console.WriteLine($"Année de fabrication: {getAnneeFabrication()}");
        Console.WriteLine($"Nombre de capteurs photo: {nbCapteursPhoto}");
        Console.WriteLine($"Ancienneté: {CalculerAncienneté().TotalDays / 365} ans");
    }
    public override string ToString()
    {
        return $"Smartphone - Marque: {getMarque()}, Modèle: {getModele()}, Nombre de capteurs photo: {nbCapteursPhoto}";
    }
}