using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Den_magiska_fabriken
{
    public class Warehouse
    {
        public List<Material> listMaterials;
        public static List<int> listOfMaterials;
        public List<int> PeekMaterials;
        
        public Warehouse()
        {
            listMaterials = new List<Material>();
            listOfMaterials = new List<int>();
            PeekMaterials = new List<int>();
            AddList();
        }
        private void AddList()
        {
            for (int i = 0; i < Enum.GetNames(typeof(Material)).Length; i++)
            {
                int randomN = new Random().Next(5, 10);
                PeekMaterials.Add(0);
                listOfMaterials.Add(randomN);
                listMaterials.Add((Material)i);
            }
        }
        public static List<Framework> _mytems = new();
        public void Showarehouse()
        {
            Console.WriteLine("The storage contains the folowing materials:  ");
            Console.WriteLine($"{"Nr.",1} {"Materials",3} {"Amount",20} ");
            for (int i = 0; i < listMaterials.Count; i++)
            {
                var l = listMaterials[i];
                Console.WriteLine($" {i + 1}.  {l,3} {listOfMaterials[i],22}");
            }
            if (_mytems.Count > 0)
            {
                Console.WriteLine("You own the folowing products:  ");
                for (int i = 0; i < _mytems.Count; i++)
                {
                    Console.WriteLine(_mytems[i].Name);
                }
            }
        }
        public List<int> SendToFactory()
        {
                
                Showarehouse();
                for (int q = 0; q < listOfMaterials.Count; q++)  
                {
                    if (listOfMaterials[q] > 0)
                    {
                        Console.WriteLine($" {listMaterials[q],10} Amount: {listOfMaterials[q]}");
                    }
                }
                Console.WriteLine("\nUse numbers to pick materials.");
                ConsoleKeyInfo Input = Console.ReadKey();
                int givingKey = int.Parse(Input.KeyChar.ToString());
                if (givingKey < listOfMaterials.Count)
                {
                    if (listOfMaterials[givingKey] > 0)
                    {
                        listOfMaterials[givingKey] = listOfMaterials[givingKey] - 1;
                       PeekMaterials[givingKey] = PeekMaterials[givingKey] + 1;
                    }
                    else

                    {
                        Console.WriteLine($"There is no more {(Material)givingKey}. Press enter to continue.");
                        Console.ReadKey();

                    }
                }
            List<int> list2 = new List<int>(PeekMaterials.Count);
            foreach (int item in PeekMaterials)
                list2.Add(item);
            for (int i = 0; i < PeekMaterials.Count; i++)
            {
                PeekMaterials[i] = 0;
            }

            return list2;
            

        }

    }
}
