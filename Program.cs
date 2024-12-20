using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        //program.Task_1_1(0.9, 1.23);
        //program.Task_1_2(0.9, 1.23);
        //program.Task_1_3(0.9, 1.23);
        //program.Task_1_4(0.9, 1.23, -0.1);
        //program.Task_1_5(0.9, 1.23);
        //program.Task_1_6(0.9, 1.23);
        //program.Task_1_7(0.9);
        //program.Task_1_8(0.9);
        //program.Task_1_9(0.9);
        //program.Task_1_10(0.9);
        //program.Task_2_1(10);
        //program.Task_2_2(5, 3, 2, 1);
        //program.Task_2_2(5, 1.5, 1.5, 1);
        //program.Task_2_2(5, 1, 3, 1);
        //program.Task_2_3(10);
        //program.Task_2_4(5, 1, 2);
        //program.Task_2_5(10, 30);
        //program.Task_2_6(5);
        //program.Task_2_7(5);
        //program.Task_2_8(5);
        //program.Task_2_9(10);
        //program.Task_2_10(10);
        //program.Task_2_11(10);
        program.Task_2_12(1.5, 0);
       // program.Task_2_13(10, 5, 0);
        //program.Task_3_1();
        //program.Task_3_2(3, 2, 1);
        //program.Task_3_2(1.5, 1.5, 1);
        //program.Task_3_2(1, 3, 1);
        //program.Task_3_3();
        //program.Task_3_4(1, 2);
        //program.Task_3_5(30);
        //program.Task_3_6();
        //program.Task_3_7();
        //program.Task_3_8();
        //program.Task_3_9();
        //program.Task_3_10();
        //program.Task_3_11();
        //program.Task_3_12(10, 0);
        //program.Task_3_13(10, 5, 0);
    }
    #region Level 1
    public bool Task_1_1(double x, double y)
    {
        bool answer = false;

        // code here
        if (Math.Abs(x*x+y*y-4)<0.001)
                answer = true;
        else answer = false;
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if (y>=0 && y+Math.Abs(x)<=1)
            answer = true; else answer = false;


        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        if (a > 0)
            if (a > b)
                answer = a;
            else answer = b;
        if (a<=0)
            if (a > b)
                answer = b;
            else answer = a;
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;
        double p = 0;
        // code here
        if (a<b)
            p=a; else p = b;
        if (c>p)
            answer = c;
        else answer = p;

        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        if (2*Math.Sqrt(r/Math.PI)>Math.Sqrt(s)*Math.Sqrt(2))
            answer = true;
        else answer = false;
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        if (2 * Math.Sqrt(r / Math.PI) < Math.Sqrt(s))
            answer = true;
        else answer = false;
        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) > 1)
            answer = 1;
        if (Math.Abs(x) <=1)
            answer = Math.Abs(x);
        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) >= 1)
            answer = 0;
        if (Math.Abs(x) < 1)
            answer = Math.Pow(x,2)-1;
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1)
            answer = 0;
        if (x <= 0 && x>-1)
            answer = x+1;
        if (x > 0)
            answer = 1;
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1)
            answer = 1;
        if (x <= 1 && x > -1)
            answer = -x;
        if (x > 1)
            answer = -1;
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;

        // code here
        for (int i=1; i<=n; i++)
        {
            double hight = double.Parse(Console.ReadLine());
            answer = (answer + hight);
        }
        answer = answer / n;
        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        for (int i = 1; i <= n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (Math.Sqrt((x - a) * (x - a) + (y - b) * (y - b)) <= r)
            {
                answer++;
            }
        }
                // end

         return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        for (int i = 1; i <= n; i++)
        {
            double w = double.Parse(Console.ReadLine());
            if (w<30)
                answer+=0.2;
        }
        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        for (int i = 1;i<=n;i++)
            {
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                if ((x * x + y * y >= r1 * r1) && ((x * x) + (y * y) <= r2 * r2))
                        {  answer++; }
            }
        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;
        double distance = double.Parse(Console.ReadLine());
        // code here
        for (int i = 1; i <= 30; i++)
        {
            double run = double.Parse(Console.ReadLine());
            if (run >= distance)
                answer += 1;
        }
        
        // end

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;
        // code here
        for (int i = 1;i<=n;i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (y >= 0 && (x <= Math.PI))
                answer++;
        }
        // end

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here
        for (int i = 1;i<=n;i++)
        {
            double x=double.Parse(Console.ReadLine()) ;
            double y = double.Parse(Console.ReadLine());
            if (x>0 && y>0)
                answer1++;
            if (x<0 && y<0)
                answer3++;
            if (x > 0 && y < 0)
                Console.WriteLine(4);
            if (x < 0 && y > 0)
                Console.WriteLine(2);

        }
        // end

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        for (int i = 1;i<=n;i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (Math.Sqrt((x * x) + (y * y)) < answerLength)
                answer = i;
        }
        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        for (int i = 1;i<=n;i++)
        {
            double x = double.Parse(Console.ReadLine());
            if (answer<x)
                answer = x;
        }
        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        for (int i = 1; i <= n; i++)
        {
            int m1 = int.Parse(Console.ReadLine());
            int m2 = int.Parse(Console.ReadLine());
            int m3 = int.Parse(Console.ReadLine());
            int m4 = int.Parse(Console.ReadLine());
            if (m1>=4 && m2>=4 && m3>=4 && m4>=4)
                answer += 1;
        }
        // end

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;
        double k= 0;
        // code here;
        for ( int i = 1;i<=n;i++)
        {
            int m1 = int.Parse(Console.ReadLine());
            int m2 = int.Parse(Console.ReadLine());
            int m3 = int.Parse(Console.ReadLine());
            int m4 = int.Parse(Console.ReadLine());
            if (m1 == 2 || m2 == 2 || m3 == 2 || m4 == 2)
                answer += 1;
            k+=(m1+m2+m3+m4);


        }
        avg = k / n*4;
        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;
        if (type < 0 || type >= 3 || r <= 0)
            return 0;
        switch (type)
        {
            case 0:
                answer = r * r;
                break;
            case 1:
                answer = r * r * Math.PI;
                break;
            case 2:
                answer = r * r * Math.Sqrt(3) / 4;
                break;
        }
        Console.WriteLine(answer);
        return answer;
    }

        public double Task_2_13(double A, double B, int type)
    {
        double square = 0;
        if (type < 0  || type > 2 ||  A <= 0 || B <= 0)
            return 0;
        switch (type)
        {
            case 0:
                square = A * B;
                break;
            case 1:
                if (A > B)
                    return 0;
                square = Math.PI * (B * B - A * A);
                break;
            case 2:
                square = (A / 2) * Math.Sqrt(B * B - A * A / 4);
                break;
        }
        square = Math.Round(square, 2);

        return square;
    }
    #endregion

    #region Level 3
    public double Task_3_1()
    {
        // end

        // answer should be equal to the task_2_1 answer
    }
    public int Task_3_2(double r, double a, double b)
    {
        int answer = 0, n = 0;

        // code here

        // end

        return answer;
    }
    public double Task_3_3()
    {
        double answer = 0;
        int n = int.Parse(Console.ReadLine());

        // code here
        for (int i = 1; i <= n; i++)
        {
            double w = double.Parse(Console.ReadLine());
            if (w < 30)
                answer += 0.2;
        }
        // end

        return answer;
    }
    public int Task_3_4(double r1, double r2)
    {
        int answer = 0, n = 0;

        // code here

        // end

        return answer;
    }
    public int Task_3_5(double norm)
    {
        int answer = 0, n = int.Parse(Console.ReadLine());
        double distance = double.Parse(Console.ReadLine());
        // code here
        
        // end

        return answer;
    }
    public int Task_3_6()
    {
        int answer = 0, n = 0;
        double k=double.Parse(Console.ReadLine()); 
        // code here
        for (int i = 1;i<=k;i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (y >= 0 && (x <= Math.PI))
                answer++;
        }
        // end

        return answer;
    }
    public (int, int) Task_3_7()
    {
        int answer1 = 0, answer3 = 0, n = int.Parse(Console.ReadLine());

        // code here
        
        // end

        return (answer1, answer3);
    }
    public (int, double) Task_3_8()
    {
        int answer = 0, n = 0;
        double answerLength = double.MaxValue;

        // code here

        // end

        return (answer, answerLength);
    }
    public double Task_3_9()
    {
        double answer = double.MaxValue;
        int n = int.Parse(Console.ReadLine());

        // code here
        for (int i = 1; i <= n; i++)
                {
                    double x = double.Parse(Console.ReadLine());
                    if (answer < x)
                        answer = (int)x;
                }
        // end

        return answer;
    }
    public int Task_3_10()
    {
        int answer = 0, n = 0;

        // code here;
        
        // end

        return answer;
    }
    public (int, double) Task_3_11()
    {
        int answer = 0;
        double avg = 0.0;
        double k = 0;
        int n=int.Parse(Console.ReadLine());
        // code here;
        
        // end

        return (answer, avg);
    }
    #endregion
}
