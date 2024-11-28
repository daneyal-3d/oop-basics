using System;

class ATM {
    public void WithdrawMoney() {
        AuthenticateUser();
        ProcessTransaction();
        DispenseMoney();
    }

    private void AuthenticateUser() {
        Console.WriteLine("User authenticated.");
    }

    private void ProcessTransaction() {
        Console.WriteLine("Transaction processed.");
    }

    private void DispenseMoney() {
        Console.WriteLine("Money dispensed.");
    }
}

class Program {
    static void Main() {
        ATM atm = new ATM();
        atm.WithdrawMoney(); 
    }
}