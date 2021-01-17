using OnlineShop.Entitiy.CommonEntity;

namespace OnlineShop.Entitiy.Entities
{
    public class Product: BaseEntity
    {
        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public string ProductSize { get; set; }

        public string ProductColor { get; set; }

        public string ProductMaterial { get; set; }

        public string ProductCreateDate { get; set; }

        public long Price { get; set; }
    }
}
