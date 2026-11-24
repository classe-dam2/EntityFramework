namespace ProjecteEntityFramework.Models;

public class Xip
{
    public int XipID  { get; set; }
    public string Codi { get; set; }
    public DateTime DataImplantacio { get; set; }
    
    public int AnimalID { get; set; }
    public virtual Animal? Animal { get; set; }

    public Xip( )
    {
        DataImplantacio = DateTime.Now;

    }
}