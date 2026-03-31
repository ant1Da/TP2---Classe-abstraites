class Ordinateur : Appareil
{
    private double tailleEcran {get; set;}
    public double getTailleEcran()
    {
        return tailleEcran;
    }
    public void setTailleEcran(double tailleEcran)
    {
        this.tailleEcran = tailleEcran;
    }
    public Ordinateur(string marque, string modele, DateTime anneeFabrication, double tailleEcran) : base(marque, modele, anneeFabrication)
    {
        this.tailleEcran = tailleEcran;
    }
    public override TimeSpan CalculerAncienneté()
    {
        Console.WriteLine($"Calcul de l'ancienneté pour l'ordinateur {getMarque()} {getModele()}");
        return TimeSpan.FromDays((DateTime.Now - getAnneeFabrication()).TotalDays / 365);
    }
    public override void AfficherInfos()
    {
        Console.WriteLine($"Marque: {getMarque()}");
        Console.WriteLine($"Modèle: {getModele()}");
        Console.WriteLine($"Année de fabrication: {getAnneeFabrication()}");
        Console.WriteLine($"Taille de l'écran: {tailleEcran} pouces");
        Console.WriteLine($"Ancienneté: {CalculerAncienneté()} ans");
    }
    public override string ToString()
    {
        return $"Ordinateur - Marque: {getMarque()}, Modèle: {getModele()}, Taille de l'écran: {tailleEcran} pouces";
    }
    public override void AfficherType()
    {
        Console.WriteLine("Ceci est un ordinateur.");
    }
}