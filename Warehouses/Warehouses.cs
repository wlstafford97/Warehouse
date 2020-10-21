using System;
using System.Collections.Generic;


//Developer: William Lucas Stafford
//10/21/20
namespace Warehouses
{
    class Warehouses
    {
        static void Main(string[] args)
        {
            //initializing the inventory objects
            //each warehouse is initialized based on the integer passed into the constructor
            Inventory inv = new Inventory();
            Inventory atlanta = new Inventory(0);
            Inventory baltimore = new Inventory(1);
            Inventory chicago = new Inventory(2);
            Inventory denver = new Inventory(3);
            Inventory ely = new Inventory(4);
            Inventory fargo = new Inventory(5);

            string action = null; //string to hold whether its a sell/buy
            int part = 0; //integer to hold the part
            int quantity = 0; //integer to hold the part quantity
            int quantity2 = 0; //integer to hold the amount of parts being sold/bought
            int[] answer = new int[2]; //int array that holds the answers returned from compareTo method
            int wh = 0; //integer to hold the warehouse number
            int transaction = 1; //integer to hold the number or transactions
            string[] test = inv.readTransFile(); //string array that will hold the strings passed from the transactionfile

            Console.WriteLine(" --------------------------");
            Console.WriteLine("|Beginning of Day Inventory|");
            Console.WriteLine(" --------------------------\n");
            inv.writeInventory(); //calls the method to write the inventory

            Console.WriteLine(" --------------------------");
            Console.WriteLine("| Transactions for the Day |");
            Console.WriteLine(" --------------------------\n");

            //will loop through the entire test array to complete each transaction
            for (int i = 0; i < test.Length; i++)
            {
                string[] var = test[i].Split(','); //splits each test string by the comma
                action = var[0]; //action is set to the first string in var array
                part = int.Parse(var[1]); //part is parsed from the var string array
                quantity = int.Parse(var[2]); //quantity is parsed from the var string array
                Console.WriteLine("Transaction: " + transaction); //writes down each transaction

                if (action.Equals("S")) //if statement used to see if the transaction is a sell or buy
                {
                    answer = atlanta.compareTo(baltimore, chicago, denver, ely, fargo, part, "S"); //answer variable is set to the returned value from compareto method
                    quantity2 = answer[0]; //quantity being sold/bought 
                    wh = answer[1]; //warehouse being sold/bought from

                    switch (wh) //switch statement that will call on the appropriate warehouse case number 0 being atlanta - 5 fargo
                    {
                        case 0:
                            switch (part) //switch statement that will call on the appropriate part number being passed from the part integer
                            {
                                //depending upon which part is being processed for that transaction, the appropriate case will be enacted
                                case 102:
                                    atlanta.part102 = quantity2 - quantity; //subtracts the quantity from the appropriate part number
                                    Console.WriteLine("Atlanta warehouse sold " + quantity + " of part " + part); //writes on console to confirm transaction
                                    break;
                                case 215:
                                    atlanta.part215 = quantity2 - quantity;
                                    Console.WriteLine("Atlanta warehouse sold " + quantity + " of part " + part);
                                    break;
                                case 410:
                                    atlanta.part410 = quantity2 - quantity;
                                    Console.WriteLine("Atlanta warehouse sold " + quantity + " of part " + part);
                                    break;
                                case 525:
                                    atlanta.part525 = quantity2 - quantity;
                                    Console.WriteLine("Atlanta warehouse sold " + quantity + " of part " + part);
                                    break;
                                case 711:
                                    atlanta.part711 = quantity2 - quantity;
                                    Console.WriteLine("Atlanta warehouse sold " + quantity + " of part " + part);
                                    break;
                            }
                            break;
                            //does the same thing throught this entire switch statement as the comments above has stated
                        case 1:
                            switch (part)
                            {
                                case 102:
                                    baltimore.part102 = quantity2 - quantity;
                                    Console.WriteLine("baltimore warehouse sold " + quantity + " of part " + part);
                                    break;
                                case 215:
                                    baltimore.part215 = quantity2 - quantity;
                                    Console.WriteLine("baltimore warehouse sold " + quantity + " of part " + part);
                                    break;
                                case 410:
                                    baltimore.part410 = quantity2 - quantity;
                                    Console.WriteLine("baltimore warehouse sold " + quantity + " of part " + part);
                                    break;
                                case 525:
                                    baltimore.part525 = quantity2 - quantity;
                                    Console.WriteLine("baltimore warehouse sold " + quantity + " of part " + part);
                                    break;
                                case 711:
                                    baltimore.part711 = quantity2 - quantity;
                                    Console.WriteLine("baltimore warehouse sold " + quantity + " of part " + part);
                                    break;
                            }
                            break;
                        case 2:
                            switch (part)
                            {
                                case 102:
                                    chicago.part102 = quantity2 - quantity;
                                    Console.WriteLine("chicago warehouse sold " + quantity + " of part " + part);
                                    break;
                                case 215:
                                    chicago.part215 = quantity2 - quantity;
                                    Console.WriteLine("chicago warehouse sold " + quantity + " of part " + part);
                                    break;
                                case 410:
                                    chicago.part410 = quantity2 - quantity;
                                    Console.WriteLine("chicago warehouse sold " + quantity + " of part " + part);
                                    break;
                                case 525:
                                    chicago.part525 = quantity2 - quantity;
                                    Console.WriteLine("chicago warehouse sold " + quantity + " of part " + part);
                                    break;
                                case 711:
                                    chicago.part711 = quantity2 - quantity;
                                    Console.WriteLine("chicago warehouse sold " + quantity + " of part " + part);
                                    break;
                            }
                            break;
                        case 3:
                            switch (part)
                            {
                                case 102:
                                    denver.part102 = quantity2 - quantity;
                                    Console.WriteLine("denver warehouse sold " + quantity + " of part " + part);
                                    break;
                                case 215:
                                    denver.part215 = quantity2 - quantity;
                                    Console.WriteLine("denver warehouse sold " + quantity + " of part " + part);
                                    break;
                                case 410:
                                    denver.part410 = quantity2 - quantity;
                                    Console.WriteLine("denver warehouse sold " + quantity + " of part " + part);
                                    break;
                                case 525:
                                    denver.part525 = quantity2 - quantity;
                                    Console.WriteLine("denver warehouse sold " + quantity + " of part " + part);
                                    break;
                                case 711:
                                    denver.part711 = quantity2 - quantity;
                                    Console.WriteLine("denver warehouse sold " + quantity + " of part " + part);
                                    break;
                            }
                            break;
                        case 4:
                            switch (part)
                            {
                                case 102:
                                    ely.part102 = quantity2 - quantity;
                                    Console.WriteLine("ely warehouse sold " + quantity + " of part " + part);
                                    break;
                                case 215:
                                    ely.part215 = quantity2 - quantity;
                                    Console.WriteLine("ely warehouse sold " + quantity + " of part " + part);
                                    break;
                                case 410:
                                    ely.part410 = quantity2 - quantity;
                                    Console.WriteLine("ely warehouse sold " + quantity + " of part " + part);
                                    break;
                                case 525:
                                    ely.part525 = quantity2 - quantity;
                                    Console.WriteLine("ely warehouse sold " + quantity + " of part " + part);
                                    break;
                                case 711:
                                    ely.part711 = quantity2 - quantity;
                                    Console.WriteLine("ely warehouse sold " + quantity + " of part " + part);
                                    break;
                            }
                            break;
                        case 5:
                            switch (part)
                            {
                                case 102:
                                    fargo.part102 = quantity2 - quantity;
                                    Console.WriteLine("fargo warehouse sold " + quantity + " of part " + part);
                                    break;
                                case 215:
                                    fargo.part215 = quantity2 - quantity;
                                    Console.WriteLine("fargo warehouse sold " + quantity + " of part " + part);
                                    break;
                                case 410:
                                    fargo.part410 = quantity2 - quantity;
                                    Console.WriteLine("fargo warehouse sold " + quantity + " of part " + part);
                                    break;
                                case 525:
                                    fargo.part525 = quantity2 - quantity;
                                    Console.WriteLine("fargo warehouse sold " + quantity + " of part " + part);
                                    break;
                                case 711:
                                    fargo.part711 = quantity2 - quantity;
                                    Console.WriteLine("fargo warehouse sold " + quantity + " of part " + part);
                                    break;
                            }
                            break;

                    }
                }
                else //else statement confirms that this will be a purchase rather than sell
                {
                    answer = atlanta.compareTo(baltimore, chicago, denver, ely, fargo, part, "P"); //answer is set to the returned value from the compareto method
                    quantity2 = answer[0]; //quantity initialized by the answer array
                    wh = answer[1]; //warehouse initialized by the answer array
                    switch (wh) //switch statement based on what warehouse number is called on by the returned answer
                    {
                        //case 0 = atlanta - case 5 = fargo
                        case 0:
                            switch (part) //switch statement that will call on the appropriate part number
                            {
                                case 102:
                                    atlanta.part102 = quantity2 + quantity; //adds the appropriate quantity to the part number in the warehouse
                                    Console.WriteLine("Atlanta warehouse purchased " + quantity + " of part " + part); //writes on console to confirm transaction
                                    break;
                                case 215:
                                    atlanta.part215 = quantity2 + quantity;
                                    Console.WriteLine("Atlanta warehouse purchased " + quantity + " of part " + part);
                                    break;
                                case 410:
                                    atlanta.part410 = quantity2 + quantity;
                                    Console.WriteLine("Atlanta warehouse purchased " + quantity + " of part " + part);
                                    break;
                                case 525:
                                    atlanta.part525 = quantity2 + quantity;
                                    Console.WriteLine("Atlanta warehouse purchased " + quantity + " of part " + part);
                                    break;
                                case 711:
                                    atlanta.part711 = quantity2 + quantity;
                                    Console.WriteLine("Atlanta warehouse purchased " + quantity + " of part " + part);
                                    break;
                            }
                            break;
                        case 1:
                            switch (part)
                            {
                                case 102:
                                    baltimore.part102 = quantity2 + quantity;
                                    Console.WriteLine("baltimore warehouse purchased " + quantity + " of part " + part);
                                    break;
                                case 215:
                                    baltimore.part215 = quantity2 + quantity;
                                    Console.WriteLine("baltimore warehouse purchased " + quantity + " of part " + part);
                                    break;
                                case 410:
                                    baltimore.part410 = quantity2 + quantity;
                                    Console.WriteLine("baltimore warehouse purchased " + quantity + " of part " + part);
                                    break;
                                case 525:
                                    baltimore.part525 = quantity2 + quantity;
                                    Console.WriteLine("baltimore warehouse purchased " + quantity + " of part " + part);
                                    break;
                                case 711:
                                    baltimore.part711 = quantity2 + quantity;
                                    Console.WriteLine("baltimore warehouse purchased " + quantity + " of part " + part);
                                    break;
                            }
                            break;
                        case 2:
                            switch (part)
                            {
                                case 102:
                                    chicago.part102 = quantity2 + quantity;
                                    Console.WriteLine("chicago warehouse purchased " + quantity + " of part " + part);
                                    break;
                                case 215:
                                    chicago.part215 = quantity2 + quantity;
                                    Console.WriteLine("chicago warehouse purchased " + quantity + " of part " + part);
                                    break;
                                case 410:
                                    chicago.part410 = quantity2 + quantity;
                                    Console.WriteLine("chicago warehouse purchased " + quantity + " of part " + part);
                                    break;
                                case 525:
                                    chicago.part525 = quantity2 + quantity;
                                    Console.WriteLine("chicago warehouse purchased " + quantity + " of part " + part);
                                    break;
                                case 711:
                                    chicago.part711 = quantity2 + quantity;
                                    Console.WriteLine("chicago warehouse purchased " + quantity + " of part " + part);
                                    break;
                            }
                            break;
                        case 3:
                            switch (part)
                            {
                                case 102:
                                    denver.part102 = quantity2 + quantity;
                                    Console.WriteLine("denver warehouse purchased " + quantity + " of part " + part);
                                    break;
                                case 215:
                                    denver.part215 = quantity2 + quantity;
                                    Console.WriteLine("denver warehouse purchased " + quantity + " of part " + part);
                                    break;
                                case 410:
                                    denver.part410 = quantity2 + quantity;
                                    Console.WriteLine("denver warehouse purchased " + quantity + " of part " + part);
                                    break;
                                case 525:
                                    denver.part525 = quantity2 + quantity;
                                    Console.WriteLine("denver warehouse purchased " + quantity + " of part " + part);
                                    break;
                                case 711:
                                    denver.part711 = quantity2 + quantity;
                                    Console.WriteLine("denver warehouse purchased " + quantity + " of part " + part);
                                    break;
                            }
                            break;
                        case 4:
                            switch (part)
                            {
                                case 102:
                                    ely.part102 = quantity2 + quantity;
                                    Console.WriteLine("ely warehouse purchased " + quantity + " of part " + part);
                                    break;
                                case 215:
                                    ely.part215 = quantity2 + quantity;
                                    Console.WriteLine("ely warehouse purchased " + quantity + " of part " + part);
                                    break;
                                case 410:
                                    ely.part410 = quantity2 + quantity;
                                    Console.WriteLine("ely warehouse purchased " + quantity + " of part " + part);
                                    break;
                                case 525:
                                    ely.part525 = quantity2 + quantity;
                                    Console.WriteLine("ely warehouse purchased " + quantity + " of part " + part);
                                    break;
                                case 711:
                                    ely.part711 = quantity2 + quantity;
                                    Console.WriteLine("ely warehouse purchased " + quantity + " of part " + part);
                                    break;
                            }
                            break;
                        case 5:
                            switch (part)
                            {
                                case 102:
                                    fargo.part102 = quantity2 + quantity;
                                    Console.WriteLine("fargo warehouse purchased " + quantity + " of part " + part);
                                    break;
                                case 215:
                                    fargo.part215 = quantity2 + quantity;
                                    Console.WriteLine("fargo warehouse purchased " + quantity + " of part " + part);
                                    break;
                                case 410:
                                    fargo.part410 = quantity2 + quantity;
                                    Console.WriteLine("fargo warehouse purchased " + quantity + " of part " + part);
                                    break;
                                case 525:
                                    fargo.part525 = quantity2 + quantity;
                                    Console.WriteLine("fargo warehouse purchased " + quantity + " of part " + part);
                                    break;
                                case 711:
                                    fargo.part711 = quantity2 + quantity;
                                    Console.WriteLine("fargo warehouse purchased " + quantity + " of part " + part);
                                    break;
                            }
                            break;

                    }

                }
                Console.WriteLine("");
                transaction++; //incremental transaction to keep track of how many transactions have been processed
            }
            Console.WriteLine(" --------------------------");
            Console.WriteLine("|    End of Transactions   |");
            Console.WriteLine(" --------------------------\n");

            Console.WriteLine(" --------------------------");
            Console.WriteLine("|   End of Day Inventory   |");
            Console.WriteLine(" --------------------------\n");

            //write on console the inventory of each warehouse object after forloop has finished
            inv.writeInventory(atlanta, 0);
            inv.writeInventory(baltimore, 1);
            inv.writeInventory(chicago, 2);
            inv.writeInventory(denver, 3);
            inv.writeInventory(ely, 4);
            inv.writeInventory(fargo, 5);
        }
    }
}
