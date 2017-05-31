using MarDom.Data.Entidades;
using MarDom.Services.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarDom.Services.Servicios.Ticket
{
   public class TicketService : BaseService
    {
        public ServiceResult ObtenerTickets()
        {
            ServiceResult result = new ServiceResult();

            try
            {
                result.Data = base.uow.ProcedureContext.ObtenerTickets().ToList();
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

        public ServiceResult ObtenerCategoriaTickets()
        {
            ServiceResult result = new ServiceResult();

            try
            {
                result.Data = base.uow.Repositorio<tkCategoria>().GetAll().ToList();
                result.Success = true;
                result.ErrorCode = ErrorHelper.NingunErrorEncontrado;
                result.Message = ErrorHelper.MensajeError(ErrorHelper.NingunErrorEncontrado);
            }
            catch (Exception ex)
            {

                result.RegistrarError(ex);
                result.Data = "Ocurrió un error cargando categoria.";
            }
            return result;
        }
        public ServiceResult ObtenerPrioridadTickets()
        {
            ServiceResult result = new ServiceResult();

            try
            {
                result.Data = base.uow.Repositorio<tkPrioridad>().GetAll().ToList();
                result.Success = true;
                result.ErrorCode = ErrorHelper.NingunErrorEncontrado;
                result.Message = ErrorHelper.MensajeError(ErrorHelper.NingunErrorEncontrado);
            }
            catch (Exception ex)
            {

                result.RegistrarError(ex);
                result.Data = "Ocurrió un error cargando categoria.";
            }
            return result;
        }
        public ServiceResult ObtenerEstadosTickets()
        {
            ServiceResult result = new ServiceResult();

            try
            {
                result.Data = base.uow.Repositorio<tkEstados>().GetAll().ToList();
                result.Success = true;
                result.ErrorCode = ErrorHelper.NingunErrorEncontrado;
                result.Message = ErrorHelper.MensajeError(ErrorHelper.NingunErrorEncontrado);
            }
            catch (Exception ex)
            {

                result.RegistrarError(ex);
                result.Data = "Ocurrió un error cargando categoria.";
            }
            return result;
        }
        public ServiceResult ObtenerOrigenTickets()
        {
            ServiceResult result = new ServiceResult();

            try
            {
                result.Data = base.uow.Repositorio<tkOrigen>().GetAll().ToList();
                result.Success = true;
                result.ErrorCode = ErrorHelper.NingunErrorEncontrado;
                result.Message = ErrorHelper.MensajeError(ErrorHelper.NingunErrorEncontrado);
            }
            catch (Exception ex)
            {

                result.RegistrarError(ex);
                result.Data = "Ocurrió un error cargando categoria.";
            }
            return result;
        }

        public ServiceResult ObtenerSeccionTickets()
        {
            ServiceResult result = new ServiceResult();

            try
            {
                result.Data = base.uow.Repositorio<tkSeccion>().GetAll().ToList();
                result.Success = true;
                result.ErrorCode = ErrorHelper.NingunErrorEncontrado;
                result.Message = ErrorHelper.MensajeError(ErrorHelper.NingunErrorEncontrado);
            }
            catch (Exception ex)
            {

                result.RegistrarError(ex);
                result.Data = "Ocurrió un error cargando categoria.";
            }
            return result;
        }

        public ServiceResult ObtenerProblemasTickets()
        {
            ServiceResult result = new ServiceResult();

            try
            {
                result.Data = base.uow.Repositorio<tkProblemas>().GetAll().ToList();
                result.Success = true;
                result.ErrorCode = ErrorHelper.NingunErrorEncontrado;
                result.Message = ErrorHelper.MensajeError(ErrorHelper.NingunErrorEncontrado);
            }
            catch (Exception ex)
            {

                result.RegistrarError(ex);
                result.Data = "Ocurrió un error cargando categoria.";
            }
            return result;
        }

    }


}
