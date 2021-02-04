using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSheletr.Models
{
    public class Visitor
    {
        [Key]
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("ФИО")]
        public string Name { get; set; }

        [DisplayName("Дата Рождения")]
        public DateTime DateOfBirth { get; set; }

        [DisplayName("Паспорт")]
        public string Passport { get; set; }

        [DisplayName("Прописка")]
        public string PassportRegistr { get; set; }

        [DisplayName("Телефон")]
        public string Phone { get; set; }

        [DisplayName("Почта")]
        public string Email { get; set; }

    }
}
