using GMS.Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GMS.Configuration
{
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasData(
                new City { Id = 1, Name = "Banja Luka" },
                new City { Id = 2, Name = "Bihać" },
                new City { Id = 3, Name = "Bijeljina" },
                new City { Id = 4, Name = "Bosnaska Krupa" },
                new City { Id = 5, Name = "Cazin" },
                new City { Id = 6, Name = "Čapljina" },
                new City { Id = 7, Name = "Drventa" },
                new City { Id = 8, Name = "Doboj" },
                new City { Id = 9, Name = "Goražde" },
                new City { Id = 10, Name = "Gračanica" },
                new City { Id = 11, Name = "Gradačac" },
                new City { Id = 12, Name = "Gradiška" },
                new City { Id = 13, Name = "Konjic" },
                new City { Id = 14, Name = "Laktaši" },
                new City { Id = 15, Name = "Livno" },
                new City { Id = 16, Name = "Lukavac" },
                new City { Id = 17, Name = "Ljubuški" },
                new City { Id = 18, Name = "Mostar" },
                new City { Id = 19, Name = "Orašje" },
                new City { Id = 20, Name = "Prijedor" },
                new City { Id = 21, Name = "Prnjavor" },
                new City { Id = 22, Name = "Sarajevo" },
                new City { Id = 23, Name = "Srebrenik" },
                new City { Id = 24, Name = "Stolac" },
                new City { Id = 25, Name = "Široki Brijeg" },
                new City { Id = 26, Name = "Travnik" },
                new City { Id = 27, Name = "Tuzla" },
                new City { Id = 28, Name = "Visoko" },
                new City { Id = 29, Name = "Zavidovići" },
                new City { Id = 30, Name = "Zenica" },
                new City { Id = 31, Name = "Zvornik" },
                new City { Id = 32, Name = "Živinice" },
                new City { Id = 33, Name = "Donji Vakuf" },
                new City { Id = 34, Name = "Zavidovići" }
            );
        }
    }
}
