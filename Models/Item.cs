using Dapper.Contrib.Extensions;

namespace Mercado.Models
{
    [Table ("[Item]")]
    public class Item
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Quantity { get; set; }

        public int CategoryId { get; set; }
    }
}