using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnimalSheletr.Models
{
    public class Contract
    {
        [Key]
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("Номер контракта")]
        public string NumContract { get; set; }

        [ForeignKey("Visitor")]
        [DisplayName("Идентификатор Владельца")]
        public int IdOwner { get; set; }
        public Visitor Visitor { get; set; }

        [ForeignKey("Animal")]
        [DisplayName("Идентификатор Животного")]
        public int IdAnimal { get; set; }
        public Animal Animal { get; set; }

        [DisplayName("Дата Подписания")]
        public DateTime DateOfSigning { get; set; }

        [DisplayName("дата Отъезда Животного")]
        public DateTime DepartureDate { get; set; }

    }
}
