using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmeApiSdk.Models.Conversation.Converse
{
    public class ConverseRequestParameters
    {
    }
    public class ConverseRequest
    {
        public string question { get; set; }
        public string origin { get; set; }
        public ConverseRequestParameters parameters { get; set; }
        public string channel { get; set; }
    }
}
