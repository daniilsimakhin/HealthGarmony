using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Services
{
    public class MedicineDatabaseService : IMedicineDatabaseService<MedicineModel>
    {
        readonly SQLite.SQLiteAsyncConnection _database;

        public MedicineDatabaseService(string dbPath)
        {
            _database = new SQLite.SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<MedicineModel>().Wait();
        }

        public Task<List<MedicineModel>> GetMedicines()
        {
            return _database.Table<MedicineModel>().OrderByDescending(x => x.Id).ToListAsync();
        }

        public Task<int> CreateMedicine(MedicineModel medicine)
        {
            return _database.InsertAsync(medicine);
        }

        public async void DeleteMedicine(MedicineModel medicine)
        {
            await _database.DeleteAsync(medicine);
        }

        public async Task<int> UpdateMedicine(MedicineModel medicine)
        {
            return await _database.UpdateAsync(medicine);
        }

        public async Task<MedicineModel> GetMedicineById(int id)
        {
            return await _database.FindAsync<MedicineModel>(id);
        }
    }
}
