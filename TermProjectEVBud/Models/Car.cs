using System.ComponentModel.DataAnnotations.Schema;

namespace TermProjectEVBud.Data;

public class Car
{
    public int CarId { get; set; }
    
    [ForeignKey("CarModel")]
    public int ModelId { get; set; }
    public virtual Model Model { get; set; }
        
    public int ModelRange { get; set; }

    [ForeignKey("CarOwner")]
    public int? MemberId { get; set; }
    public Member Member { get; set; }
      
    public ICollection<Charging> Chargings { get; set; }

}