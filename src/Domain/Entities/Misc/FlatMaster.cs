using JPBlazor.Domain.Contracts;
using JPBlazor.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPBlazor.Domain.Entities.Misc
{
    public class FlatMaster : AuditableEntity<int>
    {
        [Key]
        public int Number { get; set; }
        public FlatFloorEnum Floor { get; set; }
    }
}
