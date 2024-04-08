using Microsoft.AspNetCore.Mvc;

namespace APBD_Zadanie_4.Controllers
{
    [Route("api/animals")]
    [ApiController]

    public class AnimalsController : ControllerBase
    {
        public ActionResult<IEnumerable<Animal>> GetAnimals()
        {
            return Ok(AnimalsDataStore.Current.Animals);
            //comment test
        }
    }
}