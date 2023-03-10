using eTickets.Data.enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public movieCategory MovieCategory { get; set; }
        public string Description { get; set; }
        //Others are relational data.
          
        public List<Actor_Movie> Actor_Movies { get; set; }

        public int cinemaId { get; set; }
        [ForeignKey("cinemaId")]
        public Cinema cinema { get; set; }

        //Producer
        public int ProducerId { get; set; }
        [ForeignKey("ProducerID")]
        public Producer producer { get; set; }

    }
}
