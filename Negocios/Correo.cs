using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HotelRivera_Proyecto.Negocios
{
    public class Correo
    {
        public static void RecuperarContra(string contra)
        {
            const string remitente = "pruebahotel12@gmail.com";
            const string contraseña = "tiwidzxyywisgfiz";
            const string asunto = "Restauracion de usuario Hotel Rivera";
            string cuerpo = "Usuario admin su contraseña ha sido reestablecida a : " + contra;
            string destinatario = "omar12301moya@gmail.com";

            // Configurar las credenciales de autenticación

            // Configurar el servidor SMTP de Gmail
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);//servidor smtp, y puerto a usar
            //tambien varia dependiendo de que tipo de correo se usa
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential(remitente, contraseña);

            // Crear el mensaje de correo electrónico
            MailMessage mailMessage = new MailMessage(remitente, destinatario, asunto, cuerpo);
            try
            {
                // Enviar el correo electrónico
                smtpClient.Send(mailMessage);
                Console.WriteLine("Correo electrónico enviado con éxito.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al enviar el correo electrónico: " + ex.Message);
            }
        }
    }
}
