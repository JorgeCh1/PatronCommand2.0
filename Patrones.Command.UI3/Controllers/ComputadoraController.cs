using Patrones.Command.UI3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Patrones.Command.UI3.Controllers
{
    public class ComputadoraController : Controller
    {
        private static List<Computadora> computadoras = new List<Computadora>();

        //ESTE ES UN MÉTODO DE ACCIÓN QUE DEVUELVE LA VISTA INDEX Y ASINGA LA LISTA DE COMPUTADORAS
        // A AL PROPIERDAD VIEWBAG.COMPUTADORAS Y MOSTRARA UNA TABLA CON LAS COMPUTADORAS AGG Y CLONADAS
        public ActionResult Index()
        {
            ViewBag.Computadoras = computadoras;
            return View();
        }


        //ESTE ES OTRO MÉTODO DE ACCIÓN QUE MANEJA LA SOLICITUD POST CUANDO SE ENVIA EL FORMUALRIO PARA 
        //AGG UNA NUEVA COMPUTADORA, VALIDA SI EL MODELO ES VALIDO Y DE SER ASI AGG LA COMPUTADORA A LA LISTA Y
        //LUEGO REDIRIGE AL USUARIO A LA ACCIÓN INDEX, DE LO CONTRARIO SE DEVUELVE A LA VISTA INDEX
        [HttpPost]
        public ActionResult AgregarComputadora(Computadora computadora)
        {
            if (ModelState.IsValid)
            {
                computadoras.Add(computadora);
                return RedirectToAction("Index");
            }
            ViewBag.Computadoras = computadoras;
            return View("Index");
        }


        //ESTE ULTIMO MÉTODO DE ACCIÓN PERMITE CLONAR UNA COMPUTADORA EXISTENTE EN LA LISTA DE COMPUTADORAS UTILIZANDO EL PATRON
        //PROTOTYPE, LA ACCIÓN RECIBE EL ID QUE DESEA CLONAR Y LA CLONA Y LA AGG A LA LISTA Y FINALMENTE TE REDIGIRE AL INDEX
        public ActionResult ClonarComputadora(int id)
        {
            if (id >= 0 && id < computadoras.Count)
            {
                var computadoraOriginal = computadoras[id];
                var computadoraClonada = computadoraOriginal.Clonar();
                computadoras.Add(computadoraClonada);
            }

            return RedirectToAction("Index");
        }

    }
}
