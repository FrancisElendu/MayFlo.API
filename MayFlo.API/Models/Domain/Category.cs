using MSSQLFlexCrud;

namespace MayFlo.API.Models.Domain
{
    public class Category :IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string UrlHandle { get; set; }
    }
}
