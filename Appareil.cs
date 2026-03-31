using System.Dynamic;

abstract class Appareil
{
    private string Marque { get; set; }
    private string Modele { get; set; }
    private DateTime AnneeFabrication { get; set; }
    public string getMarque()
    {
        return Marque;
    }
    public string getModele()
    {
        return Modele;
    }
    public DateTime getAnneeFabrication()
    {
        return AnneeFabrication;
    }
    public void setMarque(string marque)
    {
        Marque = marque;
    }
    public void setModele(string modele)
    {
        Modele = modele;
    }
    public void setAnneeFabrication(DateTime anneeFabrication)
    {
        AnneeFabrication = anneeFabrication;
    }
    public Appareil(string marque, string modele, DateTime anneeFabrication)
    {
        Marque = marque;
        Modele = modele;
        AnneeFabrication = anneeFabrication;
    }
    public abstract void AfficherInfos();
    public void Allumer()
    {
        Console.WriteLine("L'appareil est allumé.");
    }
    public virtual void AfficherType()
    {
        Console.WriteLine("Ceci est un appareil.");
    }
    public virtual void AfficherGarantie()
    {
        Console.WriteLine("Garantie standard de l'appareil.");
    }
    public abstract TimeSpan CalculerAncienneté();
}