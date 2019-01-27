using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw7
{
    public class Cart
    {
        public int Id { get; set; }
        public virtual ICollection<Product> Items { get; set; }
    }
}
