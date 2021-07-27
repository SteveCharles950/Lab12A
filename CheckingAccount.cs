using System;

class CheckingAccount : BankAccount
    {

override public void CalculateInterest() { 
          double interest = 0.5/100;

          Balance = Balance + (1*interest);
          //return balance;
        }

public override void Withdraw(){
          base.Withdraw();
      
}
      
}