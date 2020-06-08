using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstKaro
{
    [System.ComponentModel.DataAnnotations.Schema.Table("stores")]
    class store
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int storeId { get; set; }
        public String name { get; set; }
        public String address { get; set; }
        public float area { get; set; }

        public store() { }
        public store(int storeId, String name, float area)
        {
            this.storeId = storeId; this.name = name; this.area = area;
        }

        public virtual String info()
        {
            return ("storeId=" + storeId + ", name=" + name + ", area=" + area);
        }
    }
}
