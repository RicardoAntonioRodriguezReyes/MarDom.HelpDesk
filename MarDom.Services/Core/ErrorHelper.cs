using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarDom.Services.Core
{
    public class ErrorHelper
    {
        static Dictionary<int, string> errores = new Dictionary<int, string>();

        public const int NingunErrorEncontrado = 0;
        public const int ErrorInesperado = 1;
        public const int RegistroNoEncontrado = 2;


        static void LlenarCatalogoErrores()
        {
            if (errores.Count > 0)
                return;

            errores.Add(0, "Ningun Error Encontrado");
            errores.Add(1, "Se ha Producido un error inesperado");
            errores.Add(2, "El registro no ha sido encontrado");

        }


        public static string MensajeError(int Error)
        {
            LlenarCatalogoErrores();
            return errores.SingleOrDefault(e => e.Key == Error).Value;
        }
    }
}
