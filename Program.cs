using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    struct Employee
    {
        #region structure of employees
        #region fields
        int id;
        string name;
        int salary;
        string security;
        string gender;
        HiringData hiredata;
        #endregion
        #region constractors
        #endregion
        #region property

        #endregion
        #region methods
        #region getter & setter
        public void SetID(int x)
        {
            if (x >= 1)
            {
                id = x;
            }
        }
        public int GetID()
        {
            return id;
        }
        public void SetName(string x)
        {
            if (x.Length >= 3)
            {
                name = x;
            }
        }
        public string GetName()
        {
            return name;
        }
        public void SetSalary(int x)
        {
            if (x >= 3000)
            {
                salary = x;
            }
        }
        public int GetSalary()
        {
            return salary;
        }
        public void SetSecurity(int y )
        {
               
                switch (y)
                {
                    case 1:
                        security = "Guest";
                        break;
                    case 2:
                        security = "Developer";
                        break;
                    case 3:
                        security = "Secretary";
                        break;
                    case 4:
                        security = "DBA";
                        break;
                    default:
                        Console.WriteLine("Wronge choice");
                        break;
                }


        }
        public string GetSecurity()
        {
            return security;
        }
        public void SetGender(char x)
        {
            
                switch (x)
                {
                    case 'm':
                    case 'M':
                        gender ="Male";
                        break;
                    case 'f':
                    case 'F':
                        gender = "Femae";
                        break;
                    
                    default:
                        Console.WriteLine("Wronge choice");
                        break;
                }

            
        }
        public string GetGender()
        {
            return gender;
        }
        public void SetHire( HiringData d)
        {
            hiredata = d;
        }
        public HiringData GetHire( )
        {
            return hiredata;

        }
        #endregion
        public void print()
        {
            Console.WriteLine($"Employee data : Id --> {id} , Name --> {name} , Salary --> {salary} , Srcurity Level --> {security}, Gender --> {gender}, Hire Date --> {hiredata.Hire()} ");
        }
        #endregion
        #endregion
    }
    struct HiringData
    {
        #region struct of hiring data
        #region fields
        int day;
        int month;
        int year;
        #endregion
        #region constractors
        #endregion
        #region property
        public int Day
        {
            set
            {
                if (value >= 1 && value <= 30) day = value;
            }
            get
            {
                return day;
            }
        }
        public int Month
        {
            set
            {
                if (value >= 1 && value <= 12) month = value;
            }
            get
            {
                return month;
            }
        }
        public int Year
        {
            set
            {
                if (value >2000 && value<=2022) year = value;
            }
            get
            {
                return year;
            }
        }
        #endregion
        #region methods
        public string Hire()
        {
            return $"{day} - {month} - {year}";
        }
        #endregion
        #endregion
    }
    internal class Program
    {
        #region task2
        public static HiringData Newdata()
        {
            HiringData newdate = new HiringData();
            Console.Write("Enter a day ");
            newdate.Day = int.Parse(Console.ReadLine());
            Console.Write("Enter a month ");
            newdate.Month = int.Parse(Console.ReadLine());
            Console.Write("Enter a year ");
            newdate.Year = int.Parse(Console.ReadLine());
            return newdate;
        }
        public static Employee[] emparray( Employee [] x)
        {
            for (int i = 0; i<x.Length;i++)
            {
                Console.Clear();
                Console.WriteLine($"Employee [{i + 1}] Data ");
                Console.Write($"\tID = ");
                x[i].SetID( int.Parse(Console.ReadLine()));
                Console.Write($"\tName = ");
                x[i].SetName(Console.ReadLine());
                Console.Write($"\tSalary = ");
                x[i].SetSalary(int.Parse( Console.ReadLine()));
                Console.WriteLine($" M --> Male \n F --> Female  ");
                Console.Write($"\t Gender = ");
                x[i].SetGender(char.Parse(Console.ReadLine()));
                Console.WriteLine($" 1- Guest \n 2- Developer \n 3- Secretary \n 4- DBA ");
                Console.Write($"\tSecurity = ");
                x[i].SetSecurity( int.Parse(Console.ReadLine()));
                HiringData y = Newdata();
                x[i].SetHire (y);
            }
            return x;
        }
        public static void GetArray( Employee [] x)
        {
            for(int i = 0; i < x.Length; i++)
            {
                x[i].print();
            }
        }
        #endregion
        #region task3
        public static void ConcatArray(Employee [] x , Employee [] y , int s,int k)
        {
            Employee[]first =  emparray(x);
            Employee[]second=  emparray(y);
            Employee[] fullarr = new Employee[s+k];
            for(int i = 0; i < first.Length; i++)
            {
                fullarr[i] = first[i];
            }
            int j = 0;
            for(int i = first.Length; i < fullarr.Length; i++,j++)
            {
                fullarr[i] = second[j];
            }
            for(int i = 0; i < fullarr.Length; i++)
            {
                fullarr[i].print();
            }
           
        }
        #endregion
        #region try it 
        //public static void InsetToArray(Employee[] x)
        //{
        //    Employee[] oldarr = emparray(x);
        //    Employee[] newarr = new Employee[oldarr.Length + 1];
        //    for (int i = 0; i < newarr.Length; i++)
        //    {
        //        Employee y = new Employee();
        //        if (i < oldarr.Length - 1)
        //            newarr[i] = oldarr[i];
        //        else if (i == oldarr.Length)
        //            newarr[i] = y;
        //        else
        //            newarr[i] = oldarr[i - 1];
        //    }
        //}

        #endregion
        #region function of task 6
        public static void InsertData( Employee [] array ,int i)
        {
                    Console.WriteLine($"Employee [{i + 1}] Data ");
                    Console.Write($"\tID = ");
                    array[i].SetID(int.Parse(Console.ReadLine()));
                    Console.Write($"\tName = ");
                    array[i].SetName(Console.ReadLine());
                    Console.Write($"\tSalary = ");
                    array[i].SetSalary(int.Parse(Console.ReadLine()));
                    Console.WriteLine($" M --> Male \n F --> Female  ");
                    Console.Write($"\t Gender = ");
                    array[i].SetGender(char.Parse(Console.ReadLine()));
                    Console.WriteLine($" 1- Guest \n 2- Developer \n 3- Secretary \n 4- DBA ");
                    Console.Write($"\tSecurity = ");
                    array[i].SetSecurity(int.Parse(Console.ReadLine()));
                    HiringData y = Newdata();
                    array[i].SetHire(y);

                
        }
        public static void Display( Employee [] x)
        {
            for(int i =0;i<x.Length; i++)
            {
                if (x[i].GetID() != 0)
                {
                    x[i].print();
                }
                
            }
            Console.ReadKey();
        }
        public static void SearchByID(Employee[] x)
        {
            Console.Write(" For search by id please insert it : ");
            int number = int.Parse(Console.ReadLine());
            for (int i =0;i<x.Length;i++)
            {
                if (number == x[i].GetID())
                {
                    x[i].print();
                    break;
                }
            }
            Console.ReadKey();
        }
        public static void SearchByName(Employee[] x)
        {
            Console.Write(" For search by name please insert it : ");
            string y = Console.ReadLine();
            for (int i = 0; i < x.Length; i++)
            {
                if (y == x[i].GetName())
                {
                    x[i].print();
                    break;
                }
            }
            Console.ReadKey();
        }
        public static void CountInsert(Employee[] x)
        {
            int count = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i].GetID() == 0)
                {
                    continue;
                }
                else
                {
                  count++ ;
                }
            }
            Console.WriteLine($"The count number is : {count}");
            Console.ReadKey();
        }

        public static void UpdateByID(Employee[] x)
        {
            Console.Write(" For search by id please insert it : ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < x.Length; i++)
            {
                if (number == x[i].GetID())
                {
                    Console.Write($"\tName = ");
                    x[i].SetName(Console.ReadLine());
                    Console.Write($"\tSalary = ");
                    x[i].SetSalary(int.Parse(Console.ReadLine()));
                    Console.WriteLine($" M --> Male \n F --> Female  ");
                    Console.Write($"\t Gender = ");
                    x[i].SetGender(char.Parse(Console.ReadLine()));
                    Console.WriteLine($" 1- Guest \n 2- Developer \n 3- Secretary \n 4- DBA ");
                    Console.Write($"\tSecurity = ");
                    x[i].SetSecurity(int.Parse(Console.ReadLine()));
                    HiringData y = Newdata();
                    x[i].SetHire(y);
                    break;
                }
            }
            Console.ReadKey();
        }
        public static void DeletByID(Employee[] x)
        {
            Console.Write(" For search by id please insert it : ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < x.Length; i++)
            {
                if (number == x[i].GetID())
                {
                    x[i] = new Employee();
                }
            }
            Console.ReadKey();
        }
        #endregion
        static void Main(string[] args)
        {
            #region task 1
            //HiringData newdate = new HiringData();
            //Console.Write("Enter a day ");
            //newdate.Day = int.Parse(Console.ReadLine());
            //Console.Write("Enter a month ");
            //newdate.Month = int.Parse(Console.ReadLine());
            //Console.Write("Enter a year ");
            //newdate.Year = int.Parse(Console.ReadLine());

            //Employee ahmed = new Employee();
            //Console.Write("Enter employee id ");
            //ahmed.SetID(int.Parse(Console.ReadLine()));
            //Console.Write("Enter employee salary ");
            //ahmed.SetSalary(int.Parse(Console.ReadLine()));
            //Console.Write("Enter employee gender ");
            //Console.WriteLine($" M --> Male \n F --> Female  ");
            //ahmed.SetGender(char.Parse(Console.ReadLine()));
            //Console.Write("Enter employee Security level ");
            //Console.WriteLine($" 1- Guest \n 2- Developer \n 3- Secretary \n 4- DBA ");
            //ahmed.SetSecurity(int.Parse(Console.ReadLine()));
            //ahmed.SetHire(newdate);
            //ahmed.print();
            #endregion
            #region task2 
            //Console.Write("Size of array is : ");
            //int size = int.Parse(Console.ReadLine());
            //Employee[] arr = new Employee[size];
            //emparray(arr);
            //GetArray(arr);
            #endregion
            #region task3
            //Console.Write("Size of first array is : ");
            //int size = int.Parse(Console.ReadLine());
            //Employee[] arr = new Employee[size];
            //Console.Write("Size of second array is : ");
            //int size2 = int.Parse(Console.ReadLine());
            //Employee[] arr2 = new Employee[size2];
            //ConcatArray(arr,arr2,size,size2);
            #endregion
            #region display task 6
            Boolean flag = false;
            Employee[] dataa = new Employee[10];
            int i = 0;

            do
            {
                Console.Clear();
                Console.WriteLine($"a- Insert new employee \n b- Display inserted employees only \n c- Seaarch by id \n d- Search by name \n e- Count number of inserted employee \n f- Update employee by id \n g- Delete employee by id \n h- Exit");
                Console.Write("Please enter your choice --> ");
                char ch = char.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 'a':
                    case 'A':
                        if (dataa[i].GetID() == 0)
                        {
                            InsertData(dataa, i);
                        }
                        else
                        {
                            ++i;
                            InsertData(dataa, i);
                        }
                        break;
                    case 'b':
                    case 'B':
                        Display(dataa);
                        break;
                    case 'c':
                    case 'C':
                        SearchByID(dataa);
                        break;
                    case 'd':
                    case 'D':
                        SearchByName(dataa);
                        break;
                    case 'e':
                    case 'E':
                        CountInsert(dataa);
                        break;
                    case 'f':
                    case 'F':
                        UpdateByID(dataa);
                        break;
                    case 'g':
                    case 'G':
                        DeletByID(dataa);
                        break;
                    case 'h':
                    case 'H':
                        flag = true;
                        break;
                    default:
                        Console.WriteLine("Wrong Choice");
                        break;
                }
            } while (flag != true);

            #endregion
            Console.ReadKey();
        }
    }
}
