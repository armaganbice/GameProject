using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class Gamer : IEntity
    {
        public int Id { get; set; }
        public string SurName { get; set; }
        public string LastName { get; set; }
        public DateTime DateofBirth { get; set; }
        public string TcNo { get; set; }
    }

    
}
