using Domain;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace RepositoryPattern_CRUD.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly ILogger<WeatherForecastController> _logger;
        public WeatherForecastController(IUnitOfWork unitOfWork, ILogger<WeatherForecastController> logger)
        {
            this.unitOfWork = unitOfWork;
            _logger = logger;
        }
        

        [HttpGet]
        public IEnumerable<Person> GetAllPersons()
        {
            return unitOfWork.Person.GetAll();
        }

        [HttpPost]
        public void Persons(Person person)
        {
            unitOfWork.Person.Add(person);
            
            unitOfWork.Save();
        }

        [HttpPost("Update")]
        public void UpdatePersons(Person person)
        {
            unitOfWork.Person.Update(person);
            unitOfWork.Address.Update(person.Address);
            unitOfWork.Email.Update(person.Emails.First());
            unitOfWork.Save();
        }

        [HttpDelete("Delete")]
        public void DeletePersons(Person person)
        {
            unitOfWork.Person.Remove(person);
            //unitOfWork.Save();
        }

        [Route("GetAdults")]
        [HttpGet]
        public IEnumerable<Person> GetAdultPersons()
        {
            return unitOfWork.Person.GetAdultPersons();
        }
    }
}