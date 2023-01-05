using System;
using System.Text.RegularExpressions;

namespace LogicExam
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = string.Empty;

            while (message != "0")
            { 
                Console.WriteLine("Enter message: (0 for exit)");
                message= Console.ReadLine();
                if (message == "0")
                    return;
                Console.WriteLine(EncodeText(message));
                Console.ReadLine();
            }
            return;
            string EncodeText(string message)
            {

                string messsageWitoutSpaces = message.Replace(" ", "");                
                int columns = (int)Math.Round(Math.Sqrt(messsageWitoutSpaces.Length), MidpointRounding.ToPositiveInfinity);
                int rows =(int) Math.Round(Math.Round((decimal)messsageWitoutSpaces.Length,MidpointRounding.ToPositiveInfinity),MidpointRounding.ToEven);
                float rowsCounttemp = (float)rows / (float)columns;
                int rowsCount = (int)Math.Round(rowsCounttemp, MidpointRounding.ToPositiveInfinity);
                string[,] tempResult = new string[rowsCount, columns];
                string finalResult = string.Empty;
                int r = 0;
                int c = 0;

                foreach (char letter in messsageWitoutSpaces)
                {
                    tempResult[r, c] = letter.ToString();
                    if (c == columns-1)
                    {
                        r = r + 1;
                        c = 0;
                    }
                    else
                    {
                        c = c + 1;
                    }

                }
                int irow = 0;
                int icol = 0;
                for (r = 0; r < rows - 1; r++)
                {
                    finalResult += tempResult[irow, icol];
                    if (irow == rowsCount - 1)
                    {
                        icol = icol + 1;
                        irow = 0;
                        finalResult = finalResult + " ";
                    }
                    else {
                        irow = irow + 1;
                    }
                    

                }

                return finalResult;
            }

        }


       

    }



}
