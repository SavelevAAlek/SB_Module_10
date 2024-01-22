using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB_Module_10.Models
{
    public interface IAccount<T>
    {
        T Balance { get; set; }
        void TopUp(decimal amount);
        void Transfer(Account<T> account, decimal amount);
        void Withdraw(decimal amount);
    }
    
}
