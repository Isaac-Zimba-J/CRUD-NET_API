using MyPetAppAPI.Enums;

namespace MyPetAppAPI.DTOs.Pet
{
    public class UpdatePetDto
    {

        public int Id { get; set; }
        public string? Name { get; set; } = "Mr. Snuggles";
        public DateTime? DOB { get; set; } = new DateTime();
        public string Weight { get; set; } = "5kg";
        public Gender Gender { get; set; } = Gender.Male;
        public string Species { get; set; } = "Cat";
        public string Breed { get; set; } = "Bombay cat";
        public Vaccinated Vaccinated { get; set; } = Vaccinated.No;
        public string Vaccine { get; set; } = "FVRCP";
        public string Dose { get; set; } = "2 /24";
        public DateTime? LastModified { get; set; } = DateTime.Now;
        public DateTime? Created { get; set; } = new DateTime();
        public string Comment { get; set; } = " Seems to be fine at the moment";
        public string Description { get; set; } = "Likes chocolate and has allergic reactions to milk";

    }
}
