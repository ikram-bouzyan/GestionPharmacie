using GestionPharmacie.Data;
using GestionPharmacie.Models;
using Microsoft.AspNetCore.Mvc;

namespace GestionPharmacie.Controllers
{
    public class MedicamentController : Controller
    {
        public static List<Medicament> DeletedMedicament = new List<Medicament>();
        public static List<Medicament> Medicaments = MedicamentsList.GetMedicaments();
        public IActionResult Index()
        {
            ViewBag.DeletedMedicament= DeletedMedicament;
            ViewBag.MedicamentsList=Medicaments;
            return View();
        }

        [HttpGet]
        public IActionResult Ajouter()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Ajouter(Medicament med)
        {
            Medicaments.Add(med);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Modifier()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Modifier(Medicament med)
        {
            Medicament Med = Medicaments.Find(Medicament => Medicament.Numero == med.Numero);
            Med.NomFabriquant = med.NomFabriquant;
            Med.DateExpiration = med.DateExpiration;
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Supprimer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Supprimer(int numero)
        {
            var medicament = Medicaments.Find(med => med.Numero == numero);

            if (medicament == null)
            {
                return NotFound();
            }
            Medicaments.Remove(medicament);
            DeletedMedicament.Add(medicament);
            return RedirectToAction("Index");
        }

        public IActionResult Afficher()
        {
            ViewBag.MedicamentPfizer =Medicaments.FindAll(med => med.NomFabriquant == "Pfizer");
            return View();
        }

    }

}
