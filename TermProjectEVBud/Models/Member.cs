using TermProjectEVBud.Data.Migrations;

namespace TermProjectEVBud.Data;

public class Member
{
        public int MemberId { get; set; }
        public string Password { get; set; } 
        public string MemberName { get; set; }
        
        public ICollection<Car> Cars { get; set; }
        public ICollection<Charging> Chargings { get; set; }
        public ICollection<Offers> Offers { get; set; }
        
        public ICollection<Reserve> Reserves { get; set; }

}