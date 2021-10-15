using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Den_magiska_fabriken
{
    public class Framework
    {
        public string Name { get; }
        public int WoodToUse { get; } 
        public int SteelToUse { get; } 
        public int PlasticToUse { get; } 
        public int PaintToUse { get; }
        public int ScrewToUse { get; } 
        public Framework(string namn, int wood, int iron,
            int rubber, int Paint, int screws)
        {
            Name = namn;
            this.WoodToUse = wood;
            this.SteelToUse = iron;
            this.PlasticToUse = rubber;
            this.PaintToUse = Paint;
            this.ScrewToUse = screws;
        }
        public static void Createproduct()
        {
            Framework axe = new Framework("Hammer", 2, 1, 0, 1, 0);
            Framework plunger = new Framework("plunger", 1, 0, 1, 1, 0);
            Framework chopsticks = new Framework("chopsticks", 2, 0, 0, 0, 0);
            Framework bikecycle = new Framework("bikecycle", 0, 3, 1, 1, 2);
        }
    }
}
