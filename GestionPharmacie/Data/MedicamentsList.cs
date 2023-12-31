using GestionPharmacie.Models;
namespace GestionPharmacie.Data

{
    public class MedicamentsList
    {
        private static List<Medicament> Medicaments = new List<Medicament>
        {
            new Medicament{Numero=1,NomFabriquant="Nom1",DateExpiration=new DateTime(2023,12,12) },
            new Medicament{Numero=2,NomFabriquant="Nom2",DateExpiration=new DateTime(2024,12,12) },
           
            new Medicament{Numero=3,NomFabriquant="Nom3",DateExpiration=new DateTime(2025,12,12) },
            new Medicament{Numero=3,NomFabriquant="Pfizer",DateExpiration=new DateTime(2025,12,12) },
            new Medicament{Numero=3,NomFabriquant="Pfizer",DateExpiration=new DateTime(2025,12,12) },
            new Medicament{Numero=3,NomFabriquant="Pfizer",DateExpiration=new DateTime(2025,12,12) },
        };


        public static List<Medicament> GetMedicaments()
        {
            return Medicaments;
        }

    }
}
