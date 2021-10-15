using System;

namespace Den_magiska_fabriken
{
    class Program
    {
        static void Main(string[] args)
        {
            Framework.Createproduct();
            Console.WriteLine("Walcome to my Fatory!");
            Warehouse WH = new Warehouse();
            WH.Showarehouse();
            var WS=new WorkShop();
            WS.InputMaterial(WH.PeekMaterials);

        }
    }
}
