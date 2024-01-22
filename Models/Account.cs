using System;

namespace SB_Module_10.Models
{
    public class Account<T> : IAccount<T>
    {
        public T Balance { get; set; }
        public string Name { get => Balance.ToString(); }
        public string Number { get; private set; }
        public DateTime? CreatedAt { get; set; }
        public decimal Amount { get; set; }

        public Account(T initialBalance)
        {
            Balance = initialBalance;
            Random random = new Random();

            Number = random.Next(1_000_000, 9_999_999).ToString();
            CreatedAt = DateTime.Now.ToLocalTime();
            Amount = default;
        }

        public override string ToString() => $"{Balance}";

        public void TopUp(decimal amount)
        {
            Amount += amount;
        }

        public void Transfer(Account<T> account, decimal amount)
        {
            Amount -= amount;
            account.Amount += amount;            
        }

        public void Withdraw(decimal amount)
        {
            Amount -= amount;
        }
    }
}
