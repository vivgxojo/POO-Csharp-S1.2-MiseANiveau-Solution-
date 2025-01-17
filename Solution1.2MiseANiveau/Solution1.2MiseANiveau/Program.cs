﻿using Solution1._2MiseANiveau;
/*
string fileName = "fEx1.2.txt";

// 1. Écrire la liste [1,2,4,3,5] dans le fichier
List<string> liste1 = new List<string> { "1", "2", "4", "3", "5" };
Fichiers.Ecrire(liste1, fileName);

// 2. Écrire la liste ["allo", "maman"] dans le même fichier
List<string> liste2 = new List<string> { "allo", "maman" };
Fichiers.Ecrire(liste2, fileName);

// 3. Lire les lignes 1 à 2
Console.WriteLine("\nLignes 1 à 2:");
Fichiers.Lire(fileName, 1, 2);

// 4. Lire les lignes 0 à 1 (gestion de 0 : on considère 0 comme invalide, il faut ajouter la gestion d'erreurs)
Console.WriteLine("\nLignes 0 à 1:");
Fichiers.Lire(fileName, 0, 1);

// 5. Lire les lignes 2 à 2
Console.WriteLine("\nLignes 2 à 2:");
Fichiers.Lire(fileName, 2, 2);

// 6. Observations
// - La méthode Ecrire ajoute les listes correctement avec des points-virgules en séparateurs.
// - La méthode Lire gère les plages de lignes spécifiées et affiche les lignes correspondantes.
// - Le numéro de ligne 0 est traité comme invalide, car les numéros de ligne commencent à 1.
// - Si une plage de lignes dépasse les limites du fichier, seule la partie valide est lue.
*/


while (true)
{
    Console.WriteLine("1. Écrire un fichier");
    Console.WriteLine("2. Lire un fichier");
    string choix = Console.ReadLine();

    if ( choix == "1")
    {
        Console.WriteLine("Entrer le nom du fichier");
        string nom = Console.ReadLine();
        List<string> list = new List<string>();
        while (true)
        {
            Console.WriteLine("Entrer du texte à écrire ou Enter pour terminer");
            string ligne = Console.ReadLine();
            if (ligne == "")
            {
                break;
            }
            list.Add(ligne);
        }
        Fichiers.Ecrire(list, nom);
    }
    else if ( choix == "2") 
    {
        Console.WriteLine("Entrer le nom du fichier");
        string nom = Console.ReadLine();
        int ligne1 = -1;
        int ligne2 = -1;

        while (ligne1 == -1 || ligne2 == -1)
        {
            try
            {
                Console.WriteLine("Entrer la première ligne à afficher");
                ligne1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Entrer la dernière ligne à afficher");
                ligne2 = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Numéros de lignes non valide");
            }
        }

        Fichiers.Lire(nom, ligne1, ligne2);
    }
    else
    {
        Console.WriteLine("Choix non valide");
    }
}