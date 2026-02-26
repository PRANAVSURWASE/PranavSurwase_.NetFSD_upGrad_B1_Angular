class Payment {
    pay(amount) {
        console.log('Payment method not implemented.');
    }
}

class CreditCardPayment extends Payment {
    pay(amount) {
        console.log(`Paid ₹${amount} using Credit Card `);
    }
}

class UPIPayment extends Payment {
    pay(amount) {
        console.log(`Paid ₹${amount} using UPI `);
    }
}

class CashPayment extends Payment {
    pay(amount) {
        console.log(`Paid ₹${amount} using Cash `);
    }
}

let payments = [new CreditCardPayment(), new UPIPayment(), new CashPayment()];

payments.forEach((p) => p.pay(700));
