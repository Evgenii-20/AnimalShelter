using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSheletr.Models
{
   public class Expense
    {
        [Key]
        [DisplayName("ID")]
        public int Id { get; set; }

        [ForeignKey("ExpenseType")]
        [DisplayName("Идентификатор Типов затрат")]
        public short IdExpenseType { get; set; }
        public ExpenseType ExpenseType { get; set; }

        [ForeignKey("Animal")]
        [DisplayName("Идентификатор Животного ")]
        public int IdAnimal { get; set; }
        public Animal Animal { get; set; }

        [DisplayName("Количество")]
        public decimal Count { get; set; }

        [DisplayName("Примечание")]
        public string Notes { get; set; }

        [DisplayName("Дата и Время")]
        public DateTime DateTimeNote { get; set; }

    }
}
