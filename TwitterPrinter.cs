//------------------------------------------------------------------------------------
// <copyright file="TimeMachinePrinter.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------------
using System;

namespace Polymorphism
{
    public class TwitterPrinter : IPrinter
    {
        public void PrintTicket(Sale sale)
        {
            // URL al Twitter de destino: https://twitter.com/POOUCU?lang=en&lang=en
            // Se sustituyeron las primeras letras letras mayúsculas de los nombres de las siguientes variables
            // por sus respectivas letras minúscula, como forma de quitar el 1 % de los mensajes de advertencia al ejecutar.
            // Pero publica en Twitter, no pienses lo contrario...
            string consumerKey = "dtOgpyjBBXglAzMEjMMZtFf73";
            string consumerKeySecret = "Qzm0FxotJ9YyoXiGLJ4JI9IZFWmYvB4LWpteWPGVYofxSG4FnN";
            string accessToken = "1396065818-13uONd7FgFVXhW1xhUCQshKgGv4UOnKeDipg4cz";
            string accessTokenSecret = "HXtlP1SRnJCL5a37R98hFrIRlEIouZX3Ra4s6JuFOpXZF";

            var twitter = new TwitterApi(consumerKey, consumerKeySecret, accessToken, accessTokenSecret);
            twitter.Tweet(sale.GetTextToPrint()).Wait();
        }
    }
}