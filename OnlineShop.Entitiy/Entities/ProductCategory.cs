using OnlineShop.Entitiy.CommonEntity;

namespace OnlineShop.Entitiy.Entities
{
    public class ProductCategory : BaseEntity
    {
        public int? ProductCategoryParentId { get; set; }

        public string ProductCategoryName { get; set; }

        public string ProductCategoryDescription { get; set; }
    }
}
