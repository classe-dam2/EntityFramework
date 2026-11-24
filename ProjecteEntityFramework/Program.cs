using Castle.Components.DictionaryAdapter;
using ProjecteEntityFramework.Data;
using ProjecteEntityFramework.Models;

namespace  RefugianAnimals;
public class Program
{

    
    public static void Main(string[] args)
    {
        
        using (var ctx = new RefugiContext())   // com el try-with-resources de Java: tanca el context en acabar el bloc
        {
            //Esborrem i creem BD
            ctx.Database.EnsureDeleted();
            ctx.Database.EnsureCreated();
            
            ctx.Animals.AddRange(
                new Animal { Nom = "Luna", Pes = 10, Especie = Especie.GOS, DataNaixement = new DateTime(2020, 3, 12), DataEntrada = new DateTime(2023, 1, 10), Xip = new Xip { Codi = "724098100000001" } },
                new Animal { Nom = "Roc", Pes = 10, Especie = Especie.GOS, DataNaixement = new DateTime(2019, 5, 20), DataEntrada = new DateTime(2023, 2, 15), Xip = new Xip { Codi = "724098100000002" } },
                new Animal { Nom = "Nala", Pes = 10, Especie = Especie.GOS, DataNaixement = new DateTime(2021, 7, 8), DataEntrada = new DateTime(2023, 3, 22), Xip = new Xip { Codi = "724098100000003" } },
                new Animal { Nom = "Max", Pes = 10, Especie = Especie.GOS, DataNaixement = new DateTime(2018, 11, 3), DataEntrada = new DateTime(2023, 4, 5), Xip = new Xip { Codi = "724098100000004" } },
                new Animal { Nom = "Mixa", Pes = 4, Especie = Especie.GAT, DataNaixement = new DateTime(2020, 2, 14), DataEntrada = new DateTime(2023, 5, 11), Xip = new Xip { Codi = "724098100000005" } },
                new Animal { Nom = "Simba", Pes = 4, Especie = Especie.GAT, DataNaixement = new DateTime(2021, 6, 18), DataEntrada = new DateTime(2023, 6, 19), Xip = new Xip { Codi = "724098100000006" } },
                new Animal { Nom = "Neu", Pes = 4, Especie = Especie.GAT, DataNaixement = new DateTime(2022, 1, 25), DataEntrada = new DateTime(2023, 7, 25), Xip = new Xip { Codi = "724098100000007" } },
                new Animal { Nom = "Núvol", Pes = 2, Especie = Especie.CONILL, DataNaixement = new DateTime(2022, 4, 9), DataEntrada = new DateTime(2023, 8, 8), Xip = new Xip { Codi = "724098100000008" } },
                new Animal { Nom = "Piu", Pes = 0.2, Especie = Especie.AU, DataNaixement = new DateTime(2021, 9, 30), DataEntrada = new DateTime(2023, 9, 12), Xip = new Xip { Codi = "724098100000009" } }
            );

            ctx.SaveChanges();
            ctx.ChangeTracker.Clear();

             
            //Lectura
            Console.WriteLine("\n=== DADES INSERIDES ===");

            List<Animal> animals = ctx.Animals.ToList();

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ToString());
                
            }
           
           
        }

    }
}