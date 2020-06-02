using eUseControl.BusinessLogic.Interfaces;
using eUseControl.BusinessLogic.LogicBL;

namespace eUseControl.BusinessLogic
{
     public class BussinesLogic
     {
          public ISession GetSessionBL()
          {
               return new SessionBL();
          }

          public IRegister GetRegisterBL()
          {
               return new RegisterBL();
          }
     }
}

