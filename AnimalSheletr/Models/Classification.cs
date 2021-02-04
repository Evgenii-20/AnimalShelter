using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AnimalSheletr.Models
{
    public class Classification
    {   [Key]
        [DisplayName("Идентификатор ")]
        public byte Id { get; set; }
               
        [DisplayName("Классификация")]
        public string Class { get; set; }
    }
}

