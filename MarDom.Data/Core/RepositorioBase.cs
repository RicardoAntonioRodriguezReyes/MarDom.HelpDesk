
using EntityFrameworkExtras.EF5;
using MarDom.Data.Helpers;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MarDom.Data.Core
{
    public class RepositorioBase<Tentity> where Tentity : class
    {
        private DbContext context;

        private DbSet<Tentity> Entity { get; set; }

        public RepositorioBase(DbContext contextDb)
        {
            if (contextDb == null)
            {
                throw new ArgumentNullException("No se ha especificado la base de datos.");
            }
            this.context = contextDb;
            this.Entity = context.Set<Tentity>();

        }



        public virtual IQueryable<Tentity> GetAll()
        {
            return this.Entity;
        }

        public virtual Tentity GetByID(int id)
        {
            return Entity.Find(id);
        }

        public virtual void Add(Tentity item)
        {
            Entity.Add(item);
        }

        public virtual void Update(Tentity entity)
        {
            Entity.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
        }
        public virtual void Remove(object EntityId)
        {
            Tentity entityToDelete = this.Entity.Find(EntityId);
            this.Remove(entityToDelete);

        }
        public virtual void Remove(Tentity entity)
        {
            if (context.Entry(entity).State == EntityState.Detached)
            {
                Entity.Attach(entity);
            }

            this.Entity.Remove(entity);
        }

        public Tentity Find(Expression<Func<Tentity, bool>> predicate)
        {
            return this.Entity.SingleOrDefault(predicate);

        }

        public IQueryable<Tentity> Search(Expression<Func<Tentity, bool>> predicate = null)
        {
            return Entity.Where(predicate);

        }



        /// <summary>
        /// Ejecutar procedimientos que devuelven una coleccion de datos
        /// </summary>
        /// <typeparam name="TSource">Modelo de datos donde se van a extraer las propiedades a mapear</typeparam>
        /// <typeparam name="TDestino">Modelo que representa el procedimiento de la base de datos </typeparam>
        /// <param name="model">Modelo con la imformacion cargada</param>
        /// <returns></returns>
        public IEnumerable<TSource> ExecWithStoreProcedureResultSet<TSource, TDestino>(TSource model)
        {
            IEnumerable<TSource> data;
            try
            {
                var procedimiento = MapStoreProcedure<TSource, TDestino>.Map(model);
                //El metodo ExecuteStoredProcedure aparece cuando se agrega la referencia EntityFrameworkExtras.EF6
                data = context.Database.ExecuteStoredProcedure<TSource>(procedimiento);

            }
            catch (Exception)
            {

                throw;
            }

            return data;

        }




        /// <summary>
        ///   Ejecutar procedimientos  [INSERT , UPDATE ,DELETE ] 
        /// </summary>
        /// <typeparam name="TSource">Modelo de datos donde se van a extraer las propiedades a mapear</typeparam>
        /// <typeparam name="TDestino">Modelo que representa el procedimiento de la base de datos </typeparam>
        /// <param name="model">Modelo con la imformacion cargada</param>
        /// <returns>El estado de la ejecucion del procedimiento</returns>
        public bool ExecWithStoreProcedure<TSource, TDestino>(TSource model)
        {
            bool estado = false;
            try
            {
                var procedimiento = MapStoreProcedure<TSource, TDestino>.Map(model);
                //El metodo ExecuteStoredProcedure aparece cuando se agrega la referencia EntityFrameworkExtras.EF6
                context.Database.ExecuteStoredProcedure(procedimiento);
                estado = true;
            }
            catch (Exception)
            {

                throw;
            }

            return estado;
        }


    }
}
