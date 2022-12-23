using System.Collections.Generic;

namespace OnlineShop.Model
{
    public class Category
    {
        //category
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public List<Pie> Pie { get; set; }
    }
}
