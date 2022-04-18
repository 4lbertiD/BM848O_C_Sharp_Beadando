namespace BM848O_C_Sharp_Beadando

{
    public class Program
    {
        static void Main(string[] args)
        {
            Collection<Program> collection = new Collection<Program>();

            Console.WriteLine("A ket kezdo halmazunk:");
            Console.WriteLine("A:");
            Kiir(collection.Halmaz1);
            Console.WriteLine("B:");
            Kiir(collection.Halmaz2);

            Console.WriteLine("Itt mindkét halmazhoz hozzaadunk elemeket:");
            collection.Halmaz1.Add(12); // ez nem adódik hozzá, mivel már szerepel a halmazunkban
            collection.Halmaz1.Add(15);
            collection.Halmaz2.Add(16);
            collection.Halmaz2.Add(10);
            collection.Halmaz2.Add(12);
            collection.Halmaz2.Add(19);
            Console.WriteLine("A:");
            Kiir(collection.Halmaz1);
            Console.WriteLine("B:");
            Kiir(collection.Halmaz2);

            Console.WriteLine("Itt mindkét halmazból elveszünk elemeket:");
            collection.Halmaz1.Remove(12);
            collection.Halmaz2.Remove(12);
            Console.WriteLine("A:");
            Kiir(collection.Halmaz1);
            Console.WriteLine("B:");
            Kiir(collection.Halmaz2);

            Console.WriteLine("A ket halmaz unioja:");
            collection.Unio();
            Kiir(collection.Halmaz1);

            Console.WriteLine("A ket halmaz metszete:");
            collection.Metszet();
            Kiir(collection.Halmaz2);

            collection.Count();

            Console.WriteLine("\nVan kozos elem a ket halmazban?");
            collection.Kozos();

            Console.WriteLine("\nMinden elem megegyezik a ket halmazban?");
            collection.Megegyezo();
        }
        public static void Kiir<T>(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Console.Write("{0}, ", item);
            }
            Console.WriteLine("\n");
        }

    }
}
