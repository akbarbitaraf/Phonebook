using Services.Interfaces;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
   public class CreatorContact : ICreatorContact
    {
  
        public  IContact CreatorConstructor(string type)
        {
            switch (type)
            {
                case "Essential": return new EssentialContacts();
                case "Normal": return new NormalContacts();
                case "Relief": return new ReliefContacts();
                default :throw new Exception();

            }
        }
    }
}
