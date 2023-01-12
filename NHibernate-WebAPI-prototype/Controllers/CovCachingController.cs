using Microsoft.AspNetCore.Mvc;
using NHibernate_WebAPI_prototype.Models;
using NHibernate_WebAPI_prototype.Services;

namespace NHibernate_WebAPI_prototype.Controllers
{
    [ApiController]
    [Route("api/")]
    [Produces("application/json")]
    public class CovCachingController : ControllerBase
    {
        private readonly ICovCachingService covCachingService;
        public CovCachingController(ICovCachingService covCachingService)
        {
            this.covCachingService = covCachingService;
        }

        [HttpGet]
        [Route("getallpersons")]
        public IList<Person> GetPersons()
        {
            return covCachingService.GetPersons();
        }

        [HttpGet]
        [Route("getallinsurances")]
        public IList<Insurance> GetInsurance()
        {
            return covCachingService.GetInsurances();
        }

        [HttpGet]
        [Route("getadultpersonbyname")]
        public IList<Person> GetAdultPersonsByName(string name)
        {
            return covCachingService.GetAdultPersonsByName(name);
        }

        [HttpPut]
        [Route("addPersonWithInsurances")]
        public ActionResult addPerson([FromBody]Person person)
        {
            if (covCachingService.AddPerson(person))
            {
                return Ok("Succesvol toegevoegd");
            }
            return BadRequest("Kan persoon niet toevoegen, controleer of verzekering wel bestaat (verzekering id)");
        }

    }
}