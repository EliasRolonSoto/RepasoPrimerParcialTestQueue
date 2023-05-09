using RepasoPrimerParcial;
using System.Security.Cryptography;

namespace TestRepaso1erParcial
{
    public class UnitTest1
    {
        private Queue<Alumno> Alumnos = new Queue<Alumno>();
        [Fact]

        public void TieneQueCrear100milAlumnosYBuscarQuienTerminaEn11()
        {

            for (int i = 0; i < 100000; i++)
            {
                Alumno alumno = new Alumno();
                alumno._nombre = ($"nombre {i}");
                alumno._apellido = ($"Apellid {i}");
                alumno._legajo = ($"Legajo: {i}");
                Alumnos.Enqueue(alumno);
            }


            Assert.Equal(100000, Alumnos.Count);

            //var cantidadordenada = Alumnos.OrderByDescending(alumno => alumno._nombre); ordenar lista

            var cantidadMayor = (from alumno in Alumnos
                                 select alumno._legajo).Max();
                                           


            var cantidad = (from alumno in Alumnos
                             where alumno._apellido.EndsWith("11")
                             select alumno._apellido
                            );

            Assert.Equal(1000, cantidad.Count());
            Assert.Equal("Legajo: 99999", cantidadMayor);
        }
    }
}