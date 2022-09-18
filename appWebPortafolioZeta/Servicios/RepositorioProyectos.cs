using appWebPortafolioZeta.Models;

namespace appWebPortafolioZeta.Servicios
{
    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyectos();
    }
    public class RepositorioProyectos: IRepositorioProyectos
    {     
        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>() {
                new Proyecto
            {
                Titulo="Brangus S.R.L.",
                Descripcion="Produccion en ASP.NET Core",
                Link="https://amerpages.com/spa/bolivia/items/view/6189/brangus-leather-corp-s-r-l",
                ImagenURL="/imagenes/brangus1.png"
            },
                 new Proyecto
            {
                Titulo="Brangus S.R.L.",
                Descripcion="Inventarios en ASP.NET Core",
                Link="https://www.europages.es/BRANGUS-LEATHER/00000003621907-85011001.html",
                ImagenURL="/imagenes/brangus2.png"
            },
                  new Proyecto
            {
                Titulo="Brangus S.R.L.",
                Descripcion="Contabilidad en ASP.NET Core",
                Link="https://amerpages.com/spa/bolivia/items/view/6189/brangus-leather-corp-s-r-l",
                ImagenURL="/imagenes/brangus3.png"
            },
                new Proyecto
            {
                Titulo="Brangus S.R.L.",
                Descripcion="Ventas en ASP.NET Core",
                Link="https://www.google.com",
                ImagenURL="/imagenes/brangus1.png"
            },
            };
        }
    }
}

