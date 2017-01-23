using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T7
{
    public class Admin : User
    {
        public bool RmPrivilege { get; set; }
        public string Adminid { get; set; }

        public Admin(string name, bool read, bool write, bool execute, bool rmp, string adminId)
            : base(name, read, write, execute)
        {
            RmPrivilege = rmp;
            Adminid = adminId;
        }
        public override string ToString()
        {
            return base.ToString() + " Car:" + Car + " Bonus:" + Bonus;
        }
    }
}
