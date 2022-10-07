using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Services
{
    public class MedicineService
    {
        private static List<MedicineModel> medicineList;
        public static List<MedicineModel> Medicine
        {
            get { return medicineList; }
            set { medicineList = value; }
        }

        static MedicineService()
        {
            getMedicine();
        }

        public async static Task<List<MedicineModel>> GetAll()
        {
            return await Startup.MedicineDatabase.GetMedicines();
        }

        public async static Task<MedicineModel> GetMedicine(int id)
        {
            return await Startup.MedicineDatabase.GetMedicineById(id);
        }
        public async static void Add(MedicineModel medicineModel)
        {
            await Startup.MedicineDatabase.CreateMedicine(medicineModel);
        }
        public async static void getMedicine()
        {
            medicineList = await Startup.MedicineDatabase.GetMedicines();
        }

        public static void Delete(MedicineModel medicineModel)
        {
            Startup.MedicineDatabase.DeleteMedicine(medicineModel);
        }
        public async static Task<int> Update(MedicineModel medicineModel)
        {
            return await Startup.MedicineDatabase.UpdateMedicine(medicineModel);
        }
    }
}
