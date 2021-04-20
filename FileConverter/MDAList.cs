using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileConverter
{
    public class MDAListItem
    {
        public string mdaCode { get; set; }
        public string mdaName { get; set; }
    }

    public class MDAList
    {
        public List<MDAList> MDAListItems { get; set; }
    }

}
