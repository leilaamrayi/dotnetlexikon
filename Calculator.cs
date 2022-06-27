using System;
namespace myprogram
{
   public class Calculator
    {
        public static void Main(string[] args)
        {
            string Option = "";
            
            while (Option != "0")
            {
                Console.WriteLine("please select one of options!   " + "1: ADD  " + "2: SUBSTRACT   " + "3: MULTIPLY   " + "4: DIVIDE  " + "0: exit");
                Option = Console.ReadLine();
                
                if (Option == "0")
                {
                    continue; // go to next loop in the current while block
                }
                
                switch (Option)
                {
                    case "1":
                        add();
                        break;

                    case "2":
                        substract();
                        break;

                    case "3":
                        multiply();
                        break;

                    case "4":
                        divide();
                        break;                        

                    default:
                        Console.WriteLine("you selected wrong option ");
                        break;

                }
            }
            
        }

        public static void add()
        {
            double[] nums = getNums();
            double Add = 0;
            foreach (double num in nums)
            {
                Add += num;
            }
            Console.WriteLine("the answer is :  " + Add);
        }
        public static void substract()
        {
            double[] nums = getNums();
            double Sub = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                Sub -= nums[i];
            }
            Console.WriteLine("the answer is :  " + Sub);
        }

        public static void multiply()
        {
            double[] nums = getNums();
            double Multi = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                Multi *= nums[i];
            }
            Console.WriteLine("the answer is :  " + Multi);
        }

        public static void divide()
        {
            bool tryAgain = false;
            double[] nums;
            do
            {
                nums = getNums();
                for (int i = 1; i < nums.Length; i++)
                {
                    if (nums[i] == 0)
                    {
                        Console.WriteLine("Cannot divide by zero! Please try again.");
                        tryAgain = true;
                        break;
                    } else 
                    { 
                        tryAgain = false; 
                    }
                }
            } while (tryAgain);



            double Division = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                Division /= nums[i];
            }
            Console.WriteLine("the answer is :  " + Division);
        }

        static double[] getNums()
        {
            List<double> nums = new List<double>();
            Console.WriteLine("please enter some numbers separated by a space:");
            String input = Console.ReadLine();
            String[] sections = input.Split(" ");
            foreach (String s in sections) {
                nums.Add(Convert.ToDouble(s.Trim()));
            }
            return nums.ToArray();
        }
    }
}
  
    
   
 


  




