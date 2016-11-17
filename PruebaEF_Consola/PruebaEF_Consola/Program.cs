using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Entidades;

namespace PruebaEF_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            TestEFContext ctx = new TestEFContext();
 
            if (ctx.Database.Exists())
                Console.WriteLine("La base esta...");
            //Console.ReadLine();

            //var txt = ctx.Database.SqlQuery<TElement>("select * from Usuarios", params object[] parameters);

            Perfil per = ctx.Perfiles.FirstOrDefault();

            Console.WriteLine($"{per.Descripcion}");

            Console.ReadLine();
        }
    }
}
