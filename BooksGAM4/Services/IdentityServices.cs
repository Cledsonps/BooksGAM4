using BooksGAM4.Areas.ViewModels;
using BooksGAM4.Data.DAL;
using BooksGAM4.Models;
using BooksGAM4.ViewModels;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace BooksGAM4.Services
{
    public class IdentityServices
    {

        public List<UserAndRolesAdmin> Listagem()
        {
            List<UserAndRolesAdmin> lista = new List<UserAndRolesAdmin>();
            UserAndRolesAdmin item;

            IdentityDAL objDAL = new IdentityDAL();

            string sql = "SELECT aspnetusers.Id as UserId, aspnetusers.UserName, " +
                            "aspnetuserroles.UserId as UnityUserId, aspnetuserroles.RoleId as UnitynRoleId, " +
                            "aspnetroles.Id as RoleId, aspnetroles.Name as RoleName " +
                            "FROM((aspnetuserroles " +
                            "INNER JOIN aspnetusers ON aspnetusers.Id = aspnetuserroles.UserId) " +
                            "INNER JOIN aspnetroles ON aspnetroles.Id = aspnetuserroles.RoleId); ";
            DataTable dados = objDAL.RetornarDataTable(sql);

            for (int i = 0; i < dados.Rows.Count; i++)
            {
                item = new UserAndRolesAdmin()
                {
                    UserId = dados.Rows[i]["UserId"].ToString(),
                    UserName = dados.Rows[i]["UserName"].ToString(),
                    RoleId = dados.Rows[i]["RoleId"].ToString(),
                    RoleName = dados.Rows[i]["RoleName"].ToString()
                };

                lista.Add(item);
            }
            return lista;
        }

        public UserAndRolesAdmin FindUserAndRoles(string userName)
        {
            var userAndRolesAdmin = new UserAndRolesAdmin();

            IdentityDAL objDAL = new IdentityDAL();

            string sql = "SELECT aspnetusers.Id, aspnetusers.UserName," +
                            "aspnetuserroles.UserId, aspnetuserroles.RoleId," +
                            "aspnetroles.Id, aspnetroles.Name" +
                            "FROM((aspnetuserroles" +
                            "INNER JOIN aspnetusers ON aspnetusers.Id = aspnetuserroles.UserId)" +
                            "INNER JOIN aspnetroles ON aspnetroles.Id = aspnetuserroles.RoleId); ";

            DataTable dados = objDAL.RetornarDataTable(sql);

            userAndRolesAdmin = new UserAndRolesAdmin()
            {
                UserId = dados.Rows[0]["UserId"].ToString(),
                UserName = dados.Rows[0]["UserName"].ToString(),
                RoleId = dados.Rows[0]["RoleId"].ToString(),
                RoleName = dados.Rows[0]["RoleName"].ToString()
            };

            return userAndRolesAdmin;
        }


    }
}
