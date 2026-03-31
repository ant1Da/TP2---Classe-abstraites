namespace TP2___Classe_abstraites;

class Program
{
    static void Main(string[] args)
    {
        /// QUESTIONS
        /// 1) Pourquoi la classe appareil est-elle abstraite ?
        /// Elle est abstraite car elle sert de modèle pour d'autres classes qui vont hériter de ses propriétés et méthodes. Elle ne peut pas être instanciée directement, mais elle fournit une structure commune pour les classes dérivées. En étant abstraite, elle permet de définir des méthodes qui doivent être implémentées par les classes dérivées, assurant ainsi une certaine cohérence dans la hiérarchie des classes.
        /// 2) Peut-on écrire Appareil a = new Appareil(...) ?
        /// Non, on ne peut pas instancier une classe abstraite. Appareil est une classe abstraite, donc on ne peut pas créer d'instance de cette classe directement. On doit créer une classe dérivée qui hérite de Appareil et instancier cette classe dérivée.
        /// 3) Quelle est la différence entre une méthode virtual et une méthode abstract dans une classe abstraite ?
        /// Une méthode virtual propose l'option d'être redéfinie au sein de la classe dérivée, tandis qu'une méthode abstract doit être redéfinie dans la classe dérivée. Une méthode virtual peut avoir une implémentation par défaut, tandis qu'une méthode abstract n'en a pas.
         
        Appareil appareil1 = new Ordinateur("Lenovo", "Thinkpad", new DateTime(2020, 5, 1), 15.6);
        appareil1.Allumer();
        appareil1.AfficherType();
        appareil1.AfficherInfos();
        appareil1.AfficherGarantie();
        Console.WriteLine(appareil1);

        // Pourquoi ToString() est-elle utile ?
        // ToString() est utile pour fournir une représentation textuelle d'un objet. Lorsque vous appelez Console.WriteLine(appareil1), le système appelle automatiquement la méthode ToString() de l'objet appareil1 pour obtenir une chaîne de caractères à afficher. En redéfinissant la méthode ToString() dans la classe Ordinateur, nous pouvons personnaliser la façon dont les informations de l'ordinateur sont affichées

        // Exercice 3
        Smartphone smartphone1 = new Smartphone("Apple", "iPhone 12", new DateTime(2020, 10, 23), 2);
        smartphone1.Allumer();
        smartphone1.AfficherType();
        smartphone1.AfficherGarantie();
        smartphone1.AfficherInfos();
        
        // Si Smartphone ne redéfinit pas AfficherType(), quelle version sera utilisée ?
        // Si Smartphone ne redéfinit pas AfficherType(), la version de la classe Appareil sera utilisée, affichant "Ceci est un appareil." au lieu de quelque chose de plus spécifique comme "Ceci est un smartphone."

        // Exercice 4
        Appareil smartphone2 = new Smartphone("Apple", "iPhone 17 Pro", new DateTime(2025, 6, 1), 3);
        Appareil smartphone3 = new Smartphone("Samsung", "Galaxy S26", new DateTime(2026, 1, 15), 4);
        Appareil ordinateur1 = new Ordinateur("Dell", "XPS 15", new DateTime(2023, 3, 10), 15.6);
        Appareil ordinateur2 = new Ordinateur("HP", "Spectre x360", new DateTime(2024, 8, 20), 13.3);
        List<Appareil> appareils = new List<Appareil> {smartphone2, smartphone3, ordinateur1, ordinateur2};
        foreach (Appareil appareil in appareils)
        {
            Console.WriteLine(appareil.CalculerAncienneté());
            appareil.Allumer();
            appareil.AfficherType();
            appareil.AfficherGarantie();
            appareil.AfficherInfos();
        }
        // Quel type de données C# permet de stocker une date ?
        // C# utilise le type de données DateTime pour stocker une date et une heure. DateTime permet de représenter des dates et des heures avec une grande précision, ainsi que d'effectuer des opérations sur les dates, comme l'ajout ou la soustraction de jours, de mois ou d'années.
        // Pourquoi peut-on stocker des objets de type Ordinateur et Smartphone dans une liste d'Appareil ?
        // On peut stocker des objets de type Ordinateur et Smartphone dans une liste d'Appareil parce que Ordinateur et Smartphone sont des classes dérivées de la classe abstraite Appareil. En C#, une liste d'un type de base (comme Appareil) peut contenir des objets de n'importe quelle classe qui hérite de ce type de base. Cela permet d'utiliser le polymorphisme, où les méthodes appelées sur les objets de la liste seront résolues à l'exécution en fonction du type réel de l'objet (Ordinateur ou Smartphone), même si la liste est déclarée pour contenir des Appareils.
        Dictionary<string, Appareil> dicoAppareils = new Dictionary<string, Appareil>();
        dicoAppareils.Add(ordinateur1.getModele(), ordinateur1);
        dicoAppareils.Add(ordinateur2.getModele(), ordinateur2);
        dicoAppareils.Add(smartphone2.getModele(), smartphone2);
        dicoAppareils.Add(smartphone3.getModele(), smartphone3);
        foreach (KeyValuePair<string, Appareil> entry in dicoAppareils)
        {
            Console.WriteLine($"Clé: {entry.Key}, Valeur: {entry.Value}");
        }
        // A quoi sert un dictionnaire dans un programme ?
        // Un dictionnaire est une collection de paires clé-valeur qui permet de stocker et de récupérer des données de manière efficace. Il est utilisé pour associer une clé unique à une valeur, ce qui facilite la recherche et l'accès aux données. Dans un programme, un dictionnaire peut être utilisé pour stocker des informations telles que des paramètres de configuration, des données d'utilisateur, ou dans ce cas, des objets Appareil associés à leurs modèles respectifs. Les dictionnaires offrent une performance rapide pour les opérations de recherche, d'ajout et de suppression d'éléments grâce à leur structure interne basée sur des tables de hachage.
    }
}
