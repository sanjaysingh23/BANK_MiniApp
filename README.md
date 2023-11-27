# BANK_MiniApp

Welcome to the **BANK_MiniApp** repository! This C# application is a simple representation of a banking system. It includes classes for different types of accounts, 
demonstrates basic transactions, and incorporates a messaging system for account activities.

## Account Class

The `Account` class is an abstract class representing a generic bank account. It includes properties such as `Id`, `Name`, `Balance`, and `AccountType`. 
The class also contains methods for withdrawal and deposit. Object creation is limited to five, and an exception is thrown if this limit is exceeded.

## CurrentAccount Class

The `CurrentAccount` class is derived from the `Account` class, representing a current account. It includes an override for the `withdraw` method and 
utilizes a messaging system for withdrawal activities.

## SavingAccount Class

The `SavingAccount` class, also derived from `Account`, represents a savings account. It overrides the `withdraw` method to include file logging for withdrawals and 
calculates interest based on the account balance.

## Message Class and SendMessage Class

The `Message` class defines two static methods, `sms` and `email`, for displaying messages. The **`SendMessage` class uses events to send messages** 
when account activities occur.

## Program Class

The `Program` class serves as the entry point of the application. It demonstrates the usage of the `Account`, `CurrentAccount`, and `SavingAccount` classes by creating instances, performing transactions, and handling exceptions. It also showcases the messaging system for account activities.

Feel free to explore, modify, and contribute to this mini banking application. If you have any suggestions or improvements, please open an issue or submit a pull request. Enjoy exploring the world of simple banking with the **BANK_MiniApp**!
