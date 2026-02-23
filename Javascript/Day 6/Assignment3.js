
   
        let amt = 4600;

        let discount = 0;
        let finalAmt = 0;

        if (amt >= 4000) {
            discount=amt*.20;


        }
        else if(amt>=3500)
        {
            discount = amt*.10
        }
        else{
            discount =0;
        }
        finalAmt = amt-discount;
        console.log("purchase Amount: "+amt);
        console.log("Discount "+discount);
        console.log("Final Amount :"+finalAmt);

  



