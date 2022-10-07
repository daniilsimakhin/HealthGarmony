using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MedicineController : Controller
    {
        [HttpGet]
        public async Task<ActionResult<List<MedicineModel>>> GetAll() => await MedicineService.GetAll();

        [HttpGet("{id}")]
        public async Task<ActionResult<MedicineModel>> GetMedicineById(int id)
        {
            return await MedicineService.GetMedicine(id);
        }

        [HttpPost]
        public IActionResult CreateMedicine(MedicineModel medicineModel)
        {
            MedicineService.Add(medicineModel);
            return CreatedAtAction(nameof(CreateMedicine), new { medicineModel });
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMedicine(int id)
        {
            var medicineModel = await MedicineService.GetMedicine(id);

            if (medicineModel == null)
            {
                return NotFound();
            }
            try
            {
                MedicineService.Delete(medicineModel);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
            return NoContent();
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> PutMedicine(int id, MedicineModel medicineModel)
        {
            if (id != medicineModel.Id)
            {
                return BadRequest();
            }

            try
            {
                await MedicineService.Update(medicineModel);
            }
            catch (Exception ex)
            {
                return NotFound(ex);
            }

            return NoContent();
        }
    }
}
