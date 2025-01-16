using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution1._2MiseANiveau
{
    public class Fichiers
    {
        /// <summary>
        /// Écrire une liste dans un fichier en séparant les éléments par des ";"
        /// </summary>
        /// <param name="liste">La liste contenant les chaines à écire</param>
        /// <param name="nomFichier">Le nom du fichier choisi</param>
        public static void Ecrire(List<string> liste, string nomFichier)
        {
            try
            {
                FileStream fs = new FileStream(nomFichier, FileMode.Append, FileAccess.Write);
                StreamWriter writer = new StreamWriter(fs);
            
                // Concatène les éléments de la liste avec des points-virgules et écrit la ligne
                string ligne = string.Join("; ", liste);
                writer.WriteLine(ligne);

                writer.Flush();
                writer.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        /// <summary>
        /// Lire les lignes d'un fichier et les afficher à la console
        /// </summary>
        /// <param name="nomFichier">Le fichier à lire</param>
        /// <param name="ligneDebut">Première ligne qui sera affichée</param>
        /// <param name="ligneFin">Dernière ligne qui sera affichée</param>
        public static void Lire(string nomFichier, int ligneDebut, int ligneFin)
        {
            // Gestion d'erreurs : Valider la première ligne : 
            if (ligneDebut < 1 || ligneDebut > ligneFin)
            {
                Console.WriteLine("Ligne de début non valide");
                return;
            }

            // Vérifie que le fichier existe
            if (!File.Exists(nomFichier))
            {
                Console.WriteLine("Le fichier n'existe pas.");
                return;
            }

            FileStream fs = new FileStream(nomFichier, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fs);
            
            int numeroLigne = 1;

            // Lire les lignes avant ligneDebut sans les afficher pour avancer dasn le fichier
            for (int i = 0; i < ligneDebut-1; i++)
            {
                reader.ReadLine();
                numeroLigne++;
            }

            // Lit le fichier ligne par ligne
            while (reader.Peek() != -1 && numeroLigne <= ligneFin)
            {
                // Affiche les lignes entre ligneDebut et ligneFin (inclusivement)
                Console.WriteLine(reader.ReadLine());
                numeroLigne++;
            }

            // Affiche un message si la dernière ligne n'existe pas
            if(numeroLigne <= ligneFin)
            {
                Console.WriteLine("Le fichier s'est terminé avant la dernière ligne demandée");
            }

            // Fermer le flux et le fichier
            reader.DiscardBufferedData();
            reader.Close();
            fs.Close();
        }
    }

}

