using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilari
{
    class Call:IEntity
    {
        public int Id { get; set; }
        public Type CallType { get; set; }
        public Customer Customer { get; set; }
        public CustomerService CustomerService { get; set; }
        public DateTime Date { get; set; }
        public string ServiceNotes { get; set; }
    }
}
