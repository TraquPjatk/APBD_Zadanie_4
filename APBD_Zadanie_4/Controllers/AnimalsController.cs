using APBD_Zadanie_4.DTO;
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
            var animalToReturn = AnimalsDataStore.Current.Animals.FirstOrDefault(a => a.Id == id);

            if (animalToReturn == null)
            {
                return NotFound();
            }

            return Ok(animalToReturn);
        }
        

        [HttpPost]
        public ActionResult<Animal> CreateAnimal(AnimalCreationDTO animalDTO)
        {
            var maxAnimalId = AnimalsDataStore.Current.Animals.Max(a => a.Id);
            var animal = new Animal
            {
                Id = maxAnimalId + 1,
                Name = animalDTO.Name,
                Category = animalDTO.Category,
                Weight = animalDTO.Weight,
                Color = animalDTO.Color,
                // Visits = animalDTO.Visits
            };
            
            AnimalsDataStore.Current.Animals.Add(animal);
            
            return StatusCode(StatusCodes.Status201Created);
        }
        
        [HttpPut("{id:int}")]
        public ActionResult<Animal> UpdateAnimal(int id, AnimalCreationDTO animalDTO)
        {
            var animalToUpdate = AnimalsDataStore.Current.Animals.FirstOrDefault(a => a.Id == id);

            animalToUpdate.Name = animalDTO.Name;
            animalToUpdate.Category = animalDTO.Category;
            animalToUpdate.Weight = animalDTO.Weight;
            animalToUpdate.Color = animalDTO.Color;
            
            // ↓ To jest wariant bardziej wykładowy, ale trochę nie rozumiem, czemu miałby on być lepszy od rozwiązania powyżej,
            //      w zasadzie to jest to hybryda z wykorzystaniem DTO, którego konceptu per se również nie rozumiem, więc będę wdzięczny za komentarz do zadania.
            //
            // var animal = new Animal
            // {
            //     Id = animalToUpdate.Id,
            //     Name = animalDTO.Name,
            //     Category = animalDTO.Category,
            //     Weight = animalDTO.Weight,
            //     Color = animalDTO.Color,
            //     // Visits = animalDTO.Visits
            // };
            //
            //
            // AnimalsDataStore.Current.Animals.Remove(animalToUpdate);
            // AnimalsDataStore.Current.Animals.Add(animal);

            return NoContent();
        }
    }
}