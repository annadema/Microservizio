using DTO.Animale;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class popolodb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Animali",
                columns: new[]
                {
                    nameof(AnimaleDTO.Nome),
                    nameof(AnimaleDTO.Specie),
                    nameof(AnimaleDTO.DataNascita),
                    nameof(AnimaleDTO.Peso)
                },
                values: new object[,]
                {
                    { "Mario", "Tigre", new DateTime(2023, 4, 5), 101 },
                    { "Luigi", "Pinguino", new DateTime(2022, 5, 5), 20 },
                    { "Mario", "Orso", new DateTime(2018, 2, 5), 221 },
                    { "Giulia", "Gatto", new DateTime(), 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
