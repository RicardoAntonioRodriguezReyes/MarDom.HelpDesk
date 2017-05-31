using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarDom.Data.StoreProcedure
{
    public  class ObtenerTickets
    {
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public string Prioridad { get; set; }
        public string Estado { get; set; }
        public string Departamento { get; set; }
        public string Area { get; set; }
        public string Origen { get; set; }
        public string Seccion { get; set; }
        public string Categoria { get; set; }
        public string Problema { get; set; }
        public string Agentecreo { get; set; }
        public string UsuarioSolicita { get; set; }
        public string Agenteasignado { get; set; }
        public bool EstadoTicket { get; set; }

    }
}
