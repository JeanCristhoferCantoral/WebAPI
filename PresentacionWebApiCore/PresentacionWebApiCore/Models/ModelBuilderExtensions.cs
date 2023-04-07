using Microsoft.EntityFrameworkCore;

namespace PresentacionWebApiCore.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            List<Alumno> registrosAlumnos = new List<Alumno>();

            // Crear 5 registros de alumnos y agregarlos a la lista
            registrosAlumnos.Add(new Alumno
            {
                Id = 1,
                Name = "Juan Perez",
                Email = "juanperez@mail.com",
                Birthday = new DateTime(2000, 1, 1),
                Description = "Alumno ejemplar",
                curso = "Programación"
            });

            registrosAlumnos.Add(new Alumno
            {
                Id = 2,
                Name = "Ana Gomez",
                Email = "anagomez@mail.com",
                Birthday = new DateTime(2001, 3, 15),
                Description = "Estudiante dedicada",
                curso = "Matemáticas"
            });

            registrosAlumnos.Add(new Alumno
            {
                Id = 3,
                Name = "Pedro Rodriguez",
                Email = "pedrorodriguez@mail.com",
                Birthday = new DateTime(1999, 5, 22),
                Description = "Buen compañero",
                curso = "Historia"
            });

            registrosAlumnos.Add(new Alumno
            {
                Id = 4,
                Name = "Luisa Hernandez",
                Email = "luisahernandez@mail.com",
                Birthday = new DateTime(2002, 8, 8),
                Description = "Interesada en tecnología",
                curso = "Informática"
            });

            registrosAlumnos.Add(new Alumno
            {
                Id = 5,
                Name = "Miguel Sanchez",
                Email = "miguelsanchez@mail.com",
                Birthday = new DateTime(2003, 12, 30),
                Description = "Alegre y optimista",
                curso = "Lengua"
            });
            modelBuilder.Entity<Alumno>().HasData(registrosAlumnos);
        }
    }
}
