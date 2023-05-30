using TermProjectEVBud.Data.Migrations;

namespace TermProjectEVBud.Data;

public class ChargerCompany
{
    public string CompanyName { get; set; }
    public int CompanyId { get; set; }
    public int ChargerNumber { get; set; }
    
    public ICollection<Offers> Offers { get; set; }
}