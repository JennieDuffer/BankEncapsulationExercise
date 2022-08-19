using BankEncapsulationExercise;

BankAccount myBankAccount = new BankAccount();

myBankAccount.Deposit(500.00);
Console.WriteLine(myBankAccount.GetBalance());

myBankAccount.WithDraw(200.00);
Console.WriteLine(myBankAccount.GetBalance());


