using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRental.DAL.Models
{
    public class Bike
    {
        public int Id { get; set; }
        [Required]
        public int CityId { get; set; }
        public virtual City City { get; set; } = null!;
        [Required]
        public int OwnerId { get; set; }
        public virtual User Owner { get; set; } = null!;
        public virtual ICollection<RentalAgreement> RentalAgreements { get; set; } = new List<RentalAgreement>();

    }
}
