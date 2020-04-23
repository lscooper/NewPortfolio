using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WoWChatLogWebParser.Models
{
    public class InputModel
    {
        public string Input { get; set; }

        public int PersonCount { get; set; }

        public List<PersonModel> People { get; set; }
    }
}
