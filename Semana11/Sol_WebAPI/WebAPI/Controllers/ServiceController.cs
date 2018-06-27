using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using System.Configuration;
using System.Data.SqlClient;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class ServiceController : ApiController
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnNegocios"].ConnectionString);

        // GET: api/Service
        public IEnumerable<Herramienta> Get()
        {
            List<Herramienta> lista = new List<Herramienta>();

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM tb_herramienta", cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Herramienta h = new Herramienta();

                    h.idHer = dr.GetString(0);
                    h.desHer = dr.GetString(1);
                    h.idCar = dr.GetString(2);
                    h.preUni = dr.GetDecimal(3);
                    h.stock = dr.GetInt32(4);

                    lista.Add(h);
                }
                
            }
            catch (Exception)
            {

            }
            finally{
                cn.Close();
            }

            return lista;
        }

        // GET: api/Service/5
        public Herramienta Get(string id)
        {
            return Get().Where(h => h.idHer == id).FirstOrDefault();
        }

        // GET: combobox Caracteristicas
        public IEnumerable<Caracteristica> GetCarcteristica()
        {
            List<Caracteristica> lista = new List<Caracteristica>();

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM tb_caracteristica", cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Caracteristica c = new Caracteristica();

                    c.idCar = dr.GetString(0);
                    c.desCar = dr.GetString(1);

                    lista.Add(c);
                }

            }
            catch (Exception)
            {

            }
            finally
            {
                cn.Close();
            }

            return lista;
        }

        // POST: api/Service
        public void Post(Herramienta h)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO tb_herramienta VALUES(@id, @des, @idCar, @precio, @stock)", cn);
                cn.Open();
                cmd.Parameters.AddWithValue("@id", h.idHer);
                cmd.Parameters.AddWithValue("@des", h.desHer);
                cmd.Parameters.AddWithValue("@idCar", h.idCar);
                cmd.Parameters.AddWithValue("@precio", h.preUni);
                cmd.Parameters.AddWithValue("@stock", h.stock);

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            finally
            {
                cn.Close();
            }
        }

        // PUT: api/Service/5
        public void Put(Herramienta h)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE tb_herramienta SET desHer = @des, idCar = @idCar, preUni = @precio, stock = @stock WHERE idHer = @id", cn);
                cn.Open();
                cmd.Parameters.AddWithValue("@id", h.idHer);
                cmd.Parameters.AddWithValue("@des", h.desHer);
                cmd.Parameters.AddWithValue("@idCar", h.idCar);
                cmd.Parameters.AddWithValue("@precio", h.preUni);
                cmd.Parameters.AddWithValue("@stock", h.stock);

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            finally
            {
                cn.Close();
            }
        }

        // DELETE: api/Service/5
        public void Delete(string id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE tb_herramienta WHERE idHer = @id", cn);
                cn.Open();
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            finally
            {
                cn.Close();
            }
        }
    }
}
