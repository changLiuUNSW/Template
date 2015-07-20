using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MyNgApp.Data.Infrastructure
{
    public interface IRepository<T> where T : class
    {
        IList<T> Get(params Expression<Func<T, bool>>[] predicate);
        IList<T> GetTop(int take, params Expression<Func<T, bool>>[] predicates);
        IList<T> Include(params Expression<Func<T, object>>[] paths);
        T Get<TKey>(TKey key);
        IList<TResult> Get<TResult>(Expression<Func<T, TResult>> predicate, int take);
        IList<TResult> Distinct<TResult>(Expression<Func<T, TResult>> predicate);
        void Add(params T[] entity);
        void Update(params T[] entity);
        void Delete<TKey>(params TKey[] key);
        void Delete<TKey1, TKey2>(TKey1 firstKey, TKey2 secondKey);
        void Delete<TKey1, TKey2, TKey3>(TKey1 firstKey, TKey2 secondKey, TKey3 thirdKey);
        void RemoveRange(params T[] entities);
        int Count(params Expression<Func<T, bool>>[] predicate);
        bool Any(Expression<Func<T, bool>> predicate);
        T SingleOrDefault(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] paths);
        T FirstOrDefault(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] paths);


        IList<TResult> Filter<TResult>(Expression<Func<T, bool>> where,
            Expression<Func<T, TResult>> select,
            params Expression<Func<T, object>>[] includes);

        IList<TResult> Filter<TResult>(Expression<Func<T, bool>> where,
            Expression<Func<T, TResult>> select,
            int take,
            params Expression<Func<T, object>>[] includes);

        Task<List<T>> GetAsync(params Expression<Func<T, bool>>[] predicates);
        Task<List<T>> GetTopAsync(int top, params Expression<Func<T, bool>>[] predicates);
        Task<List<T>> IncludeAsync(params Expression<Func<T, object>>[] paths);
        Task<List<TResult>> GetAsync<TResult>(Expression<Func<T, TResult>> predicate);
        Task<List<TResult>> GetAsync<TResult>(Expression<Func<T, TResult>> predicate, int take);
        Task<List<TResult>> DistinctAsync<TResult>(Expression<Func<T, TResult>> predicate);
        Task<T> SingleOrDefaultAsync(Expression<Func<T, bool>> predicate);
        IList<TResult> Get<TResult>(Expression<Func<T, TResult>> predicate);
        Task<int> CountAsync(params Expression<Func<T, bool>>[] predicate);
        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);

        Task<List<TResult>> FilterAsync<TResult>(Expression<Func<T, bool>> @where, Expression<Func<T, TResult>> @select,
            params Expression<Func<T, object>>[] includes);
        Task<List<TResult>> FilterAsync<TResult>(Expression<Func<T, bool>> @where, Expression<Func<T, TResult>> @select,
            int take, params Expression<Func<T, object>>[] includes);
    }
}
