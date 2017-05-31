using MarDom.Data.Entidades;
using MarDom.Data.StoreProcedure;
using MarDom.Services.Servicios.Ticket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;

namespace MarDom.Web.Api
{
    [RoutePrefix("api/Ticket")]
    public class TicketController : ApiController
    {
        [HttpGet]
        [Route("ObtenerTickets")]
        public List<ObtenerTickets> ObtenerTickets()
        {
            TicketService servicio = new TicketService();
            List<ObtenerTickets> data = new List<Data.StoreProcedure.ObtenerTickets>();
            data = servicio.ObtenerTickets().Data;
            return data.ToList();

        }
        [HttpGet]
        [Route("ObtenerCategoriaTickets")]
        public List<tkCategoria> ObtenerCategoriaTickets(int seccion)
        {
            TicketService servicio = new TicketService();
            List<tkCategoria> data = new List<tkCategoria>();
            data = servicio.ObtenerCategoriaTickets().Data;
            return data.Where(s=>s.tkSeccion == seccion).ToList();

        }
        [HttpGet]
        [Route("ObtenerPrioridadTickets")]
        public List<tkPrioridad> ObtenerPrioridadTickets()
        {
            TicketService servicio = new TicketService();
            List<tkPrioridad> data = new List<tkPrioridad>();
            data = servicio.ObtenerPrioridadTickets().Data;
            return data;

        }
        [HttpGet]
        [Route("ObtenerEstadoTickets")]
        public List<tkEstados> ObtenerEstadoTickets()
        {
            TicketService servicio = new TicketService();
            List<tkEstados> data = new List<tkEstados>();
            data = servicio.ObtenerEstadosTickets().Data;
            return data;

        }
        [HttpGet]
        [Route("ObtenerOrigenTickets")]
        public List<tkOrigen> ObtenerOrigenTickets()
        {
            TicketService servicio = new TicketService();
            List<tkOrigen> data = new List<tkOrigen>();
            data = servicio.ObtenerEstadosTickets().Data;
            return data;

        }
        [HttpGet]
        [Route("ObtenerSeccionTickets")]
        public List<tkSeccion> ObtenerSeccionTickets()
        {
            TicketService servicio = new TicketService();
            List<tkSeccion> data = new List<tkSeccion>();
            data = servicio.ObtenerSeccionTickets().Data;
            return data;

        }
        [HttpGet]
        [Route("ObtenerProblemaTickets")]
        public List<tkProblemas> ObtenerProblemaTickets(int Categoria)
        {
            TicketService servicio = new TicketService();
            List<tkProblemas> data = new List<tkProblemas>();
            data = servicio.ObtenerProblemasTickets().Data;
            return data.Where(c=>c.CategoriaId ==Categoria).ToList();
           

        }

    }
}
