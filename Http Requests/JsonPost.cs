using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Http_Requests
{
    internal class JsonPost
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public int UserId { get; set; }
        public JsonPost(string title, string body, int id)
        {
            Title = title;
            Body = body;
            UserId = id;
        }
    }
}
