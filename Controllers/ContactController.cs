using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvck.Models;
using dllFIle;
using System;
namespace mvck.Controllers
{
    public class ContactController: Controller
    {
       public IActionResult ListofContacts(){
            dllFIle.ConsoleHandler func  = new dllFIle.ConsoleHandler();
         string text = System.IO.File.ReadAllText(@"C:\Users\manandsai\text.txt");
        ViewBag.TEXT = text;
        return View();
       
        }

     public IActionResult createContact(){
     return View();
     }
    }

}