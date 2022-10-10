using Azure.Core;
using Client.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Client.ViewModel
{
    class ListMedicineViewModel
    {
        string urlAdress = "https://localhost:44377/api/Medicine";
        List<MedicineModel> medicines;

        public async Task<List<MedicineModel>> UpdateTable()
        {
            using (var client = new HttpClient())
            {
                using HttpResponseMessage result = await client.GetAsync(urlAdress);
                var content = result.Content.ReadAsStringAsync().Result;
                medicines = JsonConvert.DeserializeObject<List<MedicineModel>>(content);
                return medicines;
            }
        }
    } 
}
