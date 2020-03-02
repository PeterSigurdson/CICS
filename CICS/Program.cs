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
            Console.WriteLine(inputLine);
        }
    }

    class DataRecord
    {

        String FULLADDRESS;

        String Type;

String Description;

String Community;

        int DaysOnMarket;

double Percentage;

double ListPrice;

double SoldPrice;

String ExpiryDate;

String StreetName;

String StNumber;

String Bedroom;

String BedPlus;

String Washroom;

String Garage;

int ParkingDriveSpaces;

string Pool;

string ContractDate;

string SoldDate;

string RemarksForClients;

string Extras;

string Address;

string PostalCode;

string Municipality;

string District;

    }
}
