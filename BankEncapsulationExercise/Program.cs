using BankEncapsulationExercise;

BankAccount myBankAccount = new BankAccount();

Console.WriteLine("Please make your deposit: ");
double amountToDeposit = double.Parse(Console.ReadLine());

myBankAccount.Deposit(amountToDeposit);
Console.WriteLine(myBankAccount.GetBalance());

myBankAccount.WithDraw(200.00);
Console.WriteLine(myBankAccount.GetBalance());


