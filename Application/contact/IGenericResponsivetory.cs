using HL.Test.Domain.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HL.Application.contact
{
    public interface IGenericResponsivetory<T> where T : BaseEntity
    {
        Task<IReadOnlyCollection<List<T>>> GetAsync();
        Task<T> GetByIdAsync(int id);
        Task<T> CreateAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(int id);


    }
}
