using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace Entities.DB
{
    public class Phone
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(11)]
        public string PhoneNumber { get; set; }

        [ForeignKey("ContactId")]
        public int ContactId { get; set; }
        public Contacts Contact { get; set; }








    }
}