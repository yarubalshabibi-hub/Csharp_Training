using System.Diagnostics.Metrics;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Csharp_Training
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int accountNamber = 0;
            string holderName = "[not set]";
            double balance = 0.000;
            bool accountActive = false;
            char accountType = '-';
            bool employed = false;
            double monthlySalary = 0.000;
            int creditScore = 0;
            int age = 0;
            double lastDepositAmount = 0.000;
            double lastWithdrawa1 = 0.000;
            double annualInterestRate = 0.000;
            double avgMonthlyBalance = 0.000;

            int option;
            int viewOption;

            //task 1

            Console.WriteLine(" === SYSTEM SETUP — Enter Account &Customer Data ===");
            Console.WriteLine("--- Account Profile ---");
            Console.WriteLine("1) Account Number (int) current: " + accountNamber);
            Console.WriteLine("2) Holder Name (string) current: " + holderName);
            Console.WriteLine("3) Balance (double) current: " + balance + "OMR");
            Console.WriteLine("4) Account Active? (bool) current: " + accountActive + "[enter 1=yes / 0=no]");
            Console.WriteLine("5) Account Type (char) current: " + accountType + " [enter S / C / F]");
            Console.WriteLine("--- Customer Profile ---");
            Console.WriteLine("6) Employed? (bool) current: " + employed + "[enter 1=yes / 0=no]");
            Console.WriteLine("7) Monthly Salary (double) current: " + monthlySalary + " OMR");
            Console.WriteLine("8) Credit Score (int) current: " + creditScore);
            Console.WriteLine("9) Age (int) current: " + age);
            Console.WriteLine("--- Transaction Data ---");
            Console.WriteLine("10) Last Deposit Amount (double) current: " + lastDepositAmount + " OMR");
            Console.WriteLine("11) Last Withdrawal Amount (double) current: " + lastWithdrawa1 + " OMR");
            Console.WriteLine("12) Annual Interest Rate (double) current: " + annualInterestRate + "%");
            Console.WriteLine("13) Average Monthly Balance (double) current: " + avgMonthlyBalance + " OMR");
            Console.WriteLine("0) Setup complete — launch Main Menu");


            Console.WriteLine("Select option: ");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter Account Number (int): ");
                    accountNamber = int.Parse(Console.ReadLine());
                    Console.WriteLine("Account Number set to: " + accountNamber);
                    break;
                case 2:
                    Console.WriteLine("Enter Holder Name (string): ");
                    holderName = Console.ReadLine();
                    Console.WriteLine("Holder Name set to: " + holderName);
                    break;
                case 3:
                    Console.WriteLine("Enter Balance (double): ");
                    balance = double.Parse(Console.ReadLine());
                    Console.WriteLine("Balance set to: " + balance + " OMR");
                    break;
                case 4:
                    Console.WriteLine("Is the account active? (1 for yes, 0 for no): ");
                    accountActive = Console.ReadLine() == "1";
                    Console.WriteLine("Account Active set to: " + accountActive);
                    break;
                case 5:
                    Console.WriteLine("Enter Account Type (char) [S/C/F]: ");
                    accountType = char.Parse(Console.ReadLine());
                    Console.WriteLine("Account Type set to: " + accountType);
                    break;
                case 6:
                    Console.WriteLine("Is the customer employed? (1 for yes, 0 for no): ");
                    employed = Console.ReadLine() == "1";
                    Console.WriteLine("Employed set to: " + employed);
                    break;
                case 7:
                    Console.WriteLine("Enter Monthly Salary (double): ");
                    monthlySalary = double.Parse(Console.ReadLine());
                    Console.WriteLine("Monthly Salary set to: " + monthlySalary + " OMR");
                    break;
                case 8:
                    Console.WriteLine("Enter Credit Score (int): ");
                    creditScore = int.Parse(Console.ReadLine());
                    Console.WriteLine("Credit Score set to: " + creditScore);
                    break;
                case 9:
                    Console.WriteLine("Enter Age (int): ");
                    age = int.Parse(Console.ReadLine());
                    Console.WriteLine("Age set to: " + age);
                    break;
                case 10:
                    Console.WriteLine("Enter Last Deposit Amount (double): ");
                    lastDepositAmount = double.Parse(Console.ReadLine());
                    Console.WriteLine("Last Deposit Amount set to: " + lastDepositAmount + " OMR");

                    break;
                case 11:
                    Console.WriteLine("Enter Last Withdrawal Amount (double): ");
                    lastWithdrawa1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Last Withdrawal Amount set to: " + lastWithdrawa1 + " OMR");
                    break;
                case 12:
                    Console.WriteLine("Enter Annual Interest Rate (double) in percentage: ");
                    annualInterestRate = double.Parse(Console.ReadLine());
                    Console.WriteLine("Annual Interest Rate set to: " + annualInterestRate + "%");
                    break;
                case 13:
                    Console.WriteLine("Enter Average Monthly Balance (double): ");
                    avgMonthlyBalance = double.Parse(Console.ReadLine());
                    Console.WriteLine("Average Monthly Balance set to: " + avgMonthlyBalance + " OMR");
                    break;
                case 0:
                    Console.WriteLine("Setup complete. Launching Main Menu...");
                    // Here you can add code to launch the main menu or continue with the program
                    break;
                default:
                    Console.WriteLine("Invalid option. Please select a valid option.");
                    break;
            }



            //task 2
            Console.WriteLine("=== ATM SERVICES ===");
            Console.WriteLine("1) Bank Info");
            Console.WriteLine("2) Branch Info");
            Console.WriteLine("3) Opening Hours");
            Console.WriteLine("0) Back to Main Menu");
            Console.WriteLine("Select option: ");
            int atmOption = int.Parse(Console.ReadLine());
            Console.WriteLine("You selected option: " + atmOption);


            //task 3
            Console.WriteLine("===  VIEW ACCOUNT DATA ===");
            Console.WriteLine("Data loaded from system setup:");
            Console.WriteLine("1) Account Number: " + accountNamber);
            Console.WriteLine("2) Holder Name: " + holderName);
            Console.WriteLine("3) Balance: " + balance + " OMR");
            Console.WriteLine("4) Account status: " + (accountActive + "Active"));
            Console.WriteLine("5) Account Type: " + accountType);
            Console.WriteLine("0) back to Main Menu");
            Console.WriteLine("Select field: ");
            viewOption = int.Parse(Console.ReadLine());

            switch (viewOption)
            {
                case 1:
                    Console.WriteLine("Account Number: " + accountNamber);
                    break;

                case 2:
                    Console.WriteLine("Holder Name: " + holderName);
                    break;

                case 3:
                    Console.WriteLine("Balance:" + balance);
                    break;

                case 4:
                    Console.WriteLine("Account status:" + accountActive);
                    break;

                case 5:
                    Console.WriteLine("Acco-unt Type:" + accountType);
                    break;

                case 0:
                    Console.WriteLine("back to Main Menu");
                    break; 
                
                default:
                    Console.WriteLine("Invalid Option"); 
                    break;

                    //task 4
                    const int CORRECT_PIN = 4821;
                    const int MAX_ATTEMPTS = 3;
                    holderName = "Sara Al-Balushi";
                    int attempts = 0;
                    bool authenticated = false;
                

                    Console.WriteLine("=== AUTHENTICATION ===");
                    Console.WriteLine("1) Enter PIN:");
                    Console.WriteLine("2) Forgot PIN");
                    Console.WriteLine("0) Back");
                    Console.Write("Select: ");
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.Write("> Enter PIN: ");
                            string pinInput = Console.ReadLine();
                            attempts++;
                            if (pinInput.Length != 4)
                            
                                Console.WriteLine("Invalid PIN format.");
                            
                            else if (pinInput == CORRECT_PIN.ToString())
                            {
                                Console.WriteLine($"Access granted. Welcome, {holderName}.");
                                authenticated = true;
                            }
                            else
                            {
                                Console.WriteLine("Incorrect PIN.");
                            }
                            break;

                        case 2:
                            Console.WriteLine("Please visit the nearest branch with your National ID.");
                            break;

                        case 0:
                            Console.WriteLine("Returning to previous menu...");
                            return;

                        default:
                            Console.WriteLine("Invalid selection. Try again.");
                         
                           break;

                    }

                    if (attempts >= MAX_ATTEMPTS && !authenticated) 
                    {
                        Console.WriteLine("Maximum attempts reached. Card blocked.");


                        //task 5
                        Console.WriteLine("=== PRINT RECEIPT ===");
                        Console.WriteLine("1) Short Receipt");
                        Console.WriteLine("2) Detailed Receipt");
                        Console.WriteLine("3) Balance Only");
                        Console.WriteLine("0) Back");
                        Console.WriteLine("Select format: _");
                        Console.WriteLine("Account : ");
                        Console.WriteLine("Holder : ");
                        Console.WriteLine("Balance");

                        int ATMReceiptPrinter = int.Parse(Console.ReadLine());
                        switch( ATMReceiptPrinter)
                        {
                            case 1:
                                Console.WriteLine("Account: " + accountNamber);
                                Console.WriteLine("Holder : " + holderName);
                                Console.WriteLine("Balance : " + balance);

                                break;
                            case 2:
                                
                                Console.WriteLine(" Account Number: " + accountNamber);
                                Console.WriteLine(" Holder Name: " + holderName);
                                Console.WriteLine(" Balance: " + balance + "OMR");
                                Console.WriteLine(" Account Active? " + accountActive);
                                Console.WriteLine(" Account Type " + accountType);
                                Console.WriteLine(" Employed?" + employed);
                                Console.WriteLine(" Monthly Salary" + monthlySalary + " OMR");
                                Console.WriteLine(" Credit Score" + creditScore);
                                Console.WriteLine(" Age" + age);
                                Console.WriteLine("Last Deposit Amount" + lastDepositAmount + " OMR");
                                Console.WriteLine(" Last Withdrawal Amount" + lastWithdrawa1 + " OMR");
                                Console.WriteLine(" Annual Interest Rate " + annualInterestRate + "%");
                                Console.WriteLine(" Average Monthly Balance" + avgMonthlyBalance + " OMR");
                                break; 
                            case 3:
                                Console.WriteLine("balance: " + balance +" OMR ");
                                break;




                        }

                    }
            }
        }
    }
}
                       
               