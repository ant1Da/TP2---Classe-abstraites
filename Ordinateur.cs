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
        return DateTime.Now - getAnneeFabrication();
    }
    public override void AfficherInfos()
    {
        Console.WriteLine($"Marque: {getMarque()}");
        Console.WriteLine($"Modèle: {getModele()}");
        Console.WriteLine($"Année de fabrication: {getAnneeFabrication()}");
        Console.WriteLine($"Taille de l'écran: {tailleEcran} pouces");
        Console.WriteLine($"Ancienneté: {CalculerAncienneté().TotalDays / 365} ans");
    }
    public override string ToString()
    {
        return $"Ordinateur - Marque: {getMarque()}, Modèle: {getModele()}, Taille de l'écran: {tailleEcran} pouces";
    }
}