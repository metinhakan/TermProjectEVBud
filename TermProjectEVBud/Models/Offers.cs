namespace TermProjectEVBud.Data.Migrations;

public class Offers
{
    public int OfferId { get; set; }

    public int CompanyOffered { get; set; }
    public ChargerCompany Company { get; set; }
        
    public int MemberOffered { get; set; }
    public virtual Member Member { get; set; }
        
    public string OfferType { get; set; }
    public float OfferRate { get; set; }
}