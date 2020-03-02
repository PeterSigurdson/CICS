﻿using System;

namespace CICS
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Access the ajax.csv and print it out
            InputTheDatafile file1 = new InputTheDatafile();
            file1.GetData();
            // Step 2: implement the method ConvertLineIntoObject by doing string tokenization
        }
    }

    class InputTheDatafile
    {
        DataRecord[] CICS = new DataRecord[200];
        public void GetData()
        {
            int counter = 1;
            string line;

            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"C:\Users\HP\Dropbox\Academic_Desk\2020.01.WINTER\CSharpDataStructures1\CICS\AJAX.csv");
            while ((line = file.ReadLine()) != null)
            {
                ConvertLineIntoObject(line);
                counter++;
                Console.WriteLine("line number {0}", counter);
            }

            file.Close();
            System.Console.WriteLine("There were {0} lines.", counter);
            // Suspend the screen.  
            System.Console.ReadLine();

        }

        public void ConvertLineIntoObject(String inputLine)
        {
            String a = inputLine;
            DataRecord dr = new DataRecord();
            // take inputLine
            // use substrings to breaks it apart around the commas
            String addressLine = "";
            // Assignment #TODO
            // Extract out the substrings between all the commas and assign them to the appropriate data record fields(DRFs) of the DataRecord object.
            // Each time you construct a new DataRecord Object, insert it into the CICS Array.

            // code to walk over a string
            // remember, a string is just an array
            // find the Data Frames between the commas,

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == ',')
                { Console.WriteLine("Found a comma at position {0}", i+1); }
            }

            dr.FULLADDRESS = addressLine;
        }
    }

    class DataRecord
    {

        public String FULLADDRESS;

        public String Type;

        public String Description;

        public String Community;

        public int DaysOnMarket;

public double Percentage;

public double ListPrice;

public double SoldPrice;

public String ExpiryDate;

public String StreetName;

public String StNumber;

public String Bedroom;

public String BedPlus;

public String Washroom;

public String Garage;

public int ParkingDriveSpaces;

public string Pool;

public string ContractDate;

public string SoldDate;

public string RemarksForClients;

public string Extras;

public string Address;

public string PostalCode;

public string Municipality;

public string District;

    }
}
