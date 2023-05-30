namespace TermProjectEVBud.Data;

public class Reserve
{
    public int ReservationId { get; set; }
        
    public int ChargerId { get; set; }
    public Charger Charger { get; set; }
    public bool OccupationStatus { get; set; }
        
    public int MemberId { get; set; }
    public virtual Member Member { get; set; }
        
    public DateTime TimeReserved { get; set; }
    public DateTime TimeReservedUntil { get; set; }
        

}