using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Den_magiska_fabriken
{
    public class WorkShop
    {
        private int _woodInFactory;
        private int _ironInFactory;
        private int _rubberInFactory;
        private int _redPaintInFactory;
        private int _screwsInFactory;
        public void InputMaterial(List<int> GivingMartiral)
        {
            _woodInFactory = GivingMartiral[0];
            _ironInFactory = GivingMartiral[1];
            _rubberInFactory = GivingMartiral[2];
            _redPaintInFactory = GivingMartiral[3];
            _screwsInFactory = GivingMartiral[4];
            Works();
        }
        public void Works()
        {

        }
        private void CreateProduct(Framework recipe)
        {
            Warehouse._mytems.Add(recipe);   
            _woodInFactory -= recipe.WoodToUse;
            _ironInFactory -= recipe.SteelToUse;
            _rubberInFactory -= recipe.PlasticToUse;
            _redPaintInFactory -= recipe.PaintToUse;
            _screwsInFactory -= recipe.ScrewToUse;
            Warehouse.listOfMaterials[0] += _woodInFactory;
            Warehouse.listOfMaterials[1] += _ironInFactory;
            Warehouse.listOfMaterials[2] += _rubberInFactory;
            Warehouse.listOfMaterials[3] += _screwsInFactory;
            Warehouse.listOfMaterials[4] += _redPaintInFactory;
            _woodInFactory = 0;
            _ironInFactory = 0;
            _rubberInFactory = 0;
            _screwsInFactory = 0;
            _redPaintInFactory = 0;


        }
    }
}
