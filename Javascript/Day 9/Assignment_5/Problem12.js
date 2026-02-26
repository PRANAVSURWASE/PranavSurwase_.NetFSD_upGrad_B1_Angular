class Wallet {
    #balance=0;
    constructor(initialAmt=0) {
        if(initialAmt>0)
        {
            this.#balance=initialAmt;
        }
     
    }

    addMoney(amount) {
        if (amount <= 0) {
            console.log('Deposit amount must be greater than 0');
            return;
        }
        this.#balance += amount;
        console.log(`${amount} deposited sucessfully`);
    }

    spendMoney(amount) {
        if (amount <= 0) {
            console.log(`withdrawal amount must be greater than 0`);
            return;
        }
        if (amount > this.#balance) {
            console.log('Insufficient Funds. Withdrwal failed');
        } else {
            this.#balance -= amount;
            console.log(`${amount} withdrawn successfully`);
        }
    }
    getBalance() {
        return `current Balance ${this.#balance}`;
    }
}

let myWallet = new Wallet(1000);
myWallet.addMoney(100);

myWallet.spendMoney(200);

console.log(myWallet.getBalance());
