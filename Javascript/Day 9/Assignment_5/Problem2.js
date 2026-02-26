class BankAccount {
    constructor(accountHolder, balance) {
        this.accountHolder = accountHolder;
        this.balance = balance;
    }

    deposite(amount) {
        if (amount <= 0) {
            console.log('Deposit amount must be greater than 0');
            return;
        }
        this.balance = +amount;
        console.log(`${amount} deposited sucessfully`);
    }

    withdraw(amount) {
        if (amount <= 0) {
            console.log(`withdrawal amount must be greater than 0`);
            return;
        }
        if (amount > this.balance) {
            console.log('Insufficient Funds. Withdrwal failed');
        } else {
            this.balance -= amount;
            console.log(`${amount} withdrawn successfully`);
        }
    }
    checkBalance() {
        console.log(`current Balance ${this.balance}`);
    }
}

let account1 = new BankAccount('Pranav Surwase', 23000);
account1.withdraw(20000);

account1.checkBalance();
account1.deposite(120);
account1.checkBalance();
