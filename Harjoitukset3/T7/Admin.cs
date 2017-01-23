using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T7
{
    public class Admin : User
    {
        public bool RmUserPrivilege { get; set; }
        public string Adminid { get; set; }

        public Admin(string name, bool read, bool write, bool execute, bool rmp, string adminId)
            : base(name, read, write, execute)
        {
            RmUserPrivilege = rmp;
            Adminid = adminId;
        }
        public override string ToString()
        {
            return base.ToString() + " CanRmUsers:" + RmUserPrivilege + " adminID:" + Adminid;
        }
    }
}
