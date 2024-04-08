using Microsoft.AspNetCore.Mvc;

namespace APBD_Zadanie_4.Controllers
{
    [Route("api/animals")]
    [ApiController]

    public class AnimalsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Animal>> GetAnimals()
        {
            return Ok(AnimalsDataStore.Current.Animals);
            //comment test
        }

        [HttpGet("{id}")]
        public ActionResult<Animal> GetAnimal(int id)
        {
            var animalToReturn = AnimalsDataStore.Current.Animals.FirstOrDefault(x => x.Id == id);

            if (animalToReturn == null)
            {
                return NotFound();
            }

            return Ok(animalToReturn);
        }

        [HttpPost]
        public ActionResult<Animal> CreateAnimal(AnimalCreationDTO animal) //tp samo co animal ale bez id
        {
            var maxAnimalId = tmp;
            
            //to do put -> return NoContent();
        }
    }
}