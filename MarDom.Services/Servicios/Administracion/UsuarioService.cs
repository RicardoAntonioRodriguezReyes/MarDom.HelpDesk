using MarDom.Data.Entidades;
using MarDom.Services.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarDom.Services.Servicios.Administracion
{
    public class UsuarioService : BaseService
    {
        public ServiceResult ObtenerUsuarios()
        {
            ServiceResult result = new ServiceResult();

            try
            {
                result.Data = base.uow.Repositorio<Usuario>().GetAll().ToList();
                result.Success = true;
                result.ErrorCode = ErrorHelper.NingunErrorEncontrado;
                result.Message = ErrorHelper.MensajeError(ErrorHelper.NingunErrorEncontrado);
            }
            catch (Exception ex)
            {

                result.RegistrarError(ex);
                result.Data = "Ocurrió un error cargando tickets.";
            }
            return result;
        }
    }
}
