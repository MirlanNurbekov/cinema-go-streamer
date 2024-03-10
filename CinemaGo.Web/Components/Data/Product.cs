namespace CinemaGo.Web.Data
{
    public class Product
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; } 
        public bool IsPublic { get; set; }
        public bool IsDeleted { get; set; }
        public int CategoryId { get; set; }
        public DateTime? DateCreated { get; set; } = DateTime.Now;
        public DateTime? DateUpdated { get; set; }
        public int Views { get; set; }

        public int OriginalPrice { get; set; }

        public int Price { get; set; }

        public string Genre { get; set; }

        public string Language { get; set; }

        public string RunningTime{ get; set; }

        public string ReleaseDate { get; set; }
    }
}