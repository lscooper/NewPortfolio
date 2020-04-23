using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WoWChatLogWebParser.Models
{
    public class LineModel
    {
        public PersonModel speaker { get; set; }
        public PersonModel target { get; set; }
        public string text { get; set; }
    }
}
