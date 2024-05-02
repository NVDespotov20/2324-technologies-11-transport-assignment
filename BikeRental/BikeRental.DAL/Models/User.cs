using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRental.DAL.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Username { get; set; } = null!;
        [Required]
        public string PasswordHash { get; set; } = null!;

        public virtual ICollection<Bike> BikesOwned { get; set; } = new List<Bike>();
        public virtual ICollection<RentalAgreement> RentalAgreementsAsRenter { get; set; } = new HashSet<RentalAgreement>();
    }
}
