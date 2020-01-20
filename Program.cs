using System;

namespace ConsoleApp3


{
    
    public interface arithmatic_operation
    {
        void operation(double a,double b);
        
    }
    class OPERATION_Imp : arithmatic_operation
    {
        public static double total ;
        public  int Flg=0;
        public string ch = "";

        public void operation(double a, double b)
        {
            if (ch == "+")
            {
                if (Flg == 0)
                {


                    total = a + b;
                    Display();
                }
                else
                {
                    total = total + b;
                    Display();
                }
            }
            else
            {
                Console.WriteLine("error");
            }
               
            
        }
        public void Display()
        {
            Console.WriteLine("result: " + total);
        }
    }


    class Program
    {
        static void Main(String [] args)
        {
            double p = Convert.ToDouble(Console.ReadLine());
            OPERATION_Imp op = new OPERATION_Imp();
            while (true)
            {
                op.ch= Console.ReadLine();
                double x = Convert.ToDouble(Console.ReadLine());
                
                    
                    op.operation(p, x);
                    p = 0;
              
                op.Flg = 1;
               
                
            }
            


        }
    }

    
}

    
