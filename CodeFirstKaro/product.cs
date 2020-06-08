using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstKaro
{
    [System.ComponentModel.DataAnnotations.Schema.Table("products")]
    public class product
    {

        [System.ComponentModel.DataAnnotations.Key]
        public int productId { get; set; }
        public String name { get; set; }
        public String grade { get; set; }

        public product() { }
        public product(int productId, String name, string grade)
        {
            this.productId = productId; this.name = name; this.grade = grade;
        }

        public virtual String info()
        {
            return ("productId=" + productId + ", name=" + name + ", grade=" + grade);
        }
    }
}