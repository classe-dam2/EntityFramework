using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace ProjecteEntityFramework.Models;

public class Animal
{
    public int AnimalID { get; set; }
    
    [Required]
    [MaxLength(50)]
    public string Name { get; set; }
    public Especie Especie { get; set; }
    public bool EsFemella { get; set; }
    public DateTime DataNaixement { get; set; }
    public DateTime DataEntrada { get; set; }
    public double Pes { get; set; }
    public bool EstaAdoptat { get; set; }
    public DateTime? DataAdopcio { get; set; }
    
    [Precision(8, 2)]                         // SQLite no força la precisió, però el model la porta
    public decimal QuotaAdopcio  { get; set; }
    public virtual Xip Xip { get; set; }

    public Animal()
    {
        DataNaixement = DateTime.Now;
        DataEntrada = DateTime.Now;
        DataAdopcio = null;
    }

    public override string ToString()
    {
        return $"ID: {AnimalID}, Nom: {Name}, Espècie: {Especie}, " +
               $"Femella: {EsFemella}, Naixement: {DataNaixement:dd/MM/yyyy}, " +
               $"Entrada: {DataEntrada:dd/MM/yyyy}, Pes: {Pes} kg, " +
               $"Adoptat: {EstaAdoptat}, Data d'adopció: {(DataAdopcio?.ToString("dd/MM/yyyy") ?? "—")}, " +
               $"Quota d'adopció: {QuotaAdopcio:C}, Xip: {Xip?.Codi ?? "—"}";
    }
    
}