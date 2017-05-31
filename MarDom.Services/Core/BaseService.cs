using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarDom.Services.Core
{
    public abstract class BaseService
    {
        protected MarDom.Data.Core.UnitOfWork uow;

        public BaseService()
        {
            uow = new Data.Core.UnitOfWork(new MarDom.Data.Contexto.HelpDeskModel());
        }
        

   

    }
}
