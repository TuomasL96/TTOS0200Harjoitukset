using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht4
{
    [Serializable]
    class TvShow
    {
        public string Name { get; set; }
        public int Channel { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string InfoText { get; set; }

        public TvShow(string name, int channel, string start, string end, string info)
        {
            Name = name;
            Channel = channel;
            StartTime = start;
            EndTime = end;
            InfoText = info;
        }

        public string PrintShow()
        {
            return Name + "\nChannel: " + Channel + "\nStarts: " + StartTime + "\nEnds:" + EndTime + "\nINFO: " + InfoText;
        }
    }
}
