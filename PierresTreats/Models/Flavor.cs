using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PierresTreats.Models
{
  public class Flavor
  {
    public int FlavorId { get; set; }
    [Required(ErrorMessage = "Please fill me with something dawg..")]
    public string FlavorType { get; set; }
    public string FlavorDescription { get; set; }
    public List<FlavorTreat> JoinEntities { get; }
    public ApplicationUser User { get; set; }
  }
}