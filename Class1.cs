using Newtonsoft.Json;
using System.Linq;

namespace Övningar
{
    internal class Class1
    {
        public void Go()
        {
            List<BankAccount> accounts = new List<BankAccount>();

            while (true)
            {
                Console.WriteLine("1, Öppna konto. 2, Gör insättning. 3, Göt uttag. 4, Visa kontoinformation.");
                switch(Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Enter 1 for personAccount, Enter 2 for saveAccount");
                        string s = Console.ReadLine();
                        if(s == "2")
                        {
                            var acc = NewCout();
                            accounts.Add(acc);
                        }else if(s == "1")
                        {
                            var acc2 = PersonCout();
                            accounts.Add(acc2);
                        }
                        
                        break;

                    case "2":
                        Console.WriteLine("Skriv in bankid för insättningen");
                        BankAccount retCout = ReturnCout(accounts, int.Parse(Console.ReadLine()));
                        Console.WriteLine("Ange mängden pengar");
                        var action = new Transaction(int.Parse(Console.ReadLine()), retCout.Id, Type.Deposit, DateTime.Now);
                        retCout.NewAction(action);
                        retCout.Deposit();
                        break;

                    case "3":
                        Console.WriteLine("Skriv in bankid för uttaget.");
                        BankAccount retCout2 = ReturnCout(accounts, int.Parse(Console.ReadLine()));
                        if(!retCout2.CanWithraw())
                        {
                            Console.WriteLine("Antal uttag har överskridits för denna period");
                            break;
                        }    
                        Console.WriteLine("Ange mängden pengar");
                        var action2 = new Transaction(int.Parse(Console.ReadLine()), retCout2.Id, Type.Withdrawal, DateTime.Now);
                        retCout2.NewAction(action2);
                        retCout2.Withdraw();
                        break;

                    case "4":
                        Console.WriteLine("Skriv in Id för kontot som ska visas");
                        BankAccount acount = ReturnCout(accounts, int.Parse(Console.ReadLine()));
                        Console.WriteLine($"Saldo: {acount.Sum} kr");
                        break;  
                         
                }
            }
        }
        public BankAccount ReturnCout(List<BankAccount> list, int id)
        {
            foreach (var acc in list)
                if (acc.Id == id)
                    return acc;
            return null;
        }
        public SaveAccount NewCout()
        {
            Console.WriteLine("Enter new id");
            int id = int.Parse(Console.ReadLine());
            SaveAccount acc = new SaveAccount(id, 0);
            return acc;
        }
        public PersonAccount PersonCout()
        {
            Console.WriteLine("Enter new id");
            int id = int.Parse(Console.ReadLine());
            PersonAccount acc = new PersonAccount(id, 0);
            return acc;
        }
    }

    public enum Type
    {
        Withdrawal,
        Deposit
    }
    public class Transaction
    {
        private int _amount;
        private int _id;
        private Type _type;
        private DateTime _time;

        public Transaction(int amount, int id, Type type, DateTime time)
        {
            _amount = amount;
            _id = id;
            _type = type;
            _time = time;
        }
        public int Amount { get { return _amount; } set { _amount = value; } }
        public int Id { get { return _id; } set { _id = value; } }
        public Type Type { get { return _type; } set { _type = value; } }
        public DateTime Time { get { return _time; } set { _time = value; } }
    }
    public abstract class BankAccount
    {
        private int _id;
        private int _sum;

        public List<Transaction> List = new List<Transaction>();

        public BankAccount(int id, int sum)
        {
            _id = id;
            _sum = sum;
        }
        public int Sum { get { return _sum; } set { _sum = value; } }  
        public int Id { get { return _id; } set { _id = value; } }
        public virtual void Withdraw() { }
        public virtual void Deposit() { }
        public virtual void NewAction(Transaction t) { }
        public virtual bool CanWithraw() { return true; }
    }
    public class SaveAccount : BankAccount
    {
        public SaveAccount(int id, int sum):base(id,sum)
        {

        }
        public override void NewAction(Transaction tran)
        {
            List.Add(tran);
        }
        public override bool CanWithraw()
        {
            bool withraw = true;
            int ts = 30;
            var transactions = List.Where(x => (DateTime.Now - x.Time).TotalDays <= 30)
                                   .Where(x => x.Type == Type.Withdrawal).Count();
            if (transactions >= 5)
                withraw = false;

            return withraw;
        } 
        public override void Deposit()
        {
            var obj = List.LastOrDefault(x => x.Type == Type.Deposit);
            Sum += obj.Amount;
        }
        public override void Withdraw()
        {
            var obj = List.LastOrDefault(x => x.Type == Type.Withdrawal); 
            if (Sum - obj.Amount < 0)
                Console.WriteLine("Summan kan ej vara negativ");
            else
                Sum -= obj.Amount;
        }
    }
    public class PersonAccount : BankAccount
    {
        public PersonAccount(int id, int sum):base(id, sum)
        {

        }
        public override void NewAction(Transaction tran)
        {
            List.Add(tran);
        }

        public override void Withdraw()
        {
            var trans = List.Where(x => x.Type == Type.Withdrawal);
            Transaction tran = trans.LastOrDefault();
            if (Sum - tran.Amount < -1000)
                Console.WriteLine("Uttaget överskrider balansen");
            else
                Sum -= tran.Amount;
        }
        public override void Deposit()
        {
            var tran = List.Where(x => x.Type == Type.Deposit).
                             LastOrDefault();
            Sum += tran.Amount;
        }
    }
}

