using Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IService
    {
        Task<ProgramDto> GetAsync(string id);
        Task AddAsync(ProgramDto item);
        Task UpdateAsync(string id, ProgramDto item);
    }
}
