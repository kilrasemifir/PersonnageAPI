using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PersonnageAPI.Controllers
{
    using Models;
    using Services;

    [Route("personnages")]
    [ApiController]
    public class PersonnageController : ControllerBase
    {
        private PersonnageService service;

        public PersonnageController(PersonnageService service)
        {
            this.service = service;
        }

        [HttpPost]
        [Route("")]
        public Personnage Save([FromBody] Personnage p)
        {
            return this.service.Sauvegarde(p);
        }

        [HttpGet]
        [Route("")]
        public IEnumerable<Personnage> FindAll()
        {
            return this.service.TrouverTous();
        }

        [HttpGet]
        [Route("{id}")]
        public Personnage FindById(int id)
        {
            return this.service.TrouverUn(id);
        }

        [HttpPut]
        [Route("")]
        public Personnage Update([FromBody] Personnage p)
        {
            return this.service.Modifier(p);
        }

        [HttpDelete]
        [Route("{id}")]
        public void Delete(int id)
        {
            this.service.Supprimer(id);
        }
    }
}