using System;

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
        public void GetData()
        {
            int counter = 0;
            string line;

            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"C:\Users\HP\Dropbox\Academic_Desk\2020.01.WINTER\CSharpDataStructures1\CICS\AJAX.csv");
            while ((line = file.ReadLine()) != null)
            {
                ConvertLineIntoObject(line);
                counter++;
            }

            file.Close();
            System.Console.WriteLine("There were {0} lines.", counter);
            // Suspend the screen.  
            System.Console.ReadLine();

        }

        public void ConvertLineIntoObject(String inputLine)
        {
            DataRecord dr = new DataRecord();
            // take inputLine
            // use substrings to breaks it apart around the commas
            dr.FULLADDRESS = "";

            // sample code to walk over a string

            string str;
            int l = 0;

            Console.Write("\n\nprint individual characters of string in reverse order :\n");
            Console.Write("------------------------------------------------------\n");
            Console.Write("Input the string : ");
            str = "MY name is Peanut I am a Bichon";

            l = str.Length - 1;
            Console.Write("The characters of the string in reverse are : \n");
            while (l >= 0)
            {
                Console.Write("{0} ", str[l]);
                l--;
            }
            Console.Write("\n\n");

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
