using GamerProject.Abstract;
using GamerProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject.Concrete
{
    public class CampaignManager : IGenericService<Campaign>
    {
        public void Add(Campaign entity)
        {
            Console.WriteLine("Kampanya eklendi" + entity.CampaignName);
        }

        public void Delete(Campaign entity)
        {
            Console.WriteLine("Kampanya silindi" + entity.CampaignName); 
        }

        public void Update(Campaign entity)
        {
            Console.WriteLine("Kampanya güncellendi" + entity.CampaignName);
        }
    }
}
