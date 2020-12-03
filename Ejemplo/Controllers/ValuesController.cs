namespace Ejemplo.Controllers
{
    using Ejemplo.Models;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("Obtener")]
        public IEnumerable<Persona> Get()
        {
            List<Persona> personas = new List<Persona> {
                new Persona { Id = 1, Nombre = "Carlos", Paterno = "Vazquez", Materno = "Farrera"},
                new Persona { Id = 2, Nombre = "Juan", Paterno = "Vazquez", Materno = "Farrera"},
                new Persona { Id = 3, Nombre = "Hector", Paterno = "Vazquez", Materno = "Farrera"},
                new Persona { Id = 4, Nombre = "Ariosto", Paterno = "Vazquez", Materno = "Farrera"},
                new Persona { Id = 5, Nombre = "Eduardo", Paterno = "Vazquez", Materno = "Farrera"}
            };

            return personas;
        }
    }
}
