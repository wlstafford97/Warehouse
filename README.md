# Warehouse
ITCS-3112 Assignment2

Inventory Management System

Objective:
Work with multiple objects and reading data files.
Description: A wholesale distributor has six warehouses (Atlanta,
Baltimore, Chicago, Denver, Ely and Fargo) and sells five different items
(identified by part number: 102, 215, 410, 525 and 711). Each warehouse
may stock any or all of the five items. The company buys and sells these items constantly. Company
transaction records contain a transaction code (‘P’ for a purchase or ‘S’ for a sale) followed by an item number
and the quantity (bought or sold).
The transaction records are contained in a transaction data file named Transactions.txt.

Sample transaction records: Transactions.txt
P 410 1000
S 215 120
S 711 300
|
A separate data file contains the initial status of the six warehouses at the beginning of the day (i.e., the ending
status from the night before). This data file has only six records (lines). Each record (line) contains five
numbers that show the quantity on hand for the five items in that warehouse. This file is named Inventory.txt.

Sample status data file: Inventory.txt
500 120 60 0 350
100 230 0 50 0
0 75 0 0 220
600 50 120 300 40
210 160 30 80 50
90 50 90 200 70
|
The status data file is updated by processing the transaction records in the transaction data file according to
these rules:

 1 – For a sale (‘S’) – subtract the quantity sold from the warehouse that
has the largest supply of that item on hand.
 2 – For a purchase (‘P’) – add the quantity purchased to the warehouse
that has the lowest supply of that item on hand

Instructions:
Write an object-oriented C# application to do the above inventory warehouse processing. Each of the six
warehouses should be treated as an individual object. For example, Atlanta would be an object with each of
the five part numbers as instance fields. Each of the other warehouses should also be objects with the five part
numbers as instance fields. Of course, there would be one class which would be the main (driver) class from
which these 6 objects would be created.
In the beginning of the program, the status data file (Inventory.txt) should be read and an object for each
warehouse created. The Inventory.txt data file is in the following order: the first line is the Atlanta warehouse,
the second line is the Baltimore warehouse, third Chicago, then Denver, Ely and Fargo. After the objects are
created, the transactions data file (Transactions.txt) are read and processed.
The objects should be updated as the transaction records are read and processed.

The program should:
 1 – Display the initial (beginning-of-day) status for all warehouses.
 2 – Process each transaction from the transaction data file and show which
warehouse’s inventory was updated to reflect that transaction.
 3 – Display the final (end-of-day) status for all warehouses.
 
Requirements:
 The class must be named Inventory.
 The main program (driver) must be named Warehouses.
 A driver (main class) as well as a programmer-defined class must be used.
 Submit program through the assignment tool in Canvas.
 Include a comment stating your name.
 Each student must create his/her own independent program.
