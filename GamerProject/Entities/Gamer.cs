using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject.Entities
{
    public class Gamer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string NationalityId { get; set; }
        public string UserName { get; set; }
        public DateTime DateofBirth { get; set; }
    }
}
