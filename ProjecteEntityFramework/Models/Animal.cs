using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace ProjecteEntityFramework.Models;

public class Animal
{   
    [Required]
    public int AnimalID { get; set; }
    
    [Required]
    [MaxLength(50)]
    public string Nom { get; set; } = null!;
    public Especie Especie { get; set; }
    public bool EsFemella { get; set; }
    public DateTime DataNaixement { get; set; }
    public DateTime DataEntrada { get; set; }
    [Range(0.1, 100)]
    public double Pes { get; set; }
    public bool EstaAdoptat { get; set; }
    public DateTime? DataAdopcio { get; set; }
    
    [Precision(8, 2)]                         // SQLite no força la precisió, però el model la porta
    public decimal QuotaAdopcio  { get; set; }
    public virtual Xip Xip { get; set; } = null!;

    public Animal()
    {
        DataEntrada = DateTime.Now;
    }

    public override string ToString()
    {
        return $"ID: {AnimalID}, Nom: {Nom}, Espècie: {Especie}, " +
               $"Femella: {EsFemella}, Naixement: {DataNaixement:dd/MM/yyyy}, " +
               $"Entrada: {DataEntrada:dd/MM/yyyy}, Pes: {Pes} kg, " +
               $"Adoptat: {EstaAdoptat}, Data d'adopció: {(DataAdopcio?.ToString("dd/MM/yyyy") ?? "—")}, " +
               $"Quota d'adopció: {QuotaAdopcio:C}, Xip: {Xip?.Codi ?? "—"}";
    }
    
}