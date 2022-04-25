using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilari
{
    class CustomerService:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public Type WorkType { get; set; }
        public bool Statu { get; set; } = true;
    }
}
