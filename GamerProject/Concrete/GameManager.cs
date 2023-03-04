using GamerProject.Abstract;
using GamerProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject.Concrete
{
    public class GameManager : IGenericService<Game>
    {
        public void Add(Game entity)
        {
            Console.WriteLine("Oyun eklendi" + entity.GameName);
        }

        public void Delete(Game entity)
        {
            Console.WriteLine("Oyun silindi" + entity.GameName);
        }

        public void Update(Game entity)
        {
            Console.WriteLine("Oyun güncellendi" + entity.GameName);
        }
    }
}
