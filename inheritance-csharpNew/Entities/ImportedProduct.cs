using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inheritance_csharpNew.Entities;
using System.Globalization;

namespace inheritance_csharpNew.Entities
{
    class ImportedProduct : Product
    {
        public double CustomFee { get; set; }

        public ImportedProduct( string name, double price,double customFee)
            : base(name, price)
        {
            CustomFee = customFee;
        }

        public double totalPrice()
        {
            return Price + CustomFee;
        }

        public override string priceTag()
        {
            return Name
                    + " $ " 
                    + totalPrice().ToString("F2", CultureInfo.InvariantCulture)
                    + "(Custom fee: $ "
                    + ")";
        }


    }
}
