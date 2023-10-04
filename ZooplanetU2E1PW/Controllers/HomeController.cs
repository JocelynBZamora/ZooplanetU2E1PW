using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZooplanetU2E1PW.Models.Entities;
using ZooplanetU2E1PW.Models.ViewModels;

namespace ZooplanetU2E1PW.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            IndexViewModel vm = new();
            AnimalesContext context = new();
            var ListaAnimales = context.Clase.Select(Clase => new Animales
            {
                Id = Clase.Id,
                Nombre = Clase.Nombre ?? "",
                Descripcion = Clase.Descripcion != null ? Clase.Descripcion : "No hay descripcion"
            }).ToList();
            vm.animales = ListaAnimales;
            return View(vm);
        }
        public IActionResult Especies(string Id) 
        {
            AnimalesContext context = new();
            EspeciesViewModel vm = new();
            var ListaEspecies = context.Especies.Where(x => x.IdClaseNavigation.Nombre == Id).
                Select(x => new Espe
                {
                    Id = x.Id,
                    Nombre = x.Especie
                }).ToList();
            int ClaseID = context.Clase.Where(x => x.Nombre == Id ).Select(Clase=>Clase.Id).First();
            vm.Nombre = Id;
            vm.Id = ClaseID;
            vm.espes = ListaEspecies;
            return View(vm);
        }
        public IActionResult Especie(string Id)
        {
            AnimalesContext context = new();
            EspecieViewModel vm = new();
            var Especie = context.Especies.Include(x=> x.IdClaseNavigation).FirstOrDefault(x => x.Especie == Id);
            if (Especie != null)
            {
                var animal = new Especie()
                {
                    Nombre = Especie.Especie,
                    Tamaño = Especie.Tamaño,
                    Peso = Especie.Peso,
                    Descripcion = Especie.Observaciones ?? "No hay observaciones",
                    Habitad = Especie.Habitat ?? "No se encontro habitad",
                    Id = Especie.Id,
                    TipoEspecie = Especie.IdClaseNavigation.Nombre
                };
            return View(animal);
            }
            else { return View(); }
        }
    }
}
