using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace OlympicFlights.DataAccess
{
    /// <summary>
    /// Represents a base class for <see cref="IEntitySet{TEntity}"/> implementations.
    /// </summary>
    /// <typeparam name="TEntity">Entity type.</typeparam>
    public abstract class EntitySetBase<TEntity> : IQueryable<TEntity>, IEntitySet<TEntity>
        where TEntity : class
    {
        public Expression Expression => Queryable.Expression;

        public Type ElementType => Queryable.ElementType;

        public IQueryProvider Provider => Queryable.Provider;

        protected abstract IQueryable<TEntity> Queryable { get; }

        public IEnumerator<TEntity> GetEnumerator() => Queryable.GetEnumerator();

        public abstract TEntity Add(TEntity entity);

        public abstract TEntity Remove(TEntity entity);

        public abstract TEntity Update(TEntity entity);

        IEnumerator IEnumerable.GetEnumerator() => (Queryable as IEnumerable).GetEnumerator();
    }
}
