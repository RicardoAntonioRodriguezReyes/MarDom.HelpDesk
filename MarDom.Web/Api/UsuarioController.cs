using MarDom.Data.Entidades;
using MarDom.Services.Servicios.Administracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MarDom.Web.Api
{
    [RoutePrefix("api/Usuario")]
    public class UsuarioController : ApiController
    {
        [HttpGet]
        [Route("ObtenerUsuarios")]
        [AllowAnonymous]
        public List<Usuario> ObtenerUsuarios()
        {
            UsuarioService servicio = new UsuarioService();
            List<Usuario> data = new List<Usuario>();
            data = servicio.ObtenerUsuarios().Data;
            return data.ToList();

        }


    }
}
