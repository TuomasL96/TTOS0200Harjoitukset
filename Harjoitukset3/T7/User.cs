using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T7
{
        public class User
        {
            public string Name { get; set; }
            public bool Read { get; set; }
            public bool Write { get; set; }
            public bool Execute { get; set; }

            public User(string name, bool read, bool write, bool execute)
            {
                this.Name = name;
                this.Read = read;
                this.Write = write;
                this.Execute = execute;
            }
            public override string ToString()
            {
                return "- Name:" + Name + " R:" + Read + " W:" + Write + " E:" + Execute;
            }
        
    }
}
