using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Controller
{
    public class ArticulosNegocio
    {
        public List<Articulos> listar()
        {
            List<Articulos> lista = new List<Articulos>();
            AccesosDatos datos = new AccesosDatos();
            try
            {
                datos.setConsulta("select A.Id, Codigo, Nombre, A.Descripcion as Descripcion_A, M.Descripcion as Descripcion_M, C.Descripcion as Descripcion_C, ImagenUrl, Precio from ARTICULOS A, MARCAS M, CATEGORIAS C where IdMarca = M.Id and IdCategoria = C.Id");
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulos aux = new Articulos();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion_A"];
                    aux.DescripcionMarcas = new Marcas();
                    aux.DescripcionMarcas.Descripcion = (string)datos.Lector["Descripcion_M"];
                    aux.DescripcionCategorias = new Categorias();
                    aux.DescripcionCategorias.Descripcion = (string)datos.Lector["Descripcion_C"];
                    //if (!(lector["ImagenUrl"] is DBNull))
                    aux.ImagenURL = (string)datos.Lector["ImagenUrl"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                }
                datos.CerrarConexion();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
