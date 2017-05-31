using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarDom.Data.Core
{
    public class UnitOfWork 
    {
        private DbContext _context;
        private Contexto.ProcedureContext _dataContext;

        private Dictionary<string, object> repositories;

        public UnitOfWork(DbContext contextDb)
        {
            if (contextDb == null)
            {
                throw new ArgumentNullException("No se ha especificado el contexto de datos.");
            }
            this._context = contextDb;
            this._dataContext = new Contexto.ProcedureContext(this._context.Database.Connection.ConnectionString);
        }

        public virtual void Commit()
        {

            _context.SaveChanges();
        }

        public DbContext Db
        {
            get { return this._context; }
        }

        public Contexto.ProcedureContext ProcedureContext
        {
            get { return this._dataContext; }

        }

        public RepositorioBase<T> Repositorio<T>() where T : class
        {
            if (repositories == null)
            {
                repositories = new Dictionary<string, object>();
            }

            var type = typeof(T).Name;

            if (!repositories.ContainsKey(type))
            {
                var repositoryType = typeof(RepositorioBase<>);
                object repositoryInstance = null;

                repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(T)), this._context);
                repositories.Add(type, repositoryInstance);

            }
            return (RepositorioBase<T>)repositories[type];
        }
    }
}
