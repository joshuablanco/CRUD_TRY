using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public interface IRepoCollegeUserModel
    {
        List<CollegeUserModel> ListaUsuario();
        void AddCollegeUser(CollegeUserModel listing);
        void UpdateUser(int key, string value);
    }
}
