using System;
using Entities;

namespace BankAccount
{
    internal class Program
    {
        private static readonly CustomerManagement CtmManagement = new CustomerManagement();
        private static readonly AccountManagement AccManagement = new AccountManagement();
        private static readonly AddressManagement AddManagement = new AddressManagement();


        private static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("CENFO BANK");
            ShowMenu();
        }

        private static void ShowMenu()
        {
            var option = -1;
            while (option != 6)
            {
                Console.WriteLine();
                Console.WriteLine("***MAIN MENU***");
                Console.WriteLine();
                Console.WriteLine("1. Customer\n" +
                                  "2. Account\n" +
                                  "3. Address\n" +
                                  "4. Show Account by ID\n" +
                                  "5. Update Account\n" +
                                  "6. Exit");
                Console.WriteLine();
                Console.WriteLine("Choose an option: ");
                option = int.Parse(Console.ReadLine());
                Console.WriteLine();
                ProcessMainMenu(option);
            }
        }

        private static void ProcessMainMenu(int pOption)
        {
            switch (pOption)
            {
                case 1:
                    ShowCustomerMenu();
                    break;
                case 2:
                    ShowAccountMenu();
                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
        }

        private static void ShowCustomerMenu()
        {
            var option = -1;
            while (option != 7)
            {
                Console.WriteLine();
                Console.WriteLine("***MAIN MENU***");
                Console.WriteLine();
                Console.WriteLine("1. Customer Registration\n" +
                                  "2. Delete Customer\n" +
                                  "3. Show Customer (All)\n" +
                                  "4. Show Customer by ID\n" +
                                  "5. Update Customer\n" +
                                  "6. Manage Customer Address\n" +
                                  "7. Exit");
                Console.WriteLine();
                Console.WriteLine("Choose an option: ");
                option = int.Parse(Console.ReadLine());
                Console.WriteLine();
                ProcessCustomerMenu(option);
            }
        }

        private static void ProcessCustomerMenu(int pOption)
        {
            switch (pOption)
            {
                case 1:
                    //CreateCustomer();
                    break;
                case 2:
                    DeleteCustomer();
                    break;
                case 3:
                    RetrieveAllCustomers();
                    break;
                case 4:
                    SearchCustomer();
                    break;
                case 5:
                    UpdateCustomer();
                    break;
                case 6:
                    ShowAddressMenu();
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
        }


        private static void ShowAccountMenu()
        {
            var option = -1;
            while (option != 6)
            {
                Console.WriteLine();
                Console.WriteLine("***MAIN MENU***");
                Console.WriteLine("***ACCOUNTS***");
                Console.WriteLine();
                Console.WriteLine("1. Account Registration\n" +
                                  "2. Delete Account\n" +
                                  "3. Show Accounts (All)\n" +
                                  "4. Show Account by ID\n" +
                                  "5. Update Account\n" +
                                  "6. Exit");
                Console.WriteLine();
                Console.WriteLine("Choose an option: ");
                option = int.Parse(Console.ReadLine());
                Console.WriteLine();
                ProcessAccountMenu(option);
            }
        }

        private static void ProcessAccountMenu(int pOption)
        {
            switch (pOption)
            {
                case 1:
                    AccountRegistration();
                    break;
                case 2:
                    DeleteAccount();
                    break;
                case 3:
                    RetrieveAllAccounts();
                    break;
                case 4:
                    SearchAccount();
                    break;
                case 5:
                    UpdateAccount();
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
        }

        private static void ShowAddressMenu()
        {
            var option = -1;
            while (option != 6)
            {
                Console.WriteLine();
                Console.WriteLine("***MAIN MENU***");
                Console.WriteLine();
                Console.WriteLine("1. Address Registration\n" +
                                  "2. Show Address (All)\n" +
                                  "3. Show Address by ID\n" +
                                  "4. Update Address\n" +
                                  "5. Delete Address\n" +
                                  "6. Exit");
                Console.WriteLine();
                Console.WriteLine("Choose an option: ");
                option = int.Parse(Console.ReadLine());
                Console.WriteLine();
                ProcessAddressMenu(option);
            }
        }

        private static void ProcessAddressMenu(int pOption)
        {
            switch (pOption)
            {
                case 1:
                    AddressRegistration();
                    break;
                //case 2:
                //    RetrieveAllAddresses();
                //    break;
                //case 3:
                //    SearchAddress();
                //    break;
                //case 4:
                //    UpdateAddress();
                //    break;
                //case 5:
                //    DeleteAddress();
                //    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
        }

        private static void AccountRegistration()
        {
            var account = new Account();
            Console.WriteLine();
            Console.WriteLine("Fill the forms with the required information");
            Console.WriteLine();
            Console.Write("ID: ");
            account.Identification = Console.ReadLine();
            Console.Write("Account name: ");
            account.AccountName = Console.ReadLine();
            Console.Write("Account number: ");
            account.AccoutNumber = Console.ReadLine();
            Console.Write("Customer Account Number: ");
            account.CustomerAccountNumber = Console.ReadLine();
            Console.Write("Currency: ");
            account.Currency = Console.ReadLine();
            Console.Write("Balance: ");
            account.Balance = int.Parse(Console.ReadLine());
            Console.Write("Aperture Date: ");
            account.ApertureDate = Console.ReadLine();
            Console.Write("State: ");
            account.State = Console.ReadLine();

            AccManagement.Create(account);
            Console.WriteLine();
            Console.WriteLine("Account Registration Successfull");
        }

        private static void RetrieveAllAccounts()
        {
            Console.WriteLine("Account List");
            Console.WriteLine();
            var lstAccounts = AccManagement.RetrieveAll();
            var count = 0;

            foreach (var c in lstAccounts)
            {
                count++;
                Console.WriteLine(count + " ==> " + c.GetEntityInformation());
            }
        }

        private static void SearchAccount()
        {
            var account = new Account();
            Console.WriteLine();
            Console.WriteLine("Type the ID number of the account you want to search: ");
            account.Identification = Console.ReadLine();
            Console.WriteLine();
            account = AccManagement.RetrieveById(account);
            if (account != null)
                Console.WriteLine(" ==> " + account.GetEntityInformation());
            else
                Console.WriteLine("ERROR: Account Not Found");
        }

        private static void DeleteAccount()
        {
            var account = new Account();
            Console.WriteLine("Account Deletion");
            Console.WriteLine("Type the ID of the account you want to delete: ");
            account.Identification = Console.ReadLine();
            account = AccManagement.RetrieveById(account);
            if (account != null)
            {
                Console.WriteLine(" ==> " + account.GetEntityInformation());
                Console.WriteLine("Are you sure? Y/N");
                var delete = Console.ReadLine();

                if (delete.Equals("Y", StringComparison.CurrentCultureIgnoreCase))
                {
                    AccManagement.Delete(account);
                    Console.WriteLine("Account Deletion Successfull");
                }
            }
            else
            {
                throw new Exception("ERROR: No Accounts Registered");
            }
        }

        private static void UpdateAccount()
        {
            var account = new Account();
            Console.WriteLine("Update Account");
            Console.WriteLine();
            Console.WriteLine("Type the ID of the account: ");
            account.Identification = Console.ReadLine();
            account = AccManagement.RetrieveById(account);

            if (account != null)
            {
                Console.Write(" ==> " + account.GetEntityInformation());
                Console.WriteLine();
                Console.WriteLine("Account Name: ");
                account.AccountName = Console.ReadLine();
                Console.WriteLine("Account Number: ");
                account.AccoutNumber = Console.ReadLine();
                Console.WriteLine("Customer Account Number: ");
                account.CustomerAccountNumber = Console.ReadLine();
                Console.WriteLine("Currency: ");
                account.Currency = Console.ReadLine();
                Console.WriteLine("Balance: ");
                account.Balance = int.Parse(Console.ReadLine());
                Console.WriteLine("Aperture Date: ");
                account.ApertureDate = Console.ReadLine();
                Console.WriteLine("State: ");
                account.State = Console.ReadLine();

                AccManagement.Update(account);
                Console.WriteLine("Account Update Successfull");
            }
            else
            {
                throw new Exception("ERROR: No Accounts Registered");
            }
        }


        //private static void CreateCustomer()
        //{
        //    Console.WriteLine("***************************");
        //    Console.WriteLine("*****     CREATE    *******");
        //    Console.WriteLine("***************************");
        //    var customer = new Customer();
        //    Console.WriteLine("Type the id, name, last_name and age separated by comma");
        //    var info = Console.ReadLine();
        //    var infoArray = info.Split(',');

        //    customer = new Customer(infoArray);
        //    CtmManagement.Create(customer);

        //    Console.WriteLine("Customer was created");
        //}

        private static void RetrieveAllCustomers()
        {
            Console.WriteLine("***************************");
            Console.WriteLine("*****  RETRIEVE ALL   *****");
            Console.WriteLine("***************************");

            var lstCustomers = CtmManagement.RetrieveAll();
            var count = 0;

            foreach (var c in lstCustomers)
            {
                count++;
                Console.WriteLine(count + " ==> " + c.GetEntityInformation());
            }
        }

        private static void SearchCustomer()
        {
            var customer = new Customer();
            Console.WriteLine("Type the customer id:");
            customer.Id = Console.ReadLine();
            customer = CtmManagement.RetrieveById(customer);

            if (customer != null) Console.WriteLine(" ==> " + customer.GetEntityInformation());
        }

        private static void UpdateCustomer()
        {
            Console.WriteLine("***************************");
            Console.WriteLine("******  UPDATE  **    *****");
            Console.WriteLine("***************************");
            var customer = new Customer();
            Console.WriteLine("Type the customer id:");
            customer.Id = Console.ReadLine();
            customer = CtmManagement.RetrieveById(customer);

            if (customer != null)
            {
                Console.WriteLine(" ==> " + customer.GetEntityInformation());
                Console.WriteLine("Type a new name, actual value is " + customer.Name);
                customer.Name = Console.ReadLine();
                Console.WriteLine("Type a new last name, actual value is " + customer.LastName);
                customer.LastName = Console.ReadLine();
                Console.WriteLine("Type a new age, actual value is " + customer.Age);
                var textAge = Console.ReadLine();
                customer.Age = int.TryParse(textAge, out var age) ? age : customer.Age;

                CtmManagement.Update(customer);
                Console.WriteLine("Customer was updated");
            }
            else
            {
                throw new Exception("Customer not registered");
            }
        }

        private static void DeleteCustomer()
        {
            var customer = new Customer();
            Console.WriteLine("Type the customer id:");
            customer.Id = Console.ReadLine();
            customer = CtmManagement.RetrieveById(customer);

            if (customer != null)
            {
                Console.WriteLine(" ==> " + customer.GetEntityInformation());

                Console.WriteLine("Delete? Y/N");
                var delete = Console.ReadLine();

                if (delete.Equals("Y", StringComparison.CurrentCultureIgnoreCase))
                {
                    CtmManagement.Delete(customer);
                    Console.WriteLine("Customer was deleted");
                }
            }
            else
            {
                throw new Exception("Customer not registered");
            }
        }


        private static void AddressRegistration()
        {
            var address = new Address();
            Console.WriteLine();
            Console.WriteLine("Fill the forms with the required information");
            Console.WriteLine();
            Console.Write("ID of the customer: ");
            address.IDCustomer = Console.ReadLine();
            Console.Write("Province: ");
            address.Province = Console.ReadLine();
            Console.Write("Street: ");
            address.Street = Console.ReadLine();
            Console.Write("District: ");
            address.District = Console.ReadLine();


            AddManagement.Create(address);
            Console.WriteLine();
            Console.WriteLine("Address Registration Successfull");
        }

        // static void RetrieveAllAddresses()
        //{
        //    Console.WriteLine("Address List");
        //    Console.WriteLine();
        //    var lstAddress = AddManagement.RetrieveAll();
        //    var count = 0;

        //    foreach (var c in lstAddress)
        //    {
        //        count++;
        //        Console.WriteLine(count + " ==> " + c.GetEntityInformation());
        //    }
        //}

        // static void SearchAddress()
        //{
        //    var address = new Address();
        //    Console.WriteLine();
        //    Console.WriteLine("Type the ID number of the address you want to search: ");
        //    address.IDCustomer = Console.ReadLine();
        //    Console.WriteLine();
        //    address = AddManagement.RetrieveById(address);
        //    if (address != null)
        //        Console.WriteLine(" ==> " + address.GetEntityInformation());
        //    else
        //        Console.WriteLine("ERROR: Address Not Found");
        //}

        // static void DeleteAddress()
        //{
        //    var address = new Address();
        //    Console.WriteLine("Address Deletion");
        //    Console.WriteLine("Type the ID of the address you want to delete: ");
        //    address.IDCustomer = Console.ReadLine();
        //    address = AddManagement.RetrieveById(address);
        //    if (address != null)
        //    {
        //        Console.WriteLine(" ==> " + address.GetEntityInformation());
        //        Console.WriteLine("Are you sure? Y/N");
        //        var delete = Console.ReadLine();

        //        if (delete.Equals("Y", StringComparison.CurrentCultureIgnoreCase))
        //        {
        //            AddManagement.Delete(address);
        //            Console.WriteLine("Address Deletion Successfull");
        //        }
        //    }
        //    else
        //    {
        //        throw new Exception("ERROR: No Address Registered");
        //    }
        //}

        // static void UpdateAddress()
        //{
        //    var address = new Address();
        //    Console.WriteLine("Update Address");
        //    Console.WriteLine();
        //    Console.WriteLine("Type the ID of the address: ");
        //    address.IDCustomer = Console.ReadLine();
        //    address = AddManagement.RetrieveById(address);

        //    if (address != null)
        //    {
        //        Console.Write(" ==> " + address.GetEntityInformation());
        //        Console.WriteLine();
        //        Console.WriteLine("Province: ");
        //        address.Province = Console.ReadLine();
        //        Console.WriteLine("Street: ");
        //        address.Street = Console.ReadLine();
        //        Console.WriteLine("District: ");
        //        address.District = Console.ReadLine();


        //        AddManagement.Update(address);
        //        Console.WriteLine("Address Update Successfull");
        //    }
        //    else
        //    {
        //        throw new Exception("ERROR: No Address Registered");
        //    }
        //}
    }
}