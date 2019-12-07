using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data;

namespace WebApplication2.Models
{
    public class RepoCollegeUserModel : IRepoCollegeUserModel
    {
        private readonly ApplicationDbContext context;

        public RepoCollegeUserModel(ApplicationDbContext context)
        {
            this.context = context;
        }
        
        //public List<CollegeUserModel> ListaUsusarios { get; set; }

        public List<CollegeUserModel> ListaUsuario()
        {
            //
            /*context.ContextCollegeUsers.Add(new CollegeUserModel
            {
                Name = "Joshuass",
                LastName = "Blanco",
                College = "UIS"
            });
            context.SaveChanges();*/

            /*
            ApplicationDbContext usu = context.ContextCollegeUsers.Add(new CollegeUserModel()
            {
                Id = 0,
                Name = "Joshua",
                LastName = "Blanco",
                College = "UIS"
            });
            return usu;

            //List<CollegeUserModel> ListaUsusarios = new List<CollegeUserModel>();
            /*ListaUsusarios.Add(new CollegeUserModel()
            {
                Id = 0,
                Name = "Joshua",
                LastName = "Blanco",
                College = "UIS"
            }
            );
            ListaUsusarios.Add(new CollegeUserModel()
            {
                Id = 1,
                Name = "Sergio",
                LastName = "Vega",
                College = "UIS"
            });
            ListaUsusarios.Add(new CollegeUserModel()
            {
                Id = 2,
                Name = "Walter",
                LastName = "Mercado",
                College = "UNAB"
            });*/
            return context.ContextCollegeUsers.ToList();
        }

        public void AddCollegeUser(CollegeUserModel listing)
        {
            /*
            context.ContextCollegeUsers.Add(new CollegeUserModel()
            {
                Id = listing.Id,
                Name = listing.Name,
                LastName = listing.LastName,
                College = listing.College
            });*/
            context.ContextCollegeUsers.Add(listing);
            context.SaveChanges();
        }

        public void UpdateUser(int key, string value)
        {
            /*number of the entity
            CollegeUserModel User = context.ContextCollegeUsers.Find(key);
            //conversion to object
            JsonConvert.PopulateObject(value, User);

            User.Name = User.Name == null ? null : context.ContextCollegeUsers.Where(s => s.Id == User.Id).FirstOrDefault();
            */
        }
    }
}
