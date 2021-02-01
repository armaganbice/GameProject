using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;
        public GamerManager(IUserValidationService UserValidationManager)
        {
            _userValidationService = UserValidationManager;
        }
        public void Add(Gamer gamer)
        {
            if (_userValidationService.UserValidate(gamer)==true)
            {
                Console.WriteLine("Gamer added");
            }
            else
            {
                Console.WriteLine("Is not validated,Gamer not added");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer deleted");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer Updated");
        }
    }
}
