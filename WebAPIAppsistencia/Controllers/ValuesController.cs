using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebAPIAppsistencia.Models;

namespace WebAPIAppsistencia.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        //[EnableCors(origins: "http://localhost:19006/", headers: "*", methods: "*")]
        [HttpGet]
        public List <UsuarioModel> GetTest()
        {
            using (appsistenciaDBEntities db = new appsistenciaDBEntities())
            {

                var ID = new SqlParameter("@ID", 4);

                var result = db.Database
                    .SqlQuery<UsuarioModel>("spSelectUsuario @ID", ID)
                    .ToList();

                List<UsuarioModel> usuarios = new List<UsuarioModel>();
                foreach (UsuarioModel resultado in result)
                {
                    usuarios.Add(new UsuarioModel { nombre = resultado.nombre, genero = resultado.genero});

                }
                return usuarios;
            }
        }

        [HttpGet]
        public List<UsuarioModel> spLogin(string email, string password)
        {
            using (appsistenciaDBEntities db = new appsistenciaDBEntities())
            {

                List<UsuarioModel> result = db.Database.SqlQuery<UsuarioModel>("spLogin @p0, @p1",
                                              parameters: new[] { email, password }).ToList(); 

 
                return result;
            }
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete]
        public void Delete(int id)
        {
        }
    }
}
