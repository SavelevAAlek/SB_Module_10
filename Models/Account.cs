using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB_Module_10.Models
{
    public class Account<T>
    {
        public T Balance { get; set; }
        public string Id { get; private set; }
        public DateTime? CreatedAt { get; set; }
        public decimal Amount { get; set; }

        public Account(T initialBalance)
        {
            Balance = initialBalance;

            Random random = new Random();
            Id = random.Next(1_000_000, 9_999_999).ToString();

            CreatedAt = DateTime.Now.ToLocalTime();
        }

        

        public override string ToString() => $"{Balance}";
    }
}
