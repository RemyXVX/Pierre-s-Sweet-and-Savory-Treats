using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PierresTreats.Models
{
  public class Treat
  {
    public int TreatId { get; set; }
    [Required(ErrorMessage = "Please fill me with something dawg..")]
    public string TreatName { get; set; }
    public string TreatDescription { get; set; }
    public int TreatQuantity { get; set; }
    public List<FlavorTreat> JoinEntities { get; }
    public ApplicationUser User { get; set; }
  }
}