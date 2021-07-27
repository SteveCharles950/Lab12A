using System;

class SavingsAccount : BankAccount
    {
override public void CalculateInterest() { 
          double interest = 5/100;

          Balance = Balance + (1*interest);
          //return balance;
        }

public virtual void Withdraw(){
        if(Balance < 2000){
          Console.WriteLine("Insufficient balance");
        } else{
          base.Withdraw();
        }
}
      
    }