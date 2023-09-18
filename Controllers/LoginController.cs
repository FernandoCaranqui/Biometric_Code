using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using Biometrico.Models.DAO;
using Biometrico.Utils;

namespace Biometrico.Controllers
{
    public class LoginController: Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Login(FormCollection formulario)
        {
            Captcha objCaptcha = new Captcha();
            //optenemos de la vista los datos del formulario (cedula, correo, terminos y condiciones)
            string cedula = formulario["cedula"];
            string correo = formulario["correo"];
            string numero_celular = formulario["numero_celular"];
            string terminos = formulario["terminos"];
            var responseCaptcha = formulario["g-recaptcha-response"];
            //validamos que el número de cedula sea un número 
            if (!comprobarNumero(cedula))
            {
                //retornamos a la vista y decimos que ingrese un número de cedula válido
                ViewBag.error = "Ingrese un número de cedula válido";
                return View("Index");
            }
            //validamos el número de cedula
            if (!Validacion.VerificarIdentificacion(cedula))
            {
                //retornamos a la vista y decimos que el número de cedula es incorrecto
                ViewBag.error = "El número de cedula es incorrecto";
                return View("Index");
            }
            //verificamos el captcha
            
            
            
            
            return null;
        }
        
        //validador de números
        public bool comprobarNumero(string numero)
        {
            bool esNumero = true;
            if (numero.Length > 0)
            {
                foreach (char c in numero)
                {
                    if (!Char.IsDigit(c))
                    {
                        esNumero = false;
                        break;
                    }
                }
            }
            else
            {
                esNumero = false;
            }
            return esNumero;
        }
    }
}