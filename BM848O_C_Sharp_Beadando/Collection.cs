namespace BM848O_C_Sharp_Beadando
{
    using System;
    using System.Collections.Generic;
    public class Collection<T> where T : class
    {

        HashSet<int> halmaz1 = new HashSet<int>(new int[] { 2, 3, 4, 5, 6, 8, 1, 1, 10, 12 });
        HashSet<int> halmaz2 = new HashSet<int>(new int[] { 1, 2, 3, 4, 5, 6 });

        public HashSet<int> Halmaz1 { get => halmaz1; set => halmaz1 = value; }
        public HashSet<int> Halmaz2 { get => halmaz2; set => halmaz2 = value; }

        internal void Add(int v)
        {
            halmaz1.Add(v);
        }
        internal void Remove(int v)
        {
            halmaz1.Remove(v);
        }
        internal void Unio()
        {
            halmaz1.UnionWith(halmaz2);
        }
        internal void Metszet()
        {
            halmaz2.IntersectWith(halmaz1);
        }
        internal void Count()
        {
            int db1 = halmaz1.Count();
            int db2 = halmaz2.Count();
            Console.WriteLine("Az elemek darabszama: \nA:\n{0} \nB:\n{1}", db1, db2);
        }
        internal void Kozos()
        {
            if (halmaz1.Overlaps(halmaz2))
            {
                Console.WriteLine("Igen");
            }
            else
            {
                Console.WriteLine("Nem");
            }
        }
        internal void Megegyezo()
        {
            if (halmaz1.SetEquals(halmaz2))
            {
                Console.WriteLine("Igen");
            }
            else
            {
                Console.WriteLine("Nem");
            }
        }
        internal void TiznelKisebb()
        {
            Console.WriteLine("\n10-nel kisebb szamok:  ");
            var kisebbSzamok = halmaz1.Where(n => n < 10);
            foreach (var n in kisebbSzamok)
                Console.WriteLine(n);
        }


    }
}
