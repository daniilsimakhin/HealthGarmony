using Client.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Client.ViewModel
{
    class ChangeMedicineViewModel
    {
        string urlAdress = "https://localhost:44377/api/Medicine";
        public async Task ChangeMedicine(MedicineModel medicine, string id)
        {
            using (var client = new HttpClient())
            {
                var newPostJson = JsonConvert.SerializeObject(medicine);
                var payLoad = new StringContent(newPostJson, Encoding.UTF8, "application/json");
                await client.PutAsync($"{urlAdress}/{id}", payLoad);
            }
        }
    }
}
