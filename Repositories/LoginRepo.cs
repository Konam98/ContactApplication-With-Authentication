using System.Collections.Generic;
using ContactApplication.Context;
using System.Linq;

namespace ContactApplication.Models
{
    public class LoginRepo : IRepository<Login>
    {
        ApplicationDbContext ctx = new ApplicationDbContext();
        public bool Add(Login uObj)
        {
            bool flag = false;
            if (uObj != null)
            {
                ctx.Login.Add(uObj);
                flag = true;
                ctx.SaveChanges();
            }

            return flag;

        }

        public bool Delete(int Id)
        {

            bool flag = false;
            Login uObj = ctx.Login.FirstOrDefault(p => p.UserId ==  Id);
            if (uObj != null)
            {
                ctx.Login.Remove(uObj);
                flag = true;
                ctx.SaveChanges();
            }

            return flag;
        }

        public IEnumerable<Login> Get()
        {
            IEnumerable<Login> res = ctx.Login.AsEnumerable();
            return res;
            //throw new NotImplementedException();
        }

        public Login Show(int Id)
        {
            return ctx.Login.FirstOrDefault(p => p.UserId == Id);

        }

        public bool UpDate(int Id, Login sObj)
        {

            bool flag = false;
            Login uObj = ctx.Login.FirstOrDefault(p => p.UserId == Id);
            if (uObj != null)
            {
               
                uObj.Email = sObj.Email ;
                uObj.Password = sObj.Password;
               uObj.UserId = sObj.UserId;
                flag = true;
                ctx.SaveChanges();
            }

            return flag;

        }     

        
    }
}