using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_CottonKnit.Modelos;

namespace WebApi_CottonKnit.Repositorios
{
    public class UsersApiRepository : ICrudRepository<UsersApi>
    {
        CottonData db;
        public async Task<bool> Delete(int id)
        {
            try
            {
                db = new CottonData();
                DbParametro[] parametro = new DbParametro[2];
                parametro[0] = new DbParametro("p_iduser",id);
                parametro[1] = new DbParametro("p_userReg", "MHUAMANI");
                var result = await db.SetData("Deleredelapi_users", parametro);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<object> GetAll()
        {
            try
            {
                db = new CottonData();
                DbParametro[] parametro = new DbParametro[0];
                var resul = await db.GetData("getapi_users", parametro);
                return resul;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<object> GetDetail(int id)
        {
            try
            {
                db = new CottonData();
                DbParametro[] parametro = new DbParametro[1];
                parametro[0] = new DbParametro("p_iduser", id);
                var resul = await db.GetData("getapi_users", parametro);
                return resul;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> Update(UsersApi obj)
        {
            try
            {
                db = new CottonData();
                DbParametro[] parametro = new DbParametro[7];
                parametro[0] = new DbParametro("p_id_user", obj.Id);
                parametro[1] = new DbParametro("p_nombre",obj.Nombre);
                parametro[2] = new DbParametro("p_apellido_pat",obj.Apellido_1);
                parametro[3] = new DbParametro("p_apellido_mat",obj.Apellido_2);
                parametro[4] = new DbParametro("p_usuario", obj.Usuario);
                parametro[5] = new DbParametro("p_clave", obj.clave);
                parametro[6] = new DbParametro("p_userreg", obj.UserReg);
                var resul = await db.SetData("updateapi_users", parametro);
                return resul;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<bool> Insert(UsersApi obj)
        {
            try
            {
                db = new CottonData();
                DbParametro[] parametro = new DbParametro[6];
                parametro[0] = new DbParametro("p_nombre", obj.Nombre);
                parametro[1] = new DbParametro("p_apellido_pat", obj.Apellido_1);
                parametro[2] = new DbParametro("p_apellido_mat", obj.Apellido_2);
                parametro[3] = new DbParametro("p_usuario", obj.Usuario);
                parametro[4] = new DbParametro("p_clave", obj.clave);
                parametro[5] = new DbParametro("p_userreg", "MHUAMANI");
                var resul = await db.SetData("insertapi_users", parametro);
                return resul;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
