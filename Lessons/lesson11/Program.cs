using System;

namespace lesson11
{
    class Program
    {
        static void Main(string[] args)  
        {  
            string isNegative = "";  
            try  
            {   
                string number = Console.ReadLine();  
                number = Convert.ToDouble(number).ToString();  
        
                if (number.Contains("-"))  
                {  
                    isNegative = "Minus ";  
                    number = number.Substring(1, number.Length - 1);  
                }  
                if (number == "0")  
                {  
                    Console.WriteLine("Nol");  
                }  
                else  
                {  
                    Console.WriteLine("{0}", isNegative + ConvertToWords(number));  
                }  
                Console.ReadKey();  
            }  
            catch (Exception ex)  
            {  
                Console.WriteLine(ex.Message);  
            }  
        }
        private static String ConvertToWords(String numb)  
        {  
            String val = "", wholeNo = numb, points = "", andStr = "", pointStr = "";  
            String endStr = "";  
            try  
            {  
                int decimalPlace = numb.IndexOf(".");  
                if (decimalPlace > 0)  
                {  
                    wholeNo = numb.Substring(0, decimalPlace);  
                    points = numb.Substring(decimalPlace + 1);  
                    if (Convert.ToInt32(points) > 0)  
                    {  
                        andStr = "and";    
                        endStr = "Paisa " + endStr;  
                        pointStr = ConvertDecimals(points);  
                    }  
                }  
                val = String.Format("{0} {1} {2} {3}", NumericExtentions.ConvertWholeNumber(wholeNo).Trim(), andStr, pointStr, endStr);  
            }  
            catch { }  
            return val;  
        }
        private static String ConvertDecimals(String number)  
        {  
            String cd = "", digit = "", engOne = "";  
            for (int i = 0; i < number.Length; i++)  
            {  
                digit = number[i].ToString();  
                if (digit.Equals("0"))  
                {  
                    engOne = "Zero";  
                }  
                else  
                {  
                    engOne = NumericExtentions.ones(digit);  
                }  
                cd += " " + engOne;  
            }  
            return cd;  
        }   
        static void Main1(string[] args)
        {
            var name = "xusan";

            name =  name.Capitalize();
            Console.WriteLine($"{name}");
        }
    }
}