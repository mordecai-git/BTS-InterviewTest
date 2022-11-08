using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InterviewTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly IPerson _person;

        public PersonsController(IPerson person) => _person = person;

        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            var person = _person.GetById(id);

            if (person == null) return NotFound();

            return Ok(person);
        }

        [HttpPost]
        public ActionResult CreatePerson(Person model)
        {
            var response = _person.Insert(model);

            return Ok(response);
        }

        [HttpGet]
        public ActionResult ListPersons()
        {
            var response = _person.ListPersons();

            return Ok(response);
        }
    }
}
