using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Repositorio;

namespace Negocio
{
    public class PersonaNego
    {
        public void GuardarPersona(Persona persona)
        {
            PersonaRepo personaRepo = new PersonaRepo();
            personaRepo.GuardarPersona(persona);
        } 
    }
}
