using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSheletr.Models
{
    
    public class ExpenseType
    {
        [Key]
        [DisplayName("ID")]
        public short Id { get; set; }

        [DisplayName("Идентификатор Типа")]
        public string NameType { get; set; }

        [DisplayName("Цена")]
        public decimal Cost { get; set; }

        [DisplayName("Остаток")]
        public decimal Count { get; set; }

    }
}
