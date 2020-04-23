using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WoWChatLogWebParser.Models
{
    public class PersonModel
    {
        public string InGame { get; set; }
        public string Display { get; set; }
        public bool IsPlayer { get; set; }
    }
}
