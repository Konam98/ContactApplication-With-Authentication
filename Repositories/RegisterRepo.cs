using System.Collections.Generic;
using ContactApplication.Context;
using System.Linq;

namespace ContactApplication.Models
{
    public class RegisterRepo : IRepository<Register>
    {
        ApplicationDbContext ctx = new ApplicationDbContext();
        public bool Add(Register sObj)
        {
            bool flag = false;
            if (sObj != null)
            {
                ctx.Register.Add(sObj);
                flag = true;
                ctx.SaveChanges();
            }
            return true;
        }

        public bool Delete(int Id)
        {
            bool flag = false;
            Register pObj = ctx.Register.FirstOrDefault(p => p.UserRegId == Id);
            if (pObj != null)
            {
                ctx.Register.Remove(pObj);
                flag = true;
                ctx.SaveChanges();
            }

            return flag;

        }

        public IEnumerable<Register> Get()
        {
            IEnumerable<Register> res = ctx.Register.AsEnumerable();
            return res;
        }

        public Register Show(int Id)
        {
            return ctx.Register.FirstOrDefault(p => p.UserRegId == Id);
        }

        public bool UpDate(int Id, Register sObj)
        {
            bool flag = false;
            Register pObj = ctx.Register.FirstOrDefault(p => p.UserRegId== Id);
            if (pObj != null)
            {
                pObj.UserName = sObj.UserName;
                pObj.Email = sObj.Email;
                pObj.Password = sObj.Password;
                pObj.MobileNumber = sObj.MobileNumber;
                
                flag = true;
                ctx.SaveChanges();
            }
            return flag;
        }
    }
}

