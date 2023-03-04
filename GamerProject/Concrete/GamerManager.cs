using GamerProject.Abstract;
using GamerProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject.Concrete
{
    public class GamerManager : IGenericService<Gamer>
    {
        private IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public void Add(Gamer entity)
        {
            if(_gamerCheckService.CheckIfRealPerson(entity))
            {
                Console.WriteLine("Oyuncu eklendi: " + entity.Name + " " + entity.SurName);
            }
            else
            {
                throw new Exception("not a real person");
            }
        }

        public void Delete(Gamer entity)
        {
            Console.WriteLine(entity.Name+" "+entity.SurName+" "+"oyuncu silindi");
        }

        public void Update(Gamer entity)
        {
            Console.WriteLine(entity.Name+" "+entity.SurName+" "+"oyuncu güncellendi");
            throw new NotImplementedException();
        }
    }
}
