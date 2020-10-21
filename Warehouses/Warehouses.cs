using System;
using System.Collections.Generic;

namespace Warehouses
{
    class Warehouses
    {

        static void Main(string[] args)
        {
            Inventory inv = new Inventory();
            Inventory atlanta = new Inventory(0);
            Inventory baltimore = new Inventory(1);
            Inventory chicago = new Inventory(2);
            Inventory denver = new Inventory(3);
            Inventory ely = new Inventory(4);
            Inventory fargo = new Inventory(5);

            string action = null;
            int part = 0;
            int quantity = 0;
            int quantity2 = 0;
            int[] answer = new int[2];
            int wh = 0;
            int transaction = 1;
            string[] test = inv.readTransFile();

            Console.WriteLine(" --------------------------");
            Console.WriteLine("|Beginning of Day Inventory|");
            Console.WriteLine(" --------------------------\n");
            inv.writeInventory();

            Console.WriteLine(" --------------------------");
            Console.WriteLine("| Transactions for the Day |");
            Console.WriteLine(" --------------------------\n");

            for (int i = 0; i < test.Length; i++)
            {
                string[] var = test[i].Split(',');
                action = var[0];
                part = int.Parse(var[1]);
                quantity = int.Parse(var[2]);
                Console.WriteLine("Transaction: " + transaction);

                if (action.Equals("S"))
                {
                    answer = atlanta.compareTo(baltimore, chicago, denver, ely, fargo, part, "S");
                    quantity2 = answer[0];
                    wh = answer[1];
                    switch (wh)
                    {
                        case 0:
                            switch (part)
                            {
                                case 102:
                                    atlanta.part102 = quantity2 - quantity;
                                    Console.WriteLine("Atlanta warehouse sold " + atlanta.part102 + " of part " + part);
                                    break;
                                case 215:
                                    atlanta.part215 = quantity2 - quantity;
                                    Console.WriteLine("Atlanta warehouse sold " + atlanta.part215 + " of part " + part);
                                    break;
                                case 410:
                                    atlanta.part410 = quantity2 - quantity;
                                    Console.WriteLine("Atlanta warehouse sold " + atlanta.part410 + " of part " + part);
                                    break;
                                case 525:
                                    atlanta.part525 = quantity2 - quantity;
                                    Console.WriteLine("Atlanta warehouse sold " + atlanta.part525 + " of part " + part);
                                    break;
                                case 711:
                                    atlanta.part711 = quantity2 - quantity;
                                    Console.WriteLine("Atlanta warehouse sold " + atlanta.part711 + " of part " + part);
                                    break;
                            }
                            break;
                        case 1:
                            switch (part)
                            {
                                case 102:
                                    baltimore.part102 = quantity2 - quantity;
                                    Console.WriteLine("baltimore warehouse sold " + baltimore.part102 + " of part " + part);
                                    break;
                                case 215:
                                    baltimore.part215 = quantity2 - quantity;
                                    Console.WriteLine("baltimore warehouse sold " + baltimore.part215 + " of part " + part);
                                    break;
                                case 410:
                                    baltimore.part410 = quantity2 - quantity;
                                    Console.WriteLine("baltimore warehouse sold " + baltimore.part410 + " of part " + part);
                                    break;
                                case 525:
                                    baltimore.part525 = quantity2 - quantity;
                                    Console.WriteLine("baltimore warehouse sold " + baltimore.part525 + " of part " + part);
                                    break;
                                case 711:
                                    baltimore.part711 = quantity2 - quantity;
                                    Console.WriteLine("baltimore warehouse sold " + baltimore.part711 + " of part " + part);
                                    break;
                            }
                            break;
                        case 2:
                            switch (part)
                            {
                                case 102:
                                    chicago.part102 = quantity2 - quantity;
                                    Console.WriteLine("chicago warehouse sold " + chicago.part102 + " of part " + part);
                                    break;
                                case 215:
                                    chicago.part215 = quantity2 - quantity;
                                    Console.WriteLine("chicago warehouse sold " + chicago.part215 + " of part " + part);
                                    break;
                                case 410:
                                    chicago.part410 = quantity2 - quantity;
                                    Console.WriteLine("chicago warehouse sold " + chicago.part410 + " of part " + part);
                                    break;
                                case 525:
                                    chicago.part525 = quantity2 - quantity;
                                    Console.WriteLine("chicago warehouse sold " + chicago.part525 + " of part " + part);
                                    break;
                                case 711:
                                    chicago.part711 = quantity2 - quantity;
                                    Console.WriteLine("chicago warehouse sold " + chicago.part711 + " of part " + part);
                                    break;
                            }
                            break;
                        case 3:
                            switch (part)
                            {
                                case 102:
                                    denver.part102 = quantity2 - quantity;
                                    Console.WriteLine("denver warehouse sold " + denver.part102 + " of part " + part);
                                    break;
                                case 215:
                                    denver.part215 = quantity2 - quantity;
                                    Console.WriteLine("denver warehouse sold " + denver.part215 + " of part " + part);
                                    break;
                                case 410:
                                    denver.part410 = quantity2 - quantity;
                                    Console.WriteLine("denver warehouse sold " + denver.part410 + " of part " + part);
                                    break;
                                case 525:
                                    denver.part525 = quantity2 - quantity;
                                    Console.WriteLine("denver warehouse sold " + denver.part525 + " of part " + part);
                                    break;
                                case 711:
                                    denver.part711 = quantity2 - quantity;
                                    Console.WriteLine("denver warehouse sold " + denver.part711 + " of part " + part);
                                    break;
                            }
                            break;
                        case 4:
                            switch (part)
                            {
                                case 102:
                                    ely.part102 = quantity2 - quantity;
                                    Console.WriteLine("ely warehouse sold " + ely.part102 + " of part " + part);
                                    break;
                                case 215:
                                    ely.part215 = quantity2 - quantity;
                                    Console.WriteLine("ely warehouse sold " + ely.part215 + " of part " + part);
                                    break;
                                case 410:
                                    ely.part410 = quantity2 - quantity;
                                    Console.WriteLine("ely warehouse sold " + ely.part410 + " of part " + part);
                                    break;
                                case 525:
                                    ely.part525 = quantity2 - quantity;
                                    Console.WriteLine("ely warehouse sold " + ely.part525 + " of part " + part);
                                    break;
                                case 711:
                                    ely.part711 = quantity2 - quantity;
                                    Console.WriteLine("ely warehouse sold " + ely.part711 + " of part " + part);
                                    break;
                            }
                            break;
                        case 5:
                            switch (part)
                            {
                                case 102:
                                    fargo.part102 = quantity2 - quantity;
                                    Console.WriteLine("fargo warehouse sold " + fargo.part102 + " of part " + part);
                                    break;
                                case 215:
                                    fargo.part215 = quantity2 - quantity;
                                    Console.WriteLine("fargo warehouse sold " + fargo.part215 + " of part " + part);
                                    break;
                                case 410:
                                    fargo.part410 = quantity2 - quantity;
                                    Console.WriteLine("fargo warehouse sold " + fargo.part410 + " of part " + part);
                                    break;
                                case 525:
                                    fargo.part525 = quantity2 - quantity;
                                    Console.WriteLine("fargo warehouse sold " + fargo.part525 + " of part " + part);
                                    break;
                                case 711:
                                    fargo.part711 = quantity2 - quantity;
                                    Console.WriteLine("fargo warehouse sold " + fargo.part711 + " of part " + part);
                                    break;
                            }
                            break;

                    }
                }
                else
                {
                    answer = atlanta.compareTo(baltimore, chicago, denver, ely, fargo, part, "P");
                    quantity2 = answer[0];
                    wh = answer[1];
                    switch (wh)
                    {
                        case 0:
                            switch (part)
                            {
                                case 102:
                                    atlanta.part102 = quantity2 + quantity;
                                    Console.WriteLine("Atlanta warehouse purchased " + atlanta.part102 + " of part " + part);
                                    break;
                                case 215:
                                    atlanta.part215 = quantity2 + quantity;
                                    Console.WriteLine("Atlanta warehouse purchased " + atlanta.part215 + " of part " + part);
                                    break;
                                case 410:
                                    atlanta.part410 = quantity2 + quantity;
                                    Console.WriteLine("Atlanta warehouse purchased " + atlanta.part410 + " of part " + part);
                                    break;
                                case 525:
                                    atlanta.part525 = quantity2 + quantity;
                                    Console.WriteLine("Atlanta warehouse purchased " + atlanta.part525 + " of part " + part);
                                    break;
                                case 711:
                                    atlanta.part711 = quantity2 + quantity;
                                    Console.WriteLine("Atlanta warehouse purchased " + atlanta.part711 + " of part " + part);
                                    break;
                            }
                            break;
                        case 1:
                            switch (part)
                            {
                                case 102:
                                    baltimore.part102 = quantity2 + quantity;
                                    Console.WriteLine("baltimore warehouse purchased " + baltimore.part102 + " of part " + part);
                                    break;
                                case 215:
                                    baltimore.part215 = quantity2 + quantity;
                                    Console.WriteLine("baltimore warehouse purchased " + baltimore.part215 + " of part " + part);
                                    break;
                                case 410:
                                    baltimore.part410 = quantity2 + quantity;
                                    Console.WriteLine("baltimore warehouse purchased " + baltimore.part410 + " of part " + part);
                                    break;
                                case 525:
                                    baltimore.part525 = quantity2 + quantity;
                                    Console.WriteLine("baltimore warehouse purchased " + baltimore.part525 + " of part " + part);
                                    break;
                                case 711:
                                    baltimore.part711 = quantity2 + quantity;
                                    Console.WriteLine("baltimore warehouse purchased " + baltimore.part711 + " of part " + part);
                                    break;
                            }
                            break;
                        case 2:
                            switch (part)
                            {
                                case 102:
                                    chicago.part102 = quantity2 + quantity;
                                    Console.WriteLine("chicago warehouse purchased " + chicago.part102 + " of part " + part);
                                    break;
                                case 215:
                                    chicago.part215 = quantity2 + quantity;
                                    Console.WriteLine("chicago warehouse purchased " + chicago.part215 + " of part " + part);
                                    break;
                                case 410:
                                    chicago.part410 = quantity2 + quantity;
                                    Console.WriteLine("chicago warehouse purchased " + chicago.part410 + " of part " + part);
                                    break;
                                case 525:
                                    chicago.part525 = quantity2 + quantity;
                                    Console.WriteLine("chicago warehouse purchased " + chicago.part525 + " of part " + part);
                                    break;
                                case 711:
                                    chicago.part711 = quantity2 + quantity;
                                    Console.WriteLine("chicago warehouse purchased " + chicago.part711 + " of part " + part);
                                    break;
                            }
                            break;
                        case 3:
                            switch (part)
                            {
                                case 102:
                                    denver.part102 = quantity2 + quantity;
                                    Console.WriteLine("denver warehouse purchased " + denver.part102 + " of part " + part);
                                    break;
                                case 215:
                                    denver.part215 = quantity2 + quantity;
                                    Console.WriteLine("denver warehouse purchased " + denver.part215 + " of part " + part);
                                    break;
                                case 410:
                                    denver.part410 = quantity2 + quantity;
                                    Console.WriteLine("denver warehouse purchased " + denver.part410 + " of part " + part);
                                    break;
                                case 525:
                                    denver.part525 = quantity2 + quantity;
                                    Console.WriteLine("denver warehouse purchased " + denver.part525 + " of part " + part);
                                    break;
                                case 711:
                                    denver.part711 = quantity2 + quantity;
                                    Console.WriteLine("denver warehouse purchased " + denver.part711 + " of part " + part);
                                    break;
                            }
                            break;
                        case 4:
                            switch (part)
                            {
                                case 102:
                                    ely.part102 = quantity2 + quantity;
                                    Console.WriteLine("ely warehouse purchased " + ely.part102 + " of part " + part);
                                    break;
                                case 215:
                                    ely.part215 = quantity2 + quantity;
                                    Console.WriteLine("ely warehouse purchased " + ely.part215 + " of part " + part);
                                    break;
                                case 410:
                                    ely.part410 = quantity2 + quantity;
                                    Console.WriteLine("ely warehouse purchased " + ely.part410 + " of part " + part);
                                    break;
                                case 525:
                                    ely.part525 = quantity2 + quantity;
                                    Console.WriteLine("ely warehouse purchased " + ely.part525 + " of part " + part);
                                    break;
                                case 711:
                                    ely.part711 = quantity2 + quantity;
                                    Console.WriteLine("ely warehouse purchased " + ely.part711 + " of part " + part);
                                    break;
                            }
                            break;
                        case 5:
                            switch (part)
                            {
                                case 102:
                                    fargo.part102 = quantity2 + quantity;
                                    Console.WriteLine("fargo warehouse purchased " + fargo.part102 + " of part " + part);
                                    break;
                                case 215:
                                    fargo.part215 = quantity2 + quantity;
                                    Console.WriteLine("fargo warehouse purchased " + fargo.part215 + " of part " + part);
                                    break;
                                case 410:
                                    fargo.part410 = quantity2 + quantity;
                                    Console.WriteLine("fargo warehouse purchased " + fargo.part410 + " of part " + part);
                                    break;
                                case 525:
                                    fargo.part525 = quantity2 + quantity;
                                    Console.WriteLine("fargo warehouse purchased " + fargo.part525 + " of part " + part);
                                    break;
                                case 711:
                                    fargo.part711 = quantity2 + quantity;
                                    Console.WriteLine("fargo warehouse purchased " + fargo.part711 + " of part " + part);
                                    break;
                            }
                            break;

                    }

                }
                Console.WriteLine("");
                transaction++;
            }
            Console.WriteLine(" --------------------------");
            Console.WriteLine("|    End of Transactions   |");
            Console.WriteLine(" --------------------------\n");

            inv.writeInventory(atlanta, 0);
            inv.writeInventory(baltimore, 1);
            inv.writeInventory(chicago, 2);
            inv.writeInventory(denver, 3);
            inv.writeInventory(ely, 4);
            inv.writeInventory(fargo, 5);
        }
    }
}
