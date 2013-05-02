Restaurant100
=============

AIO management tool for small restaurants (includes a POS [Point Of Sales] system.)
This is being made for my senior project, teamed with 2 other people as well. Most work here is done by me (mikedloss) though.

Also please note this readme is ugly and I don't know how to format it correctly.
Installation
============
  Required materials:
  
    1) .NET Framework 4
    2) MySQL Workbench (you can grab this through the GUI installer for Windows)
    3) MySQL Connector/NET (you can grab this through the GUI installer for Windows)
    4) Visual Studio Powerpack version 10.0.0.0 (not required if you have Visual Studio)
    
    -NOTE: You should just do a full install of the MySQL GUI installer for Windows
    
The .NET Framework is to allow the MySQL software to run correctly.
Once the Workbench and connector is set up, a schema will need to be setup manually.

    SCHEMA: restaurantinfo
    TABLES: employeeinfo, schedule, tablewaitlist, whoiswho
    COLUMNS FOR employeeinfo: un, pw, type, firstname, lastname, displayname
    COLUMNS FOR schedule:
    COLUMNS FOR tablewaitlist: name, size
    COLUMNS FOR whoiswho: type, name
    
    ^^^THIS IS NOT A COMPLETE LIST OF TABLES/COLUMNS AS OF 3/11/2013. 

Functionality for creating the schema and everything that it involves _MIGHT_ be added at a future date IF THERE IS TIME TO COMPLETE IT.

NOT COMPLETED
