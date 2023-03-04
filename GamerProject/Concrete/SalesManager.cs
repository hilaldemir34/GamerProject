using GamerProject.Abstract;
using GamerProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject.Concrete
{
    public class SalesManager : ISalesService
    {
        public void Add(Game game, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine("Oyun Satışı");
            Console.WriteLine(game.GameName+""+gamer.Name+""+gamer.SurName);
            Console.WriteLine("Yararlanılan kampanya:"+ campaign.CampaignName);
        }
    }
}
