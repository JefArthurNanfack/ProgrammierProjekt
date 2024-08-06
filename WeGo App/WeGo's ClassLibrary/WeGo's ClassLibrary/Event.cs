using System;
using System.Collections.Generic;
using System.Text;

namespace WeGo_s_ClassLibrary
{
    class Event : KurseUndEvents
    {
        public string Name { get; set; }
        public string Datum { get; set; }
        public string Uhrzeit { get; set; }
    }
}
