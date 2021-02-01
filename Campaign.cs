using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class Campaign : IEntity
    {
        public int CampaignId { get; set; }
        public string CampaignName { get; set; }
        public decimal Price { get; set; }

    }
}
