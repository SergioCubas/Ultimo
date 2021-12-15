using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proyecto_MVC.Models;
using Proyecto_MVC.ProxyReservas;
using Proyecto_MVC.ProxyVuelos;

namespace Proyecto_MVC.Controllers
{
    public class ReservasController : Controller
    {
        ServicioReservaClient miservReservas = new ServicioReservaClient();
        ServicioVueloClient miservVuelos = new ServicioVueloClient();


        // GET: Reservas
        public ActionResult Index()
        {
            ViewBag.ListarReservas = miservReservas.ListarReservas();
            ViewBag.ListarCiudadOrigen = ObtenerCiudadesOrigen();
            ViewBag.ListarCiudadDestino = ObtenerCiudadesDestino();
            return View();
        }

        public ActionResult Detail()
        {
            if (Session["UserNombre"] != null)
            {
                ViewBag.ListarReservas = miservReservas.ListarReservasPorDni(Session["UserDni"].ToString());
            }
            else
            {
                ViewBag.ListarReservas = "";
            }

            return View();
        }

        public ActionResult Pagar(Tb_pago pago)
        {
            miservVuelos.PagarReserva((int)pago.idPasajero, (int)pago.idReserva, pago.tipo_comprobante, pago.medio_pago);

            TempData["exit"] = "Reserva Pagada!";

            return RedirectToAction("Detail", "Reservas");
        }

        public List<SelectListItem> ObtenerCiudadesOrigen()
        {
            List<SelectListItem> items = new SelectList(miservReservas.ListarDepartamentos(), "Nombre_Departamento", "Nombre_Departamento").ToList();
            items.Insert(0, new SelectListItem { Text = "Seleccione Ciudad Origen", Value = "0" });
            return items;
        }

        public List<SelectListItem> ObtenerCiudadesDestino()
        {
            List<SelectListItem> items = new SelectList(miservReservas.ListarDepartamentos(), "Nombre_Departamento", "Nombre_Departamento").ToList();
            items.Insert(0, new SelectListItem { Text = "Seleccione Ciudad Destino", Value = "0" });
            return items;
        }

        public ActionResult Buscar(FormCollection fc)
        {
            String condicion = fc["condicion"];
            String criterio1 = fc["criterio1"];
            String criterio2 = fc["criterio2"];
            String criterio = fc["criterio"];
            String criterioCiudadOrigen = fc["cboCiudadOrigen"];
            String criterioCiudadDestino = fc["cboCiudadDestino"];
            
            if (condicion.Equals("PorCiudadOrigen"))

            {

                ViewBag.ListarReservas = miservReservas.ListarReservasPorCiudadOrigen(criterioCiudadOrigen);

            }

            else if (condicion.Equals("PorCiudadDestino"))

            {

                ViewBag.ListarReservas = miservReservas.ListarReservasPorCiudadDestino(criterioCiudadDestino);

            }
            else if (condicion.Equals("PorDni"))

            {

                ViewBag.ListarReservas = miservReservas.ListarReservasPorDni(criterio);

            }

            else if (condicion.Equals("PorFechaSalida"))

            {

                ViewBag.ListarReservas = miservReservas.ListarReservasPorFechaSalida(Convert.ToDateTime(criterio1), Convert.ToDateTime(criterio2));

            }
            else if (condicion.Equals("PorFechaLlegada"))

            {

                ViewBag.ListarReservas = miservReservas.ListarReservasPorFechaLlegada(Convert.ToDateTime(criterio1), Convert.ToDateTime(criterio2));

            }

            else

            {

                ViewBag.ListarReservas = miservReservas.ListarReservas();

            }
            ViewBag.ListarCiudadOrigen = ObtenerCiudadesOrigen();
            ViewBag.ListarCiudadDestino = ObtenerCiudadesDestino();
            return View("Index");



        }
    }
}