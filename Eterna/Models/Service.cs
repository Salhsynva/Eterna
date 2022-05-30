using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eterna.Models
{
    public class Service
    {
        public Service(int id,string icon, string title, string body)
        {
            this.Id = id;
            this.Icon = icon;
            this.Body = body;
            this.Title = title;
        }
        public int Id { get; set; }
        public string Icon { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
}
