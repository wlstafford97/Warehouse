using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace Warehouses
{
    class Inventory
    {
        String[] warehouse = { "Atlanta", "Baltimore", "Chicago", "Denver", "Ely", "Fargo" };

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
        

        public Inventory()
        {
        }
        public Inventory(int warehouse)
        {
            int i = 0;
            int parse;
            int[] var2 = new int[5];
            foreach (string line in System.IO.File.ReadAllLines(@"C:\Users\Lucas\Desktop\C#\Assignment2\Warehouses\Inventory.txt"))
            {
                String[] var = line.Split(',');
                if (i == warehouse)
                {
                    for (int y = 0; y < var.Length; y++)
                    {
                        parse = int.Parse(var[y]);
                        var2[y] = parse;
                    }
                }
                part102 = var2[0];
                part215 = var2[1];
                part410 = var2[2];
                part525 = var2[3];
                part711 = var2[4];
                i++;
            }
        }

        public int[] compareTo(Inventory inv1, Inventory inv2, Inventory inv3, Inventory inv4, Inventory inv5, int part, string action)
        {
            int[] partArray = new int[6];
            int[] answer = new int[2];

            switch (part)
            {
                case 102:
                    if (action.Equals("S"))
                    {
                        partArray[0] = this.part102;
                        partArray[1] = inv1.part102;
                        partArray[2] = inv2.part102;
                        partArray[3] = inv3.part102;
                        partArray[4] = inv4.part102;
                        partArray[5] = inv5.part102;

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
                    } else
                    {
                        partArray[0] = this.part102;
                        partArray[1] = inv1.part102;
                        partArray[2] = inv2.part102;
                        partArray[3] = inv3.part102;
                        partArray[4] = inv4.part102;
                        partArray[5] = inv5.part102;

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
                case 215:
                    partArray[0] = this.part215;
                    partArray[1] = inv1.part215;
                    partArray[2] = inv2.part215;
                    partArray[3] = inv3.part215;
                    partArray[4] = inv4.part215;
                    partArray[5] = inv5.part215;

                    int maxValue2 = 0;
                    int wh2 = 0;

                    for (int i = 0; i < partArray.Length; i++)
                    {
                        if (partArray[i] > maxValue2)
                        {
                            maxValue2 = partArray[i];
                            wh2 = i;
                        }
                    }
                    answer[0] = maxValue2;
                    answer[1] = wh2;
                    return answer;
                case 525:
                    partArray[0] = this.part525;
                    partArray[1] = inv1.part525;
                    partArray[2] = inv2.part525;
                    partArray[3] = inv3.part525;
                    partArray[4] = inv4.part525;
                    partArray[5] = inv5.part525;

                    int maxValue4 = 0;
                    int wh4 = 0;

                    for (int i = 0; i < partArray.Length; i++)
                    {
                        if (partArray[i] > maxValue4)
                        {
                            maxValue4 = partArray[i];
                            wh4 = i;
                        }
                    }
                    answer[0] = maxValue4;
                    answer[1] = wh4;
                    return answer;
                case 410:
                    partArray[0] = this.part410;
                    partArray[1] = inv1.part410;
                    partArray[2] = inv2.part410;
                    partArray[3] = inv3.part410;
                    partArray[4] = inv4.part410;
                    partArray[5] = inv5.part410;

                    int maxValue3 = 0;
                    int wh3 = 0;

                    for (int i = 0; i < partArray.Length; i++)
                    {
                        if (partArray[i] > maxValue3)
                        {
                            maxValue3 = partArray[i];
                            wh3 = i;
                        }
                    }
                    answer[0] = maxValue3;
                    answer[1] = wh3;
                    return answer;
                case 711:
                    partArray[0] = this.part711;
                    partArray[1] = inv1.part711;
                    partArray[2] = inv2.part711;
                    partArray[3] = inv3.part711;
                    partArray[4] = inv4.part711;
                    partArray[5] = inv5.part711;

                    int maxValue5 = 0;
                    int wh5 = 0;

                    for (int i = 0; i < partArray.Length; i++)
                    {
                        if (partArray[i] > maxValue5)
                        {
                            maxValue5 = partArray[i];
                            wh5 = i;
                        }
                    }
                    answer[0] = maxValue5;
                    answer[1] = wh5;
                    return answer;
            }
            return answer;
        }

        public string[] readTransFile()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Lucas\Desktop\C#\Assignment2\Warehouses\Transactions.txt");
            return lines;
           //* throw new System.InvalidOperationException("Something went wrong here.");*/
        }

        public void writeInventory(Inventory var, int x)
        {
            Console.WriteLine(warehouse[x] + ":\n" + "---------------\n" + "Part | Quantity\n" + "102  | " + var.part102 
                    + "\n215  | " + var.part215 + "\n410  | " + var.part410 + "\n525  | " + var.part525 + "\n711  | " + var.part711 + "\n");   
        }

        public void writeInventory()
        {
            int x = 0;
            int parse;
            int[] var2 = new int[5];
            foreach (string line in System.IO.File.ReadAllLines(@"C:\Users\Lucas\Desktop\C#\Assignment2\Warehouses\Inventory.txt"))
            {
                string[] var = line.Split(',');
                for (int y = 0; y < var.Length; y++)
                {
                    parse = int.Parse(var[y]);
                    var2[y] = parse;
                }

                Console.WriteLine(warehouse[x] + ":\n" + "---------------\n" + "Part | Quantity\n" + "102  | " + var2[0]
                    + "\n215  | " + var2[1] + "\n410  | " + var2[2] + "\n525  | " + var2[3] + "\n711  | " + var2[4] + "\n");
                x++;
            }
        }

    }


}
