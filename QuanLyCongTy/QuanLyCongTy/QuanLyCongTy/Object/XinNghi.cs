using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongTy
{
    public class XinNghi
    {
        DateTime daystart;
        DateTime dayend;
        string lydo;
        string minhchung;
       

        public DateTime DayStart { get { return daystart; } }
        public DateTime DayEnd { get { return dayend; } }
        public string LyDo { get { return lydo; } }
        public string MinhChung { get { return minhchung; } }


        public XinNghi(DateTime daystart, DateTime dayend, string lydo, string minhchung)
        {
            this.daystart = daystart;
            this.dayend = dayend;
            this.lydo = lydo;
            this.minhchung = minhchung;
        }
    }
}
