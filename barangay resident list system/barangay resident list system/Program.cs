/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 27/05/2025
 * Time: 8:24 pm
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
namespace katleengomez
{
	
		
	    struct RESIINFO
		{
			public string Name;
			public string Address;
			public int Age;
			public bool Minor;
			public bool Adults;
			public bool Senior;
			public bool Student;
			public bool Single;
			public bool Married;
			public bool Deceased;
			public bool RegisteredVoters;
			
			
			
	    }
	   
	      class program
		 {
	    static ArrayList ALLINFOR = new ArrayList();
	    
		public static void Main(string[]args)
		{
			while (true)
			{   
				
				 Console.WriteLine("=====================================");
				Console.WriteLine("| BARANGAY MANGEMENT RESIDENT SYSTEM |");
				Console.WriteLine("======================================");
				Console.WriteLine("1) .Add resident " +
				                  "\n2).Viewll all List" +
				                  "\n3).View Minor" +
				                  "\n4).view Senior"+
				                  "\n5).View all Adults" +
				                  "\n6).View student " +
				                  "\n7).view single"+
				                  "\n8).view married" +
				                  "\n9).view deceased " +
				                  "\n10).View registred voters" + 
				                  "\n11.) update resident informations" + 
				                  "\n12).remove resident" +
				                  "\n13). exit");
				Console.Write("Choose: ");
				int Choose = Convert.ToInt32(Console.ReadLine());
				Console.Clear();
				
				switch(Choose)
				{
					case 1:
						AddResidents();
						break;
					case 2:
						ViewallList();
						break;
					case 3:
						Minor();
						break;
					case 4:
						senior();
						break;
					case 5:
						adults();
						break;
					case 6:
						student();
						break;
					case 7:
						single();
						break;
					case 8:
						married();
						break;
					case 9:
						Deceased();
						break;
					case 10:
						Registeredvoters();
						break;
					case 11:
						Updateresiinfo();
						break;
					case 12:
						Removeresi();
						break;
					case 13:
						return;
					default:
						Console.WriteLine("invalid choise");
						return;
						
						
						
				}
				
			}
			
			
		}
		 static void AddResidents()
		{   
			var INFO = new RESIINFO();
			Console.WriteLine("===================================");
			Console.WriteLine("|    *Adding of residents *       |");
			Console.WriteLine("===================================");
			Console.Write("name: " );
			INFO.Name = Console.ReadLine();
			
			Console.Write("address: ");
			INFO.Address = Console.ReadLine();
			
			Console.Write("age: " );
			INFO.Age = Convert.ToInt32(Console.ReadLine());
			
			if (INFO.Age < 18)
			{
				INFO.Minor = true;
			} else if (INFO.Age >=18)
			{
				
				INFO.Adults = true;
			} else if (INFO.Age >59 )
			{
				INFO.Senior = true;
			}
			
			
			bool studentconfirm = false;
			while(!studentconfirm)
			{
				Console.Write("are you Student (yes/no) : ");
			string Student = Console.ReadLine();
		
			if(Student == "Yes" || Student == "yes")
			{
				INFO.Student = (true);
				studentconfirm = (true);
			} else if (Student == "No" || Student == "no")
			{
				INFO.Student = (false);
				studentconfirm = (true);
			}  if(!studentconfirm)
			{
				Console.WriteLine("invalid , pls put the right answer\n");
				studentconfirm = (false);
			}
			}
			
			  bool singleconfirm = false;
			  while (!singleconfirm)
			  {
			  	Console.Write("are you single (Yes/No) : ");
			string Single = Console.ReadLine();
			
			if(Single == "Yes" || Single == "yes")
			{
				INFO.Single = (true);
				singleconfirm = (true);
			} else if (Single == "No" || Single == "no")
			{
				INFO.Single = (false);
				singleconfirm = (true);
			}  if(!singleconfirm)
			{
				Console.WriteLine("invalid , pls put the right answer\n");
				studentconfirm = false;
			}
			  }
			  
			  bool marriedconfirm = false;
			  while (!marriedconfirm) 
			  {
			 Console.Write("are you married (yes/no): ");
			string Married = Console.ReadLine();
			
			if(Married == "Yes" || Married == "yes")
			{
				INFO.Married = (true);
				marriedconfirm = (true);
			} else if (Married == "No" || Married == "no")
			{
				INFO.Married = (false);
				marriedconfirm = (true);
			}  else if(Married != "Yes" ||Married != "No")
			{
				Console.WriteLine("invalid , pls put the right answer\n");
				marriedconfirm = false;			
			}
			  }
			  
			  bool deceasedconfirm = false;
			  while (!deceasedconfirm)
			  {
			Console.Write("Deceased (yes/no): ");
			string deceased = Console.ReadLine();
			
			if(deceased == "Yes" || deceased == "yes")
			{
				INFO.Deceased = (true);
				deceasedconfirm = (true);
			} else if (deceased == "No" || deceased == "no")
			{
				INFO.Deceased = (false);
				deceasedconfirm = (true);
			}  else if(deceased != "Yes" ||deceased != "No")
			{
				Console.Write("invalid , pls put the right answer \n");
                deceasedconfirm = false;				
			}
			  }
			  
			  bool votersconfirm = false;
			  while (!votersconfirm)
			  {
			Console.Write("Are you registred voters (yes/no): ");
			string registeredvoters = Console.ReadLine();
			
			if(registeredvoters == "Yes" || registeredvoters == "yes")
			{
				INFO.RegisteredVoters = (true);
				votersconfirm = (true);
			} else if (registeredvoters == "No" || registeredvoters == "no")
			{  
				INFO.RegisteredVoters = (false);
				votersconfirm = (true);
			}  else if(registeredvoters != "Yes" ||registeredvoters != "No")
			{
				Console.Write("invalid , pls put the right answer");
				votersconfirm = false;
			}
			  }
			
			ALLINFOR.Add(INFO);
			 Console.Clear();
			Console.WriteLine("===================================");
			Console.WriteLine("|  Added to the list of residents |");
			Console.WriteLine("===================================");
			Console.WriteLine();
			  
		}
		 
		 static void ViewallList()
		{ 
			if (ALLINFOR .Count>0)
			{
			Console.WriteLine("===================================");
			Console.WriteLine("|        *List of residents*       |");
			Console.WriteLine("===================================");
			
			 
			foreach(RESIINFO List in ALLINFOR)
			{    Console.Clear();
				Console.WriteLine("name: " + List.Name + 
				                  "\nAge: " + List.Age + 
				                  "\nAddress: " + List.Address + 
				                  "\nMinor: " + List.Minor + 
				                  "\nAdult: " + List.Adults +
				                  "\nsenior: " + List.Senior + 
				                  "\nStudent: " + List.Student + 
				                  "\nSingle: " + List.Single + 
				                  "\nMarried: " + List.Married +
				                  "\nDeceased: " + List.Deceased + 
				                  "\nRegistered Voters: " + List.RegisteredVoters );
				Console.WriteLine();
			} 
			}else {
				
				
				Console.WriteLine("*****  X No resident found  *****");
				
			}  Console.WriteLine();
			 
		}
		 static void Minor(){
			if (ALLINFOR.Count > 0)
    {    Console.WriteLine("===================================");
        Console.WriteLine("|          Minors List             |");
         Console.WriteLine("===================================");
        bool foundMinor = false; 
        foreach (RESIINFO resident in ALLINFOR)
        {
            if (resident.Minor) 
            {
                foundMinor = true; 
                Console.WriteLine("Name: " + resident.Name + 
                                  "\n Age: " + resident.Age);
            }
        }
        if (!foundMinor) 
        {
            Console.WriteLine("***** No minors found. *****");
        }
    }
    else
    {   Console.Clear();
                 
				Console.WriteLine("*****   X No resident found   *****");
				
    }
		}
		
		static void senior()
		{
			if (ALLINFOR.Count > 0)
    {
            Console.WriteLine("===================================");
			Console.WriteLine("|   *List of Senior residents*    |");
			Console.WriteLine("===================================");
        bool SeniorList = false; 
        foreach (RESIINFO resident in ALLINFOR)
        {
            if (resident.Senior) 
            {
                SeniorList = true; 
                Console.WriteLine("Name: " + resident.Name + 
                                  "\n Age: " + resident.Age);
            }
        }
        if (!SeniorList) 
        {
            Console.WriteLine("**** No Senior found. *****");
        }
    }
    else
    	
    {    Console.Clear();
        Console.WriteLine("***** No residents found.   *****");
    }   Console.WriteLine();
		}
		
		static void adults()
		{
			if (ALLINFOR.Count>0)
			{
		    Console.WriteLine("===================================");
			Console.WriteLine("|    *Adult List of residents*    |");
			Console.WriteLine("===================================");
				bool AdultList = false;
				foreach (RESIINFO resident in ALLINFOR) 
				{ 
					if(resident.Adults)
					{
						AdultList = true;
						Console.WriteLine("Name: " + resident.Name + 
						                  "\n Age" + resident.Age );
					}
				}
				if(!AdultList)
				{
					Console.WriteLine("***** No Adult Found *****");
				}
			}
			else
			{  Console.Clear();
				Console.WriteLine("*****  No residents found.   *****");
			}  Console.WriteLine();
			
		}
		static void student()
		{
			if (ALLINFOR.Count > 0)
    {	
       	    Console.WriteLine("=======================================");
			Console.WriteLine("|   *Student List of residents*       |");
			Console.WriteLine("=======================================");
       	 bool StudentList = false; 
       	 foreach (RESIINFO resident in ALLINFOR)
        {
            if (resident.Student) 
            {
                StudentList = true; 
                Console.WriteLine("Name: " + resident.Name );
            }
        }
        if (!StudentList) 
        {  
            Console.WriteLine("***** No student found. *****");
        }   
  		  }
  		  else
   			 {Console.Clear();
      			  Console.WriteLine("*****  No residents found.  *****");
    } 		Console.WriteLine();
		}
		  static void single()
		{
			if (ALLINFOR.Count > 0)
    {
             Console.WriteLine("===================================");
			 Console.WriteLine("|    *Single List of residents*   |");
			 Console.WriteLine("===================================");
        bool SingleList = false; 
        foreach (RESIINFO resident in ALLINFOR)
        {
            if (resident.Single) 
            {
                SingleList = true; 
                Console.WriteLine("Name: " + resident.Name );
            }
        }
        if (!SingleList) 
        {
            Console.WriteLine("***** No single found. *****");
        }
    }
    else
    {   Console.Clear();
        Console.WriteLine("*****  No residents found.  *****");
    }    Console.WriteLine();
		}
		static void married()
		{
			if (ALLINFOR.Count > 0)
    {
            Console.WriteLine("===================================");
			Console.WriteLine("|  *Married List of residents*    |");
			Console.WriteLine("===================================");
        bool marriedList = false; 
        foreach (RESIINFO resident in ALLINFOR)
        {
            if (resident.Married) 
            {
                marriedList = true; 
                Console.WriteLine("Name: " + resident.Name );
            }
        }
        if (!marriedList) 
        {
            Console.WriteLine("***** No married found. *****");
        }
   	 }
     else
    {   Console.Clear();
        Console.WriteLine("*****  No residents found.  *****");
    }  Console.WriteLine();
		}
			static void Deceased()
		{
			if (ALLINFOR.Count > 0)
    {       Console.WriteLine("===================================");
			Console.WriteLine("|  *Deceased List of residents*   |");
			Console.WriteLine("===================================");
        
        bool DeceasedList = false; 
        foreach (RESIINFO resident in ALLINFOR)
        {
            if (resident.Deceased) 
            {
                 DeceasedList = true; 
                Console.WriteLine("Name: " + resident.Name );
            }
        }
        if (!DeceasedList) 
        {
            Console.WriteLine("***** No Deceased found. *****");
        }
    }
    else
    {   Console.Clear();
        Console.WriteLine("*****  No residents found.  *****");
    }    Console.WriteLine();
		}
		static void Registeredvoters()
		{ if (ALLINFOR.Count>0)
				
			{   Console.WriteLine("=============================================");
			    Console.WriteLine("|  *Registered Voters  List of residents*   |");
			    Console.WriteLine("=============================================");
				bool regisLit = false;
				foreach (RESIINFO resident in ALLINFOR) 
				{ 
					if(resident.RegisteredVoters)
					{
						regisLit = true;
						Console.WriteLine("Name: " + resident.Name );
					}
				}
				if(!regisLit)
				{
					Console.WriteLine("*****  No registred Voters Found  *****");
				}
			}
			else
			{  Console.Clear();
				Console.WriteLine("***** No residents found.  *****");
			}  Console.WriteLine();
			
		} 
		  static void Updateresiinfo()
		{

               
          {
                Console.WriteLine("=============================================");
                Console.WriteLine("|       *Update resident Information*       |");
                Console.WriteLine("=============================================");

                if (ALLINFOR.Count == 0)
                {
                    Console.WriteLine("***** No residents found in the list  *****.");
                    return;
                }

                Console.Write("Enter the name of the resident to update: ");
                string nameToUpdate = Console.ReadLine();
                bool found = false;

                for (int i = 0; i < ALLINFOR.Count; i++)
                {
                    var resident = (RESIINFO)ALLINFOR[i];

                    if (resident.Name == nameToUpdate)
                    {
                        found = true;
                        Console.WriteLine("Updating information for: " + resident.Name);
                        Console.WriteLine("=====================================");
                        Console.WriteLine("|           WHAT TO UPDATE           |");
                        Console.WriteLine("======================================");
                        Console.WriteLine("1. name " +
                                          "\n 2. address " +
                                          "\n 3. age" +
                                          "\n 4. if student" +
                                          "\n 5. if single" +
                                          "\n 6. if married" +
                                          "\n 7. if deceased " +
                                          "\n 8. if registered voters");


                        Console.Write("Choose: ");
                        int Choose = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        switch (Choose)
                        {
                            case 1:
                                Console.Write("Update name:  ");
                                resident.Name = Console.ReadLine();
                                ALLINFOR[i] = resident;
                                break;

                            case 2:
                                Console.Write("Update Address:  ");
                                resident.Address = Console.ReadLine();
                                ALLINFOR[i] = resident;
                                break;

                            case 3:
                                Console.Write("Enter the new age: ");
                                resident.Age = Convert.ToInt32(Console.ReadLine());
                                if (resident.Age < 18)
                                {
                                    resident.Minor = true;
                                }
                                else if (resident.Age >= 18)
                                {
                                    resident.Adults = true;
                                }
                                else if (resident.Age >= 60)
                                {
                                    resident.Senior = true;
                                }
                                ALLINFOR[i] = resident;
                                break;

                            case 4:
                                bool studentupdate = false;
                                while (!studentupdate)
                                {
                                    Console.Write("are you Student (yes/no) : ");
                                    string Student = Console.ReadLine();

                                    if (Student == "Yes" || Student == "yes")
                                    {
                                        resident.Student = (true);
                                        studentupdate = (true);
                                    }
                                    else if (Student == "No" || Student == "no")
                                    {
                                        resident.Student = (false);
                                        studentupdate = (true);
                                    }
                                    if (!studentupdate)
                                    {
                                        Console.WriteLine("invalid , put the right answer\n");
                                        studentupdate = (false);
                                    }
                                }
                                ALLINFOR[i] = resident;
                                break;
                            case 5:
                                bool statusupdate = false;
                                while (!statusupdate)
                                {
                                    Console.Write("are you single (Yes/No) : ");
                                    string Single = Console.ReadLine();

                                    if (Single == "Yes" || Single == "yes")
                                    {
                                        resident.Single = (true);
                                        statusupdate = (true);
                                    }
                                    else if (Single == "No" || Single == "no")
                                    {
                                        resident.Single = (false);
                                        statusupdate = (true);
                                    }
                                    if (!statusupdate)
                                    {
                                        Console.WriteLine("invalid , put the right answer\n");
                                        statusupdate = false;
                                    }
                                }
                                 ALLINFOR[i] = resident;
                                break;

                            case 6:
                                bool marriedConfirm = false;
                                while (!marriedConfirm)
                                    Console.Write("are you married (yes/no): ");
                                string Married = Console.ReadLine();

                                if (Married == "Yes" || Married == "yes")
                                {
                                    resident.Married = (true);
                                    statusupdate = (true);
                                }
                                else if (Married == "No" || Married == "no")
                                {
                                    resident.Married = (false);
                                    studentupdate = (true);
                                }
                                else if (Married != "Yes" || Married != "No")
                                {
                                    Console.WriteLine("invalid , pls put the right answer\n");
                                    studentupdate = false;
                                }
                                ALLINFOR[i] = resident;
                                break;


                            case 7:
                                bool deceasedConfirm = false;
                                while (!deceasedConfirm)
                                {
                                    Console.Write("Deceased (yes/no): ");
                                    string deceased = Console.ReadLine();

                                    if (deceased == "Yes" || deceased == "yes")
                                    {
                                        resident.Deceased = (true);
                                        deceasedConfirm = (true);
                                    }
                                    else if (deceased == "No" || deceased == "no")
                                    {
                                        resident.Deceased = (false);
                                        deceasedConfirm = (true);
                                    }
                                    else if (deceased != "Yes" || deceased != "No")
                                    {
                                        Console.Write("invalid , pls put the right answer \n");
                                        deceasedConfirm = false;
                                    }
                                }
                                ALLINFOR[i] = resident;
                                break;
                            case 8:
                                bool votersconfirm = false;
                                while (!votersconfirm)
                                {
                                    Console.Write("Are you registred voters (yes/no): ");
                                    string registeredvoters = Console.ReadLine();

                                    if (registeredvoters == "Yes" || registeredvoters == "yes")
                                    {
                                        resident.RegisteredVoters = (true);
                                        votersconfirm = (true);
                                    }
                                    else if (registeredvoters == "No" || registeredvoters == "no")
                                    {
                                        resident.RegisteredVoters = (false);
                                        votersconfirm = (true);
                                    }
                                    else if (registeredvoters != "Yes" || registeredvoters != "No")
                                    {
                                        Console.Write("invalid ,  put the right answer");
                                        votersconfirm = false;
                                    }
                                      }

                                ALLINFOR[i] = resident;
                                break;
                        }
                    }

                    if (!found)
                    {
                        Console.WriteLine("***** Resident not found. *****");
                    }
                }

		  }
		  }
		  static void Removeresi()  
		{   
			
			    Console.WriteLine("=============================================");
			    Console.WriteLine("|     *Remove resident from the List*       |");
			    Console.WriteLine("=============================================");
			bool removeList = false;
			if (ALLINFOR.Count>0) 
			{
				Console.WriteLine("Enter the name of the resident to remove: ");
				string nameToRemove = Console.ReadLine();
				
				
				foreach (RESIINFO resident in ALLINFOR) 
				{ 
					if (resident.Name == nameToRemove)
					{  
						removeList = true;
						ALLINFOR.Remove(resident);
						Console.WriteLine("\nResident\n " + nameToRemove + " \n has been removed.\n");
						
						break;
					}
				} if(!removeList)
				{
				  Console.WriteLine("No resident in the list to remove");
				}
				                  
			}
			
		} 
		  
	    }
	    }
