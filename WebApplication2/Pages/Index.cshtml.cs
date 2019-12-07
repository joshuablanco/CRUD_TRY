using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WebApplication2.Models;
using Newtonsoft.Json;

namespace WebApplication2.Pages
{
    public class IndexModel : PageModel
    {
        // ctor and field that brings the repository wth the basic operations
        private readonly IRepoCollegeUserModel contexto;
        public IndexModel(IRepoCollegeUserModel contexto)
        {
            this.contexto = contexto;
        }
        
        //Get Action
        public IActionResult OnGetListUsers()
        {
            return new JsonResult(contexto.ListaUsuario());
        }

        //Post Action
        public IActionResult OnPostNewCollegeUser(string values)
        {
            //List<CollegeUserModel> ListaNUsusarios = new List<CollegeUserModel>();
            CollegeUserModel ListaNUsusarios = new CollegeUserModel();
            JsonConvert.PopulateObject(values, ListaNUsusarios);
            contexto.AddCollegeUser(ListaNUsusarios);
            
            return new JsonResult(HttpStatusCode.OK);
        }

        //Put Action
        public IActionResult OnPutUpdateUser(int key,string val)
        {
            //contexto.UpdateUser(key, val);
            
            return new JsonResult(HttpStatusCode.OK);
        }

    }
}
