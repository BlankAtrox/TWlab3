using eUseControl.BusinessLogic.Interfaces;
using eUseControl.BusinessLogic.LogicBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUseControl.BusinessLogic
{
     public class InstanceBL
     {
          public ISession GetSessionBL()
          {
               return new SessionBL();
          }
     }
}
