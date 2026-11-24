using System.ComponentModel.DataAnnotations;

namespace ProjecteEntityFramework.Models;

public class Xip
{
    public int XipID  { get; set; }
    [Required]
    [StringLength(15, MinimumLength = 15)]
    public string Codi { get; set; } = null!;
    public DateTime DataImplantacio { get; set; }
    
    public virtual Animal? Animal { get; set; }

    public Xip( )
    {
        DataImplantacio = DateTime.Now;

    }
}