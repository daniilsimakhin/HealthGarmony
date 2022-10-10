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
    class DeleteMedicineViewModel
    {
        string urlAdress = "https://localhost:44377/api/Medicine";
        public async Task DeleteMedicine(string id)
        {
            using (var client = new HttpClient())
            {
                using HttpResponseMessage response = await client.DeleteAsync($"{urlAdress}/{id}");
            }
        }
    }
}
