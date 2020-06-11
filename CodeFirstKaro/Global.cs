using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstKaro
{
    class Global
    {
        public Global() { }
        public List<store> stores { get; set; }
        public List<product> products { get; set; }
        public List<productInStore> productsInStore { get; set; }


        public void updateAllLists(DataContext datacontext)
        {
            updateStoresList(datacontext);
            updateProductsList(datacontext);
            updateProductsInStoresList(datacontext);
        }

        public void updateStoresList(DataContext datacontext)
        {
            using (DataContext db = new DataContext())
            {
                if (stores != null)
                {
                    stores.Clear();
                }

                foreach (store p in db.stores)
                {
                    stores.Add(p as store);
                }
            }
        }


        public void updateProductsList(DataContext datacontext)
        {
            using (DataContext db = new DataContext())
            {
                if (products != null)
                {
                    products.Clear();
                }

                foreach (product myproduct in db.products)
                {
                    products.Add(myproduct as product);
                }
            }
        }


        public void updateProductsInStoresList(DataContext datacontext)
        {
            using (DataContext db = new DataContext())
            {
                if (productsInStore != null)
                {
                    productsInStore.Clear();
                }

                foreach (productInStore p in db.productsInStore)
                {
                    productsInStore.Add(p as productInStore);
                }
            }
        }

        public void addFirstItem(object newobj)
        {
            if (newobj != null)
            {
                if (newobj is store)
                {
                    stores.Insert(0, newobj as store);
                }
                if (newobj is product)
                {
                    products.Insert(0, newobj as product);
                }
                if (newobj is productInStore)
                {
                    productsInStore.Insert(0, newobj as productInStore);
                }
            }
        }


        public void addLastItem(object newobj)
        {
            if (newobj != null)
            {
                if (newobj is store)
                {
                    stores.Add(newobj as store);
                   
                }
                if (newobj is product)
                {
                    products.Add(newobj as product);
                }
                if (newobj is productInStore)
                {
                    productsInStore.Add(newobj as productInStore);
                }
            }
        }

        public List<String> getStoreInfo()
        {
            var storesInfo = (from s in stores  select s.info()).ToList();
            return storesInfo;
        }
        public List<String> getProductsInfo()
        {
            var productsInfo = (from s in products select s.info()).ToList();
            return productsInfo;
        }

        public List<String> getProductsInStoreInfo()
        {
            var productsInStoreInfo = (from s in productsInStore select s.info()).ToList();
            return productsInStoreInfo;
        }

    }
        
}
