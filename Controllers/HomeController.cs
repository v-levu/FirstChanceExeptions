using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading;
using System.Reflection.Emit;
using Newtonsoft.Json;

namespace FirstChanceExeptions.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {            
            SFOEX();
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public void SFOEX()
        {       

            try
            {
                Recursive(0);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            
        }

        private void Recursive(int v)
        {
            Recursive(++v);
        }




        public ActionResult Contact()
        {
            string value = null;
            if (value.Length == 0)
            {
                ViewBag.Message = value;
            }
            

            return View(value);
        }





        public ActionResult Service()
        {

            List<Char> characters = new List<Char>();
            characters.InsertRange(0, new Char[] { 'a', 'b', 'c', 'd', 'e', 'f' });
            for (int ctr = 0; ctr <= characters.Count; ctr++)
                Console.Write("'{0}'    ", characters[ctr]);
            return View(characters);
        }

        
    }
}