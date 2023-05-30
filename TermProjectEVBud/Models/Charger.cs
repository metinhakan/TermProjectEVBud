namespace TermProjectEVBud.Data;

public class Charger
{
    public int ChargerId { get; set; }
    public string ChargerType { get; set; }
    public string ChargerLocation { get; set; }
    public virtual Location Location { get; set; }
    public float ChargerFare { get; set; }
        
    public int ChargerCompany { get; set; }
    public virtual ChargerCompany Company { get; set; }
        
    public bool OccupationStatus { get; set; }

    public ICollection<Charging> Chargings { get; set; }
    public ICollection<Reserve> Reserves { get; set; }

}