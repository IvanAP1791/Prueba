using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace Pruebapractica
{
    public partial class Presentacion1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        private void GuardarPersona()
        {
            Persona persona = new Persona();

            persona.Nombre = "Ivan";
            persona.Apellido = "Palomeque";
            persona.Documento = "36151621";
            persona.Edad = 27;

            LblNombre.Text = "Nombre";
            TxtNombre.Text = persona.Nombre;
            LblApellido.Text = "Apellido";
            TxtApellido.Text = persona.Apellido;
            LblDocumento.Text = "Documento";
            TxtDocumento.Text = persona.Documento;
            LblEdad.Text = "Edad";
            TxtEdad.Text = persona.Edad.ToString();

            PersonaNego personaNego = new PersonaNego();
            personaNego.GuardarPersona(persona);

            
        }
        
        protected void Guardar_Click(object sender, EventArgs e)
        {
            GuardarPersona();
        }
    }
}