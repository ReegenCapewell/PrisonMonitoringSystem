using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrisonApplication
{
    class Program
    {
        public class Person
        {
            protected string firstName;
            protected string surname;
            protected string DOB;
            protected string gender;
            protected string medHistory;
            protected string homeNo;
            protected string mobileNo;
            protected string role;
            protected int recordCount = 0;

            public static string[,] Governors = new string[100, 100];
            public static string[,] Wardens = new string[100, 100];
            public static string[,] Prisoners = new string[100, 100];

            public void setFirstName()
            {
                Console.WriteLine("Please enter the first name of the person: ");
                Console.ForegroundColor = ConsoleColor.Green;
                firstName = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            public string getFirstName()
            {
                return firstName;
            }
            public void setSurname()
            {
                Console.WriteLine("Please enter the surname of the person: ");
                Console.ForegroundColor = ConsoleColor.Green;
                surname = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            public string geSurname()
            {
                return surname;
            }
            public void setDOB()
            {
                Console.WriteLine("Please enter the date of birth of the student (DD/MM/YYYY)");
                Console.ForegroundColor = ConsoleColor.Green;
                DOB = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            public string getDOB()
            {
                return DOB;
            }
            public void setGender()
            {
                Console.WriteLine("Is the person: Male, Female or Transgender?");
                Console.ForegroundColor = ConsoleColor.Green;
                gender = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            public string getGender()
            {
                return gender;
            }
            public void setMedHistory()
            {
                Console.WriteLine("Please enter any relevant medical history: ");
                Console.ForegroundColor = ConsoleColor.Green;
                medHistory = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            public string getMedHist()
            {
                return medHistory;
            }
            public void setRole()
            {
                Console.WriteLine("Staff or Inmate?");
                Console.ForegroundColor = ConsoleColor.Green;
                role = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            public string getRole()
            {
                return role;
            }
            public void setHomeNo()
            {
                Console.WriteLine("Please enter the home number of the person: ");
                Console.ForegroundColor = ConsoleColor.Green;
                homeNo = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            public void setMobNo()
            {
                Console.WriteLine("Please enter the mobile number of the person: ");
                Console.ForegroundColor = ConsoleColor.Green;
                mobileNo = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }

        public class Prisoner : Person
        {
            protected string prisonerID;
            string cellID;
            protected string conviction;
            protected string crimRec;
            string password = "Password";
            protected string curConviction;
            public static int listNumberP = 0;
            public int i = 0;
            string strPrisonerID;
            List<int> prisonerIDs = new List<int>();
            List<int> cells = new List<int>();
            List<string> convictions = new List<string>();
            List<string> crimRecList = new List<string>();


            public void setPrisonerID()
            {
                int prisonerID = i++;
                strPrisonerID = ("P" + prisonerID);
                Console.WriteLine("New Prisoner ID: P" + prisonerID);
                Console.WriteLine("P" + prisonerID);
            }
            public void setCellID()
            {
                foreach (int cellID in cells)
                {

                    Console.WriteLine("Assigned Cell: " + cellID);
                }
                Console.WriteLine("Your password is: " + password);
                Console.ReadLine();
                Console.Clear();
            }
            public void setConviction()
            {
                Console.WriteLine("Current Conviction: ");
                Console.ForegroundColor = ConsoleColor.Green;
                curConviction = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Clear();
            }
            public void setCrimRec()
            {
                Console.WriteLine("Criminal Record: ");
                Console.ForegroundColor = ConsoleColor.Green;
                crimRec = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Clear();             //NEED TO ADD THESE SPECIFIC DETAILS TO THE LIST
            }

            public void addPrisonDetails()
            {
                Prisoners[listNumberP, 0] = strPrisonerID;
                Prisoners[listNumberP, 1] = firstName;
                Prisoners[listNumberP, 2] = surname;
                Prisoners[listNumberP, 3] = DOB;
                Prisoners[listNumberP, 4] = gender;
                Prisoners[listNumberP, 5] = medHistory;
                Prisoners[listNumberP, 6] = role;
                Prisoners[listNumberP, 7] = homeNo;
                Prisoners[listNumberP, 8] = mobileNo;
                Prisoners[listNumberP, 9] = cellID;
                Prisoners[listNumberP, 10] = curConviction;
                Prisoners[listNumberP, 11] = crimRec;
                listNumberP++;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Prisoner succesfully added");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.ReadLine();
            }
        }

        public class Governor : Person
        {
            protected int govID;
            public int i = 0;
            protected string password;
            protected string crimRec;
            public int listNumber = 0;
            int b = 0;
            int y = 0;
            int z = 0;
            int x = 0;
            string strGovID;

            private string userChoice;
            string gMenuChoice;

            List<string> govDetails = new List<string>();
            List<int> governorIDs = new List<int>();
            public void setGovID()
            {
                int govID = i++;
                Console.WriteLine("New Governor ID: G" + govID);
                strGovID = ("G" + govID);

            }
            public int getGovID()
            {
                return govID;
            }
            public void setGovPassword()
            {

                password = "Password";
            }
            public void displayGovDetails()
            {
                foreach (int governID in governorIDs)
                {

                    Console.WriteLine("Governor ID: G" + governID);
                }
                Console.WriteLine("Your password is: " + password);
                Console.ReadLine();
                Console.Clear();
            }
            public void addGovDetails()
            {
                Governors[listNumber, 0] = strGovID;
                Governors[listNumber, 1] = firstName;
                Governors[listNumber, 2] = surname;
                Governors[listNumber, 3] = DOB;
                Governors[listNumber, 4] = gender;
                Governors[listNumber, 5] = medHistory;
                Governors[listNumber, 6] = role;
                Governors[listNumber, 7] = homeNo;
                Governors[listNumber, 8] = mobileNo;
                listNumber++;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Governor succesfully added");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            public void govViewPersonalRec()
            {
                int c = 0;
                int loopCount = 0;
                while (c == 0)
                {
                    if (recordCount < listNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Governor ID: " + Governors[recordCount, 0]);
                        Console.WriteLine("First Name: " + Governors[recordCount, 1]);
                        Console.WriteLine("Surname: " + Governors[recordCount, 2]);
                        Console.WriteLine("DOB: " + Governors[recordCount, 3]);
                        Console.WriteLine("Gender: " + Governors[recordCount, 4]);
                        Console.WriteLine("Medical History: " + Governors[recordCount, 5]);
                        Console.WriteLine("Role: " + Governors[recordCount, 6]);
                        Console.WriteLine("Home Number: " + Governors[recordCount, 7]);
                        Console.WriteLine("Mobile Number: " + Governors[recordCount, 8]);
                        recordCount++;
                        c++;
                        Console.ForegroundColor = ConsoleColor.Gray;

                    }
                    else
                    {
                        loopCount++;
                    }

                }
                Console.ReadLine();
            }
            public void newRecord()
            {
                listNumber++;
            }
            public void govMenu()
            {

                Console.WriteLine("<><><><><><><><><><><><><><>\n\n(1)View Prisoner Records\n(2)View Staff Records\n(3)View Personal Record\n(4)Logout\n\n<><><><><><><><><><><><><><>");
                userChoice = Console.ReadLine();
                Console.Clear();
                if (userChoice == "1")
                {
                    govViewPrisonRec();
                    Console.Clear();
                }
                else if (userChoice == "2")
                {
                    govViewStaffRec();
                    Console.Clear();
                }
                else if (userChoice == "3")
                {
                    govViewPersonalRec();
                    Console.Clear();
                }
                else if (userChoice == "4")
                {
                    x++;
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Please enter a valid option. (1-4)");
                }
            }

            public void allPrisonRec()
            {
                int c = 0;
                int loopCount = 0;
                while (c == 0)
                {
                    if (recordCount < Prisoner.listNumberP)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Prisoner ID: " + Prisoners[recordCount, 0]);
                        Console.WriteLine("First Name: " + Prisoners[recordCount, 1]);
                        Console.WriteLine("Surname: " + Prisoners[recordCount, 2]);
                        Console.WriteLine("DOB: " + Prisoners[recordCount, 3]);
                        Console.WriteLine("Gender: " + Prisoners[recordCount, 4]);
                        Console.WriteLine("Medical History: " + Prisoners[recordCount, 5]);
                        Console.WriteLine("Home Number: " + Prisoners[recordCount, 6]);
                        Console.WriteLine("Mobile Number: " + Prisoners[recordCount, 7]);
                        Console.WriteLine("Role: " + Prisoners[recordCount, 8]);
                        Console.WriteLine("Cell: " + Prisoners[recordCount, 9]);
                        Console.WriteLine("Conviction: " + Prisoners[recordCount, 10]);
                        Console.WriteLine("Criminal Record: " + Prisoners[recordCount, 11] + "\n");
                        recordCount++;
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else
                    {
                        loopCount++;
                        c++;
                    }
                }
                Console.ReadLine();
            }

            public int returnMenu()
            {
                return x;
            }
            public void govViewPrisonRec()
            {
                y++;
                allPrisonRec();

            }
            public void govViewStaffRec()
            {
                int c = 0;
                int loopCount = 0;
                while (c == 0)
                {
                    if (recordCount < Warden.listNumberW)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Warden ID: " + Wardens[recordCount, 0]);
                        Console.WriteLine("First Name: " + Wardens[recordCount, 1]);
                        Console.WriteLine("Surname: " + Wardens[recordCount, 2]);
                        Console.WriteLine("DOB: " + Wardens[recordCount, 3]);
                        Console.WriteLine("Gender: " + Wardens[recordCount, 4]);
                        Console.WriteLine("Medical History: " + Wardens[recordCount, 5]);
                        Console.WriteLine("Role: " + Wardens[recordCount, 6]);
                        Console.WriteLine("Home Number: " + Wardens[recordCount, 7]);
                        Console.WriteLine("Mobile Number: " + Wardens[recordCount, 8] + "\n");
                        recordCount++;
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else
                    {
                        loopCount++;
                        c++;
                    }
                }
                Console.ReadLine();
            }
        }

        public class Warden : Person
        {
            int wardID = 0;
            string assignedWing;
            protected string password;
            public int i = 0;
            protected string crimRec;
            public static int listNumberW = 0;
            int y = 0;
            int z = 0;
            private string userChoice;
            string wMenuChoice;
            string strWardID;

            List<int> wardenIDs = new List<int>();
            List<string> assignedWings = new List<string>();
            public void setWardID()
            {
                Console.WriteLine("New Warden ID: W" + wardID);
                wardID++;
                strWardID = ("W" + wardID);

            }
            public void setWing()
            {
                Console.WriteLine("Wing A or Wing B");
                assignedWing = Console.ReadLine();
                if (assignedWing == "A")
                {
                    Console.WriteLine("The Warden is set to Wing: " + assignedWing);
                    assignedWings.Add(assignedWing);
                    Console.Clear();
                }
                else if (assignedWing == "B")
                {
                    Console.WriteLine("The Wardem is set to Wing: " + assignedWing);
                    assignedWings.Add(assignedWing);
                    Console.Clear();
                }
                else
                {
                    Warden newWarden = new Warden();
                    Console.WriteLine("Sorry, that wing is not available. Please try again.");
                    newWarden.setWing();
                }
            }
            public void displayWardDetails()
            {
                foreach (string wing in assignedWings)
                {
                    Console.WriteLine("Assigned Wing: " + wing);
                }
                Console.WriteLine("Your password is: " + password);
                Console.ReadLine();
                Console.Clear();
            }
            public void wardViewPersonalRec()
            {
                int c = 0;
                int loopCount = 0;
                while (c == 0)
                {
                    Console.Clear();
                    if (recordCount < listNumberW)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Warden ID: " + Wardens[recordCount, 0]);
                        Console.WriteLine("First Name: " + Wardens[recordCount, 1]);
                        Console.WriteLine("Surname: " + Wardens[recordCount, 2]);
                        Console.WriteLine("DOB: " + Wardens[recordCount, 3]);
                        Console.WriteLine("Gender: " + Wardens[recordCount, 4]);
                        Console.WriteLine("Medical History: " + Wardens[recordCount, 5]);
                        Console.WriteLine("Role: " + Wardens[recordCount, 6]);
                        Console.WriteLine("Home Number: " + Wardens[recordCount, 7]);
                        Console.WriteLine("Mobile Number: " + Wardens[recordCount, 8]);
                        recordCount++;
                        c++;
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else
                    {
                        loopCount++;
                    }
                    Console.ReadLine();

                }
            }
            public void newRecord()
            {
                listNumberW++;
            }
            public void wardMenu()
            {
                int b = 0;
                while (b == 0)
                {
                    Console.WriteLine("<><><><><><><><><><><><><><>\n\n(1)View Prisoner Records\n(2)View Personal Record\n(3)Logout\n\n<><><><><><><><><><><><><><>");
                    userChoice = Console.ReadLine();
                    if (userChoice == "1")
                    {
                        b++;
                        wardViewPrisonRec();
                    }
                    else if (userChoice == "2")
                    {
                        b++;
                        wardViewPersonalRec();
                    }
                    else if (userChoice == "3")
                    {
                        b++;
                        mainMenu.x = mainMenu.x++;
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid option. (1-3)");
                    }
                }
            }
            public void wardViewPrisonRec()
            {
                allPrisonRec();
            }
            public void allPrisonRec()
            {
                int c = 0;
                int loopCount = 0;
                while (c == 0)
                {
                    if (recordCount < Prisoner.listNumberP)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Prisoner ID: " + Prisoners[recordCount, 0]);
                        Console.WriteLine("First Name: " + Prisoners[recordCount, 1]);
                        Console.WriteLine("Surname: " + Prisoners[recordCount, 2]);
                        Console.WriteLine("DOB: " + Prisoners[recordCount, 3]);
                        Console.WriteLine("Gender: " + Prisoners[recordCount, 4]);
                        Console.WriteLine("Medical History: " + Prisoners[recordCount, 5]);
                        Console.WriteLine("Home Number: " + Prisoners[recordCount, 7]);
                        Console.WriteLine("Mobile Number: " + Prisoners[recordCount, 8]);
                        Console.WriteLine("Role: " + Prisoners[recordCount, 6]);
                        Console.WriteLine("Cell: " + Prisoners[recordCount, 9]);
                        Console.WriteLine("Conviction: " + Prisoners[recordCount, 10]);
                        Console.WriteLine("Criminal Record: " + Prisoners[recordCount, 11] + "\n");
                        recordCount++;
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else
                    {
                        loopCount++;
                        c++;
                    }

                }
            }
            public void singPrisonRec()
            {
                int c = 0;
                int loopCount = 0;
                while (c == 0)
                {
                    if (recordCount < Prisoner.listNumberP)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Prisoner ID: " + Prisoners[recordCount, 0]);
                        Console.WriteLine("First Name: " + Prisoners[recordCount, 1]);
                        Console.WriteLine("Surname: " + Prisoners[recordCount, 2]);
                        Console.WriteLine("DOB: " + Prisoners[recordCount, 3]);
                        Console.WriteLine("Gender: " + Prisoners[recordCount, 4]);
                        Console.WriteLine("Medical History: " + Prisoners[recordCount, 5]);
                        Console.WriteLine("Home Number: " + Prisoners[recordCount, 6]);
                        Console.WriteLine("Mobile Number: " + Prisoners[recordCount, 7]);
                        Console.WriteLine("Role: " + Prisoners[recordCount, 8]);
                        Console.WriteLine("Cell: " + Prisoners[recordCount, 9]);
                        Console.WriteLine("Conviction: " + Prisoners[recordCount, 10]);
                        Console.WriteLine("Criminal Record: " + Prisoners[recordCount, 11] + "\n");
                        recordCount++;
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else
                    {
                        loopCount++;
                        c++;
                    }

                }
            }
            public void wardViewStaffRec()
            {
                while (z == 0)
                {
                    Console.WriteLine("<><><><><><><><><><><><><><>\n\nDo you wish to view a single record or the entire prison?\n(1)Single Record\n(2)Entire Record Sheet\n\n<><><><><><><><><><><><><><>");
                    wMenuChoice = Console.ReadLine();
                    if (wMenuChoice == "1")
                    {
                        //z++;
                        //singStaffRec();
                    }
                    else if (wMenuChoice == "2")
                    {
                        //z++;
                        //allStaffRec();
                    }
                    else
                    {
                        Console.WriteLine("Please select a valid option. (1-2)");
                    }
                }
            }
            public void addWardDetails()
            {
                Wardens[listNumberW, 0] = strWardID;
                Wardens[listNumberW, 1] = firstName;
                Wardens[listNumberW, 2] = surname;
                Wardens[listNumberW, 3] = DOB;
                Wardens[listNumberW, 4] = gender;
                Wardens[listNumberW, 5] = medHistory;
                Wardens[listNumberW, 6] = role;
                Wardens[listNumberW, 7] = homeNo;
                Wardens[listNumberW, 8] = mobileNo;
                listNumberW++;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Warden succesfully added");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }

        public class mainMenu
        {
            public static int x = 1;
            public void displayMenu()
            {
                Console.WriteLine("<><><><><><><><><><><><><><>\n\n1) Appoint Governor\n2) Appoint Warden\n3) Register Prisoner\n4) Go to Governor's Area\n5) Go to Warden's Area\n6) Help\n7) Exit Application\n\n<><><><><><><><><><><><><><>");//MENU DOESNT LOOP SOMETHING TO DO WITH X NOT MATCHING 1
            }
            static void Main(string[] args)
            {
                Person newPerson = new Person();
                Governor newGovernor = new Governor();
                Warden newWarden = new Warden();
                Prisoner newPrisoner = new Prisoner();
                mainMenu Menu = new mainMenu();
                string govPassAttempt;
                string wardPassAttempt;
                int i = 3;
                string userChoice;
                while (x == 1)
                {
                    Menu.displayMenu();
                    userChoice = Console.ReadLine();
                    if (userChoice == "1")
                    {
                        Console.Clear();
                        newGovernor.setFirstName();
                        newGovernor.setSurname();
                        newGovernor.setDOB();
                        newGovernor.setGender();
                        newGovernor.setMedHistory();
                        newGovernor.setRole();
                        newGovernor.setHomeNo();
                        newGovernor.setMobNo();
                        newGovernor.setGovID();
                        newGovernor.setGovPassword();
                        newGovernor.displayGovDetails();
                        newGovernor.addGovDetails();
                        Console.Clear();
                    }
                    else if (userChoice == "2")
                    {
                        newWarden.setFirstName();
                        newWarden.setSurname();
                        newWarden.setDOB();
                        newWarden.setGender();
                        newWarden.setMedHistory();
                        newWarden.setHomeNo();
                        newWarden.setMobNo();
                        newWarden.setWardID();
                        newWarden.setWing();
                        newWarden.addWardDetails();
                        Console.Clear();
                    }
                    else if (userChoice == "3")
                    {
                        newPrisoner.setFirstName();
                        newPrisoner.setSurname();
                        newPrisoner.setDOB();
                        newPrisoner.setGender();
                        newPrisoner.setMedHistory();
                        newPrisoner.setHomeNo();
                        newPrisoner.setMobNo();
                        newPrisoner.setRole();
                        newPrisoner.setPrisonerID();
                        newPrisoner.setConviction();
                        newPrisoner.setCrimRec();
                        newPrisoner.addPrisonDetails();
                        Console.Clear();
                    }
                    else if (userChoice == "4")
                    {
                        int u = 0;
                        int p = 0;
                        Console.Clear();
                        while (u == 0)
                        {
                            while (p < 1)
                            {
                                Console.WriteLine("Please enter the password: ");
                                Console.ForegroundColor = ConsoleColor.Black;
                                govPassAttempt = Console.ReadLine();
                                Console.ForegroundColor = ConsoleColor.Gray;
                                if (govPassAttempt == "Password")
                                {
                                    Console.Clear();
                                    newGovernor.govMenu();
                                    u++;
                                    p++;
                                }
                                else
                                {
                                    Console.WriteLine("The password is incorrect, you have (" + i + ") more attempt(s).");
                                }
                            }
                        }
                    }
                    else if (userChoice == "5")
                    {
                        int u = 0;
                        int p = 0;
                        Console.Clear();
                        while (u == 0)
                        {
                            while (p < 1)
                            {
                                Console.WriteLine("Please enter the password: ");
                                Console.ForegroundColor = ConsoleColor.Black;
                                wardPassAttempt = Console.ReadLine();
                                Console.ForegroundColor = ConsoleColor.Gray;
                                if (wardPassAttempt == "Password")
                                {
                                    newWarden.wardMenu();
                                    u++;
                                    p++;
                                }
                                else
                                {
                                    i--;
                                    Console.WriteLine("The password is incorrect, you have (" + i + ") more attempt(s).");
                                }
                            }
                        }
                    }
                    else if (userChoice == "6")
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        x++;
                        Console.WriteLine("<><><><><><><><><><><><><><>\n           HELP\n\nTo appoint a Governor press 1\nTo appoint a Warden press 2\nTo register a prisoner press 3\nTo enter the Governors section press 4\nTo enter the Wardens section press 5\nTo exit the application press 7\n\nTo back out of this page please press enter.\n\n<><><><><><><><><><><><><><>");
                        Console.ReadLine();
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Gray;
                        x--;
                    }
                    else if (userChoice == "7")
                    {
                        System.Environment.Exit(1);
                    }
                    else
                    {
                        Console.WriteLine("Please select a valid option. (1-7)");
                        Console.Clear();
                    }
                }
            }
        }
    }
}