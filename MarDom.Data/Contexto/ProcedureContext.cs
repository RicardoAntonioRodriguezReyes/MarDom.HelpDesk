using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Reflection;
using System.Data.Linq.Mapping;

namespace MarDom.Data.Contexto
{
    public class ProcedureContext : DataContext
    {
        public ProcedureContext(String SqlConnectionString) : base(SqlConnectionString) { }

        [Function(Name = "[dbo].[ObtenerTickets]")]
        public ISingleResult<StoreProcedure.ObtenerTickets> ObtenerTickets()
        {
            IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
            return ((ISingleResult<StoreProcedure.ObtenerTickets>)(result.ReturnValue));
        }


    }
}
