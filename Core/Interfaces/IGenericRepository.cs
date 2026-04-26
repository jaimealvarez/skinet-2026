using System;
using System.Runtime.CompilerServices;
using Core.Entities;

namespace Core.Interfaces;

public interface IGenericRepository<T> where T:BaseEntity
{
    Task<T?> GetByIdAsync(int id);
    Task<IReadOnlyList<T>> ListAllAsync();
    Task<T?> GetWithSpec(ISpecification<T> spec);
    Task<IReadOnlyList<T>> ListAllAsyncWithSpec(ISpecification<T> spec);
    Task<TResult?> GetWithSpec<TResult>(ISpecification<T, TResult> spec);
    Task<IReadOnlyList<TResult>> ListAllAsyncWithSpec<TResult>(ISpecification<T, TResult> spec);
    void Add(T entity);
    void Update(T entity);
    void Remove(T entity);
    Task<bool> SaveAllAsync();
    bool Exists(int id);
    Task<int> CountAsync(ISpecification<T> spec);
}
