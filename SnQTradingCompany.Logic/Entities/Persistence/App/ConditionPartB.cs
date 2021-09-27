//@GeneratedCode
namespace SnQTradingCompany.Logic.Entities.Persistence.App
{
    partial class Condition
    {
        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("ProductId")]
        public SnQTradingCompany.Logic.Entities.Persistence.ItemMaster.Product Product
        {
            get;
            set;
        }
        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("CostumerId")]
        public SnQTradingCompany.Logic.Entities.Persistence.ItemMaster.Costumer Costumer
        {
            get;
            set;
        }
    }
}
