using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class SeedData
    {

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new WebApplication1Context(
                serviceProvider.GetRequiredService<
                    DbContextOptions<WebApplication1Context>>()))
            {
                // Look for any movies.
                if (context.Cliente.Any())
                {
                    return;   // DB has been seeded
                }

                context.Cliente.AddRange(
                    new Cliente
                    {
                        nombre = "Sebastian",
                        correo = "Algo",
                        telefono = "123456",
                        necesidad = "asdasd",
                        tipoDeEvento = "sadasd",
                        ubicacion = "ssdf",
                        fecha = "asdas",
                        invitados = 10,
                        detalles = "dsfsdf"

                    },

                    new Cliente
                    {
                        nombre = "Sebastian",
                        correo = "Algo",
                        telefono = "123456",
                        necesidad = "asdasd",
                        tipoDeEvento = "sadasd",
                        ubicacion = "ssdf",
                        fecha = "asdas",
                        invitados = 10,
                        detalles = "dsfsdf"
                    },

                    new Cliente
                    {
                        nombre = "Sebastian",
                        correo = "Algo",
                        telefono = "123456",
                        necesidad = "asdasd",
                        tipoDeEvento = "sadasd",
                        ubicacion = "ssdf",
                        fecha = "asdas",
                        invitados = 10,
                        detalles = "dsfsdf"
                    },

                    new Cliente
                    {
                        nombre = "Sebastian",
                        correo = "Algo",
                        telefono = "123456",
                        necesidad = "asdasd",
                        tipoDeEvento = "sadasd",
                        ubicacion = "ssdf",
                        fecha = "asdas",
                        invitados = 10,
                        detalles = "dsfsdf"
                    }
                );
                context.SaveChanges();
            }
        }

    }
}
