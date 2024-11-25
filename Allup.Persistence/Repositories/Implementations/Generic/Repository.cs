using Allup.Persistence.Context;
using Allup.Persistence.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Allup.Persistence.Repositories.Implementations;

public class Repository<T> : IRepository<T> where T : BaseEntity
{
    private readonly AppDbContext _context;
    private readonly DbSet<T> _table;

    public Repository(AppDbContext context)
    {
        _context = context;
        _table = _context.Set<T>();
    }

    public async Task<T> CreateAsync(T entity)
    {
        var entityEntry = await _table.AddAsync(entity);

        return entityEntry.Entity;
    }

    public T Delete(T entity)
    {
        var entityEntry = _table.Remove(entity);

        return entityEntry.Entity;
    }

    public IQueryable<T> GetAll(Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null)
    {
        IQueryable<T> query = _table.AsQueryable<T>();

        if (include != null)
            query = include(query);

        return query;

    }

    public async Task<T?> GetAsync(Expression<Func<T, bool>> expression, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null)
    {
        IQueryable<T> query = _table.AsQueryable<T>();

        if (include != null)
            query = include(query);

        var entity = await query.FirstOrDefaultAsync(expression);

        return entity;
    }

    public async Task<T?> GetAsync(int id, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null)
    {
        IQueryable<T> query = _table.AsQueryable<T>();

        if (include != null)
            query = include(query);

        var entity = await query.FirstOrDefaultAsync(x => x.Id == id);

        return entity;
    }

    public IQueryable<T> GetFilter(Expression<Func<T, bool>> expression, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null)
    {
        IQueryable<T> query = _table.AsQueryable<T>();

        if (include != null)
            query = include(query);

        query = query.Where(expression);

        return query;
    }

    public async Task<bool> IsExistAsync(Expression<Func<T, bool>> expression, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null)
    {
        IQueryable<T> query = _table.AsQueryable<T>();

        if (include != null)
            query = include(query);

        var result = await query.AnyAsync(expression);

        return result;
    }

    public IQueryable<T> OrderBy(IQueryable<T> query, Expression<Func<T, object>> expression)
    {
        query = query.OrderBy(expression);

        return query;
    }

    public IQueryable<T> OrderByDescending(IQueryable<T> query, Expression<Func<T, object>> expression)
    {
        query = query.OrderByDescending(expression);

        return query;
    }

    public IQueryable<T> Paginate(IQueryable<T> query, int limit, int page = 1)
    {
        query = query.Skip((page - 1) * limit).Take(limit);

        return query;
    }

    public async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }

    public T Update(T entity)
    {
        var entityEntry = _table.Update(entity);

        return entityEntry.Entity;
    }
}
