using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMC_API.Controllers
{
    /*Nombre de la escuela: Universidad Tecnologica Metropolitana
     
    Asignatura: Aplicaciones Web Orientadas a Objetos


    Nombre del Maestro: Chuc Uc Joel Ivan


    Nombre de la actividad: Actividad 1 "Calcular IMC"


    Nombre del alumno: Fabian Francisco Aguilar Rivero


    Cuatrimestre: 4


    Grupo: B


    Parcial: 1
    */

    [Route("api/[controller]")]
    [ApiController]
    public class IMC : ControllerBase
    {
        [HttpGet]
        public IActionResult IMCFinal(double altura, double peso)
        {
            var R = new Persona();
            R.Peso = peso;
            R.Altura = altura / 100;
            var AFinal = R.Altura;
            var IMC = peso / (AFinal * AFinal);
            var Clasificacion = "";


            if (IMC < 18.5)
            {
                Clasificacion = "Tú peso es inferior a lo normal";
            }
            else
            {
                if (IMC >= 18.5 && IMC <= 24.9)
                {
                    Clasificacion = "Tú peso es normal";
                }
                else
                {
                    if (IMC >= 25.0 && IMC <= 29.9)
                    {
                        Clasificacion = "Tú peso es superior al normal";
                    }
                    else
                    {
                        Clasificacion = "Oh no, tienes obesidad, deberias ir con nutriologo";
                    }
                }
            }
            var Resultado = "Tú IMC es: " + Convert.ToString(IMC) + "y tú composición corporal es: " + Clasificacion;
            return Ok(Resultado);
        }
    }
}
