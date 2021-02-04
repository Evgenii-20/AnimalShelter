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

    
    public class Animal        
    {
        [Key]      
        [DisplayName("ID")]        
        public int Id { get; set; }

        [DisplayName("Идентификатор класса животного")]
        [ForeignKey("Classification")]
        public byte IdClass { get; set; }
        public Classification Classification { get; set; }

        [DisplayName("Пол")]
        public string Gender { get; set; }

        [DisplayName("Кличка")]
        public string Nickname { get; set; }

        [DisplayName("Фото")]
        public string Photo { get; set; }

        [DisplayName("Внешний Вид")]
        public string AppearanceDescr { get; set; }

        [DisplayName("Внешний Вид")]
        public string Notes { get; set; }

        [DisplayName("Дата Поступления")]
        public DateTime ReceiptDate { get; set; }
    }
}
