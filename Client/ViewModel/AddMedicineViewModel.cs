using Azure.Core;
using Client.Models;
using Microsoft.Graph;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Client.ViewModel
{
    class AddMedicineViewModel
    {
        string urlAdress = "https://localhost:44377/api/Medicine";
        public async Task AddMedicine(MedicineModel medicine)
        {
            using(var client = new HttpClient())
            {
                var newPostJson = JsonConvert.SerializeObject(medicine);
                var payLoad = new StringContent(newPostJson, Encoding.UTF8, "application/json");
                await client.PostAsync(urlAdress, payLoad);
            }
        }
    }
}
