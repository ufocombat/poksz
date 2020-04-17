using System;
namespace poksz.Models
{
    public class ItemClass
    {
        public String Description { get; set; }
        public Decimal Price { get; set; }
        public Boolean InStock { get; set; }

        public ItemClass()
        {
            InStock = false;
            Description = "Новый товар";
            Price = 0;
        }
    }
}
