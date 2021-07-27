using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");

    /*Write code to implement the test cases below*/

            //Test case 1
              //Create a savingsaccount object
            SavingsAccount s1 = new SavingsAccount();
              s1.Deposit(2000);
              s1.Withdraw(5000);
             //Calculate interest
             s1.CalculateInterest(2000);
             s1.Withdraw(500);
            

            /*Test case 2
            * Create a checkingaccount object
            * Deposit $2000
            * Withdraw $5000
            * Calculate interest
            * Withdraw $500
           */
  }
}