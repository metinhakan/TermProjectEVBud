using System.ComponentModel.DataAnnotations.Schema;

namespace TermProjectEVBud.Data;

public class Charging
{
    public int ChargeId { get; set; }
    
    
    public int CarId { get; set; }
    public virtual Car Car { get; set; }
     
    [ForeignKey("MemberUsed")]
    public int? MemberId { get; set; }
    public virtual Member Member { get; set; }
    
    [ForeignKey("ChargerId")]
    public int ChargerId { get; set; }
    public virtual Charger Charger { get; set; }

        
    public DateTime TimeStarted { get; set; }
    public DateTime TimeFinished { get; set; }
        
    public bool OccupationStatus { get; set; }
        

}