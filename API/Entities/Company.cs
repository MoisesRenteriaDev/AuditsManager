using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class Company
    {
        [Key]
        public Guid Id { get; set; }        
        public string Name { get; set; } = string.Empty;
        public string Rfc { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}