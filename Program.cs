using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GameProject by Armağan Bice 1.2.2021");
            IUserValidationService userValidationService = new MernisUserValidationManager();
            Console.WriteLine("Select User Validation Service");
            GamerManager gamerManager = new GamerManager(userValidationService);
            Console.WriteLine("Defined Gamer Manager with select User.Val.Service");
            Gamer gamer1 = new Gamer();
            gamer1.SurName = "Armağan";
            gamer1.LastName = "Bice";
            gamer1.DateofBirth = DateTime.Now;
            gamer1.TcNo = "12345678901";
            gamerManager.Add(gamer1);
            gamerManager.Update(gamer1);
            gamerManager.Delete(gamer1);
            CampaignManager campaignManager = new CampaignManager();
            Campaign campaign1 = new Campaign();
            campaign1.CampaignId = 1;
            campaignManager.Add(campaign1);
            campaignManager.Update(campaign1);
            campaignManager.Delete(campaign1);
            OrderManager orderManager = new OrderManager();
            Order order1 = new Order();
            order1.CampaignId = campaign1.CampaignId;
            Console.WriteLine("Setting Order CampaignId="+order1.CampaignId);
            orderManager.Add(gamer1, order1);
            orderManager.Delete(order1);
            orderManager.Update(order1);
            Console.ReadLine();

        }
    }
}
