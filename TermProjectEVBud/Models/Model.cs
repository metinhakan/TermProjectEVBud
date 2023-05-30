using System.ComponentModel.DataAnnotations.Schema;

namespace TermProjectEVBud.Data;

public class Model
{
    public string ModelName { get; set; }
    public int ModelId { get; set; }
    public float ModelRange { get; set; }
      
    [ForeignKey("BrandName")]
    public int BrandId { get; set; }
    public virtual Brand Brand { get; set; }
    
    public ICollection<Car> Cars { get; set; }
}