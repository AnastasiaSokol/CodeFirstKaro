using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstKaro
{
    [System.ComponentModel.DataAnnotations.Schema.Table("productsInStore")]
    class productInStore
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int productInStoreId { get; set; }
        public store myStore { get; set; }
        public product myProduct { get; set; }

        public productInStore() { }
        public productInStore(int productInStoreId,
            store myStore, product myProduct)
        {
            this.productInStoreId = productInStoreId;
            this.myStore = myStore; this.myProduct = myProduct;
        }

        public virtual String info()
        {
            return ("productInStoreId=" + productInStoreId +
                ", myStore id=" + myStore.storeId + ", myProduct id=" + myProduct.productId);
        }
    }
}
