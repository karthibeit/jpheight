using JPBlazor.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPBlazor.Domain.Entities.Catalog
{
    public class Flats : AuditableEntity<int>
    {
        [Key]
        public int Number { get; set; }
        public string Name { get; set; }
        public int  Floor { get; set; }
        public bool IsRental { get; set; }
        public string Owner { get; set; }
    }
}
