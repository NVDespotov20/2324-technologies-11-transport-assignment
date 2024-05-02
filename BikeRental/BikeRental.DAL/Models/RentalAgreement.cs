using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRental.DAL.Models
{
    public class RentalAgreement
    {
        public int Id { get; set; }
        [Required]
        public int BikeId { get; set; }
        public virtual Bike Bike { get; set; } = null!;
        [Required]
        public int RenterId { get; set; }
        public virtual User Renter { get; set; } = null!;
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }

    }
}
