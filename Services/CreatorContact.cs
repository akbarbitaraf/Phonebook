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
  
        public  IContact CreatorConstructor(int type)
        {
            switch (type)
            {
                case 0: return new EssentialContacts();
                case 1: return new NormalContacts();
                case 2: return new ReliefContacts();
                default :throw new Exception();

            }
        }
    }
}
