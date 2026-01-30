namespace NZWalksAPI.Models
{
    public class Walk
    {
        public int Id { get; set; }
           
        public string Name { get; set; }

        public string Description { get; set; }

        public  double LengthInKm { get; set; }

        public string? walkImageUrl { get; set; }

        public Guid DifficultyId { get; set; }
        public Guid RegionId { get; set; }



        //Nav prop
        public Difficulty Difficulty { get; set; }
        public Region Region { get; set; }
    }
}
