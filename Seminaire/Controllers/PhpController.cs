using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Seminaire.Controllers
{
    public class PhpController : Controller
    {
        public string Test(string page)
        {
            return $"Bonjour {page}.php";
        }

        // GET: *.php
        public string Bonjour(string prenom, string nom)
        {
            return $"Bonjour {prenom} {nom}";
        }
    }
}