using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

//Developer: William Lucas Stafford
//10/21/20
namespace Warehouses
{
    class Inventory
    {
        //string array holding the names of the warehouses
        String[] warehouse = { "Atlanta", "Baltimore", "Chicago", "Denver", "Ely", "Fargo" };

        //following methods are used to set and get the parts for each warehouse object
        public int part102
        {
            get;
            set;
        }
        public int part215
        {
            get;
            set;
        }
        public int part410
        {
            get;
            set;
        }
        public int part525
        {
            get;
            set;
        }
        public int part711
        {
            get;
            set;
        }
        

        //default constructor
        public Inventory()
        {
        }
        
        //inventory constructor used to get the information of each warehouse
        public Inventory(int warehouse) //int parameter to access the correct warehouse 0 being atlanta - 5 being fargo
        {
            int i = 0;
            int parse; //integer to hold the parsed string
            int[] var2 = new int[5]; //integer array to hold all parsed strings
            //foreach loop that will read all the lines in the Inventory.txt file
            foreach (string line in System.IO.File.ReadAllLines(@"C:\Users\Lucas\Desktop\C#\Assignment2\Warehouses\Inventory.txt"))
            {
                String[] var = line.Split(','); //.split will split the string line that is seperated by commas inorder to read the correct information
                if (i == warehouse) //if statement to loop through the correct warehouse
                {
                    for (int y = 0; y < var.Length; y++)
                    {
                        parse = int.Parse(var[y]);//parsing the string into a int
                        var2[y] = parse;
                    }
                }
                //assigning each part to the correct number
                part102 = var2[0];
                part215 = var2[1];
                part410 = var2[2];
                part525 = var2[3];
                part711 = var2[4];
                i++;
            }
        }

        //method used to compare each warehouse to see which to sell/buy from
        //int parameter for the part
        //string parameter to dictate whether it is a purchase or sell
        //all warehouses are sent in the parameter
        public int[] compareTo(Inventory inv1, Inventory inv2, Inventory inv3, Inventory inv4, Inventory inv5, int part, string action)
        {
            int[] partArray = new int[6]; //new int array to update the parts
            int[] answer = new int[2]; //int array that will return the quantity and which warehouse to buy/sell from

            //switch statement that uses part numbers for each case
            switch (part)
            {
                case 102:
                    //if statement used to check whether its a buy or sell
                    if (action.Equals("S")) 
                    {
                        //stores all part quantities into the new partArray
                        partArray[0] = this.part102; 
                        partArray[1] = inv1.part102;
                        partArray[2] = inv2.part102;
                        partArray[3] = inv3.part102;
                        partArray[4] = inv4.part102;
                        partArray[5] = inv5.part102;

                        int maxValue = 0;
                        int wh = 0;

                        //for loop to see which warehouse has the highest quantity for the designated part
                        for (int i = 0; i < partArray.Length; i++)
                        {
                            if (partArray[i] > maxValue)
                            {
                                maxValue = partArray[i];
                                wh = i;
                            }
                        }
                        answer[0] = maxValue; //quantity of part is stored into answer array
                        answer[1] = wh; //warehouse of the quantity is stored into the answer array
                        return answer;
                    } else //same process as above but instead if it is a buy
                    {
                        partArray[0] = this.part102;
                        partArray[1] = inv1.part102;
                        partArray[2] = inv2.part102;
                        partArray[3] = inv3.part102;
                        partArray[4] = inv4.part102;
                        partArray[5] = inv5.part102;

                        int minValue = 10000;
                        int wh = 0;

                        //for loop to find the smallest quantity in the warehouses
                        for (int i = 0; i < partArray.Length; i++)
                        {
                            if (partArray[i] < minValue)
                            {
                                minValue = partArray[i];
                                wh = i;
                            }
                        }
                        answer[0] = minValue; //stores the smallest quantity into answer array
                        answer[1] = wh; //stores the warehouse that corresponds to the smallest quantity
                        return answer;
                    }
                    //the next cases have the same exact process as the one above, no need to comment again
                case 215:
                    if (action.Equals("S"))
                    {
                        partArray[0] = this.part215;
                        partArray[1] = inv1.part215;
                        partArray[2] = inv2.part215;
                        partArray[3] = inv3.part215;
                        partArray[4] = inv4.part215;
                        partArray[5] = inv5.part215;

                        int maxValue = 0;
                        int wh = 0;

                        for (int i = 0; i < partArray.Length; i++)
                        {
                            if (partArray[i] > maxValue)
                            {
                                maxValue = partArray[i];
                                wh = i;
                            }
                        }
                        answer[0] = maxValue;
                        answer[1] = wh;
                        return answer;
                    }
                    else
                    {
                        partArray[0] = this.part215;
                        partArray[1] = inv1.part215;
                        partArray[2] = inv2.part215;
                        partArray[3] = inv3.part215;
                        partArray[4] = inv4.part215;
                        partArray[5] = inv5.part215;

                        int minValue = 10000;
                        int wh = 0;

                        for (int i = 0; i < partArray.Length; i++)
                        {
                            if (partArray[i] < minValue)
                            {
                                minValue = partArray[i];
                                wh = i;
                            }
                        }
                        answer[0] = minValue;
                        answer[1] = wh;
                        return answer;
                    }
                case 525:
                    if (action.Equals("S"))
                    {
                        partArray[0] = this.part525;
                        partArray[1] = inv1.part525;
                        partArray[2] = inv2.part525;
                        partArray[3] = inv3.part525;
                        partArray[4] = inv4.part525;
                        partArray[5] = inv5.part525;

                        int maxValue = 0;
                        int wh = 0;

                        for (int i = 0; i < partArray.Length; i++)
                        {
                            if (partArray[i] > maxValue)
                            {
                                maxValue = partArray[i];
                                wh = i;
                            }
                        }
                        answer[0] = maxValue;
                        answer[1] = wh;
                        return answer;
                    }
                    else
                    {
                        partArray[0] = this.part525;
                        partArray[1] = inv1.part525;
                        partArray[2] = inv2.part525;
                        partArray[3] = inv3.part525;
                        partArray[4] = inv4.part525;
                        partArray[5] = inv5.part525;

                        int minValue = 10000;
                        int wh = 0;

                        for (int i = 0; i < partArray.Length; i++)
                        {
                            if (partArray[i] < minValue)
                            {
                                minValue = partArray[i];
                                wh = i;
                            }
                        }
                        answer[0] = minValue;
                        answer[1] = wh;
                        return answer;
                    }
                case 410:
                    if (action.Equals("S"))
                    {
                        partArray[0] = this.part410;
                        partArray[1] = inv1.part410;
                        partArray[2] = inv2.part410;
                        partArray[3] = inv3.part410;
                        partArray[4] = inv4.part410;
                        partArray[5] = inv5.part410;

                        int maxValue = 0;
                        int wh = 0;

                        for (int i = 0; i < partArray.Length; i++)
                        {
                            if (partArray[i] > maxValue)
                            {
                                maxValue = partArray[i];
                                wh = i;
                            }
                        }
                        answer[0] = maxValue;
                        answer[1] = wh;
                        return answer;
                    }
                    else
                    {
                        partArray[0] = this.part410;
                        partArray[1] = inv1.part410;
                        partArray[2] = inv2.part410;
                        partArray[3] = inv3.part410;
                        partArray[4] = inv4.part410;
                        partArray[5] = inv5.part410;

                        int minValue = 10000;
                        int wh = 0;

                        for (int i = 0; i < partArray.Length; i++)
                        {
                            if (partArray[i] < minValue)
                            {
                                minValue = partArray[i];
                                wh = i;
                            }
                        }
                        answer[0] = minValue;
                        answer[1] = wh;
                        return answer;
                    }
                case 711:
                    if (action.Equals("S"))
                    {
                        partArray[0] = this.part711;
                        partArray[1] = inv1.part711;
                        partArray[2] = inv2.part711;
                        partArray[3] = inv3.part711;
                        partArray[4] = inv4.part711;
                        partArray[5] = inv5.part711;

                        int maxValue = 0;
                        int wh = 0;

                        for (int i = 0; i < partArray.Length; i++)
                        {
                            if (partArray[i] > maxValue)
                            {
                                maxValue = partArray[i];
                                wh = i;
                            }
                        }
                        answer[0] = maxValue;
                        answer[1] = wh;
                        return answer;
                    }
                    else
                    {
                        partArray[0] = this.part711;
                        partArray[1] = inv1.part711;
                        partArray[2] = inv2.part711;
                        partArray[3] = inv3.part711;
                        partArray[4] = inv4.part711;
                        partArray[5] = inv5.part711;

                        int minValue = 10000;
                        int wh = 0;

                        for (int i = 0; i < partArray.Length; i++)
                        {
                            if (partArray[i] < minValue)
                            {
                                minValue = partArray[i];
                                wh = i;
                            }
                        }
                        answer[0] = minValue;
                        answer[1] = wh;
                        return answer;
                    }
            }
            return answer;
        }

        //string array method used to read the transaction file and return them
        public string[] readTransFile()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Lucas\Desktop\C#\Assignment2\Warehouses\Transactions.txt");
            return lines;
           //* throw new System.InvalidOperationException("Something went wrong here.");*/
        }

        //method that will console write the inventory of the designated warehouse
        public void writeInventory(Inventory var, int x)
        {
            //write the inventory on the console
            Console.WriteLine(warehouse[x] + ":\n" + "---------------\n" + "Part | Quantity\n" + "102  | " + var.part102 
                    + "\n215  | " + var.part215 + "\n410  | " + var.part410 + "\n525  | " + var.part525 + "\n711  | " + var.part711 + "\n");   
        }

        //method used to write the inventory at the start up of the program
        //these values are based completely off of the text file
        public void writeInventory()
        {
            int x = 0;
            int parse;
            int[] var2 = new int[5]; //int array to hold the parsed strings
            //foreach loop to read every line in the text file
            foreach (string line in System.IO.File.ReadAllLines(@"C:\Users\Lucas\Desktop\C#\Assignment2\Warehouses\Inventory.txt"))
            {
                //string array to hold the new strings that were split with the .split command
                string[] var = line.Split(',');
                for (int y = 0; y < var.Length; y++)
                {
                    parse = int.Parse(var[y]); //parse the strings into integers
                    var2[y] = parse;
                }

                //write the inventory on the console
                Console.WriteLine(warehouse[x] + ":\n" + "---------------\n" + "Part | Quantity\n" + "102  | " + var2[0]
                    + "\n215  | " + var2[1] + "\n410  | " + var2[2] + "\n525  | " + var2[3] + "\n711  | " + var2[4] + "\n");
                x++;
            }
        }

    }


}
