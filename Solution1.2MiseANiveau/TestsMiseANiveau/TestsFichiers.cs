using Solution1._2MiseANiveau;

namespace TestsMiseANiveau
{
    public class TestsFichiers
{
        //Arrange
        string[] fileName = { "F1.txt", @"C:\F1.txt", "F1", "F1.exe", "", "dossier/f1.txt", "../f1.txt", "f*.txt", "fichié.txt"};
        List<string> liste1 = new List<string> { "1", "2", "4", "3", "5" };
        List<string> liste2 = new List<string> { "allo", "maman" };

        [Fact]
        public void TestEcrire1()
        {
            Fichiers.Ecrire(liste2, fileName[0]);
        }
        [Fact]
        public void TestEcrire2()
        {
            Fichiers.Ecrire(liste2, fileName[1]);
        }
        [Fact]
        public void TestEcrire3()
        {
            Fichiers.Ecrire(liste2, fileName[2]);
        }

        //Tests de lecture
        //Arrange
        string[] file = {"asdfsfs.txt", "TestLecture.txt", "TestLecture2.txt", "TestLecture3.txt" };
        int[] ligneDebut = { -1, 0, 1, 2, 100 };
        int[] ligneFin = { -1, 0, 1, 2, 100 };

        [Fact]
        public void TestLireFichierInnexistant()
        {
            Fichiers.Lire(file[0], ligneDebut[2], ligneFin[2]);
        }

        [Fact]
        public void TestLireLigneFinAvantLigneDebut()
        {
            Fichiers.Lire(file[1], ligneDebut[3], ligneFin[2]);
        }
    }
}