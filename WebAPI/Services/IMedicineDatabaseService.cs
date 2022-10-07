using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Services
{
    public interface IMedicineDatabaseService<T>
    {
        Task<int> CreateMedicine(T medicine);
        void DeleteMedicine(T medicine);
        Task<List<T>> GetMedicines();
        Task<T> GetMedicineById(int id);
        Task<int> UpdateMedicine(T medicine);
    }
}