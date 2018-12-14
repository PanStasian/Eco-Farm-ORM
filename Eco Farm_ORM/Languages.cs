using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eco_Farm_ORM
{
    public class Languages
    {
        public Languages(string company, string language)
        {
            Company = company;
            Language = language;
        }

        public int Id { get; set; }
        public string Company { get; set; }
        public string Language { get; set; }
    }
}
