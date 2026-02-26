class User
{
    #pass;
    constructor(pass)
    {
        this.pass = pass;

    }
    set pass(value)
    {
        if(value.length<6)
        {
            console.log("Password must be atleast 6 characters !!");

        }else 
        {
            this.#pass= value;
        }
    }
    get password()
    {
        return this.#pass;
    }
}

//let user1 = new User("123");
let User2 = new User("Pranav123");