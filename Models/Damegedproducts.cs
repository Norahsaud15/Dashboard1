using System.ComponentModel.DataAnnotations;

namespace Dashboard1.Models
{
    public class Damegedproducts
    {

        [Key]
        public int Id { get; set; }
        public int Qty { get; set; }
        public int ProductId { get; set; }
    }
}

    