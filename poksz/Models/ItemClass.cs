using System;
namespace poksz.Models
{
    public class ItemClass
    {
        public String Picture { get; set; }

        public String Description { get; set; }
        public Decimal Price { get; set; }
        public Boolean InStock { get; set; }

        public ItemClass()
        {
            InStock = false;
            Description = "Новый товар";
            Price = 0;
        }

        public ItemClass(String discription,String picrure, Decimal price): base()
        {
            this.Description = discription;
            this.Picture = picrure;
            this.Price = price;
        }
    }
}
