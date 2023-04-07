using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PresentacionWebApiCore.Migrations
{
    /// <inheritdoc />
    public partial class m1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alumnos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    curso = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alumnos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Alumnos",
                columns: new[] { "Id", "Birthday", "Description", "Email", "Name", "curso" },
                values: new object[,]
                {
                    { 1, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alumno ejemplar", "juanperez@mail.com", "Juan Perez", "Programación" },
                    { 2, new DateTime(2001, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Estudiante dedicada", "anagomez@mail.com", "Ana Gomez", "Matemáticas" },
                    { 3, new DateTime(1999, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Buen compañero", "pedrorodriguez@mail.com", "Pedro Rodriguez", "Historia" },
                    { 4, new DateTime(2002, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Interesada en tecnología", "luisahernandez@mail.com", "Luisa Hernandez", "Informática" },
                    { 5, new DateTime(2003, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alegre y optimista", "miguelsanchez@mail.com", "Miguel Sanchez", "Lengua" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alumnos");
        }
    }
}
