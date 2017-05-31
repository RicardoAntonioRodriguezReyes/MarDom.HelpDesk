using MarDom.Services.Servicios.Administracion;
using MarDom.Services.Servicios.Ticket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarDom.Test
{
    public class Program
    {
        static void Main(string[] args)
        {
            TicketService servicio = new TicketService();
            var tickets = servicio.ObtenerTickets().Data;
            var categoriaTickets = servicio.ObtenerCategoriaTickets().Data;

            UsuarioService servicioUsuario = new UsuarioService();
            var usuarios = servicioUsuario.ObtenerUsuarios().Data;
            

            foreach (var item in tickets)
            {
                Console.WriteLine("Ticket : {0}  {1}", "Descripcion:" , item.Descripcion);
            }

            foreach (var item in categoriaTickets)
            {
                Console.WriteLine("Categoria : {0}  {1}", "Descripcion:", item.Descripcion);
            }


            foreach (var item in usuarios)
            {
                Console.WriteLine("Usuario : {0}  {1}", "Descripcion:", item.UserName);
            }
            Console.ReadKey();
        }
    }
}
