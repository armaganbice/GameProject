using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class Order : IEntity
    {
        public int OrderId { get; set; }
        public int GamerId { get; set; }
        public int CampaignId { get; set; }
        public DateTime OrderDate { get; set; }
        public Decimal OrderPrice { get; set; }


    }
}
