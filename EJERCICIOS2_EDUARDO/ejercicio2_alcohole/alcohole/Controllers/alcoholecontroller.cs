using alcohole.Domain.Interface;
using Microsoft.AspNetCore.Mvc;
/*Nombre de la escuela: Universidad Tecnológica Metropolitana
Profesor: Joel Chuc Uc
Materia: Aplicaciones web orientadas a servicios
Alumna: Eduardo Emanuel Herrera Pech
cuarto cuatrimestre
Grupo: C
Parcial 2
Actividad*/
namespace alcohole.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class alcoholecontroller : ControllerBase
    {    
              [HttpGet]
               [Route("alcolimetroyuc")]
        
                       public IActionResult alcolimetroyuc(string bebida,int cantidad, int peso)
        {
            
            var resultado = new drink();
                      resultado.calcularalcoholingerido(bebida,cantidad);
            if(bebida.ToLower()!= "brandy" && bebida.ToLower()!="cerveza" && bebida.ToLower()!="vino" && bebida.ToLower()!="cava" && bebida.ToLower()!="vermu" && bebida.ToLower()!="licor")
            {
                return Ok(" the  drink is a incorrect, insert new.");
            }
            resultado.calcularP(peso);
            
            return Ok(resultado.respuesta());
        }
        
    
    }
}
