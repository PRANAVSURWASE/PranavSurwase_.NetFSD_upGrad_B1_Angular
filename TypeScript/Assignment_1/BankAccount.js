"use strict";
class BankAccount {
    name;
    accountNumber;
    accountType;
    balance;
    constructor(name, accNo, type, balance) {
        this.name = name;
        this.accountNumber = accNo;
        this.accountType = type;
        this.balance = balance;
    }
    deposit(amount) {
        this.balance += amount;
        console.log("Deposited :", amount);
    }
    withdraw(amount) {
        if (amount > this.balance) {
            console.log("Insufficient Funds");
        }
        else {
            this.balance -= amount;
            console.log("Withdrawn ", amount);
        }
    }
    display() {
        console.log("Name:", this.name);
        console.log("Balance:", this.balance);
    }
}
let acc = new BankAccount("Pratik ", 3953293, "Savings", 670000);
acc.deposit(13444);
acc.withdraw(78000);
acc.display();
