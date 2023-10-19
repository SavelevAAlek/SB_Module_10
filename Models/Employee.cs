using SB_Module_10.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB_Module_10.Models
{
    public abstract class Employee
    {
        protected Repository _repository;
        public Employee()
        {
            _repository = new Repository();
        }

        public override string ToString()
        {
            if (this is Manager) return "Менеджер";
            else return "Консультант";
        }
    }
}
