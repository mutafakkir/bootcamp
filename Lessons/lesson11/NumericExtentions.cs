using System;

namespace lesson11
{
    public class NumericExtentions
    {
        public static String ones(String Number)  
        {  
            int _Number = Convert.ToInt32(Number);  
            String name = "";  
            switch (_Number)  
            {  
                case 1:  
                    name = "Bir";  
                    break;  
                case 2:  
                    name = "Ikki";  
                    break;  
                case 3:  
                    name = "Uch";  
                    break;  
                case 4:  
                    name = "To'rt";  
                    break;  
                case 5:  
                    name = "Besh";  
                    break;  
                case 6:  
                    name = "Olti";  
                    break;  
                case 7:  
                    name = "Yetti";  
                    break;  
                case 8:  
                    name = "Sakkiz";  
                    break;  
                case 9:  
                    name = "To'qiz";  
                    break;  
            }  
            return name;  
        }

        private static String tens(String Number)  
        {  
            int _Number = Convert.ToInt32(Number);  
            String name = null;  
            switch (_Number)  
            {  
                case 10:  
                    name = "On";  
                    break;  
                case 11:  
                    name = "Onbir";  
                    break;  
                case 12:  
                    name = "Onikki";  
                    break;  
                case 13:  
                    name = "Onuch";  
                    break;  
                case 14:  
                    name = "Onto'rt";  
                    break;  
                case 15:  
                    name = "Onbesh";  
                    break;  
                case 16:  
                    name = "Onolti";  
                    break;  
                case 17:  
                    name = "Onyetti";  
                    break;  
                case 18:  
                    name = "Onsakkiz";  
                    break;  
                case 19:  
                    name = "Onto'qiz";  
                    break;  
                case 20:  
                    name = "Yigirma";  
                    break;  
                case 30:  
                    name = "O'ttiz";  
                    break;  
                case 40:  
                    name = "Qiriq";  
                    break;  
                case 50:  
                    name = "Ellik";  
                    break;  
                case 60:  
                    name = "Otmish";  
                    break;  
                case 70:  
                    name = "Yetmish";  
                    break;  
                case 80:  
                    name = "Sakson";  
                    break;  
                case 90:  
                    name = "Toxson";  
                    break;  
                default:  
                    if (_Number > 0)  
                    {  
                        name = tens(Number.Substring(0, 1) + "0") + " " + ones(Number.Substring(1));  
                    }  
                    break;  
            }  
            return name;  
        }

        public static String ConvertWholeNumber(String Number)  
        {  
            string word = "";  
            try  
            {  
                bool beginsZero = false;   
                bool isDone = false;    
                double dblAmt = (Convert.ToDouble(Number));  
                  
                if (dblAmt > 0)  
                {   
                    beginsZero = Number.StartsWith("0");  
        
                    int numDigits = Number.Length;  
                    int pos = 0;   
                    String place = "";  
                    switch (numDigits)  
                    {  
                        case 1:   
        
                            word = ones(Number);  
                            isDone = true;  
                            break;  
                        case 2:   
                            word = tens(Number);  
                            isDone = true;  
                            break;  
                        case 3:    
                            pos = (numDigits % 3) + 1;  
                            place = " Yuz ";  
                            break;  
                        case 4:   
                        case 5:  
                        case 6:  
                            pos = (numDigits % 4) + 1;  
                            place = " Ming ";  
                            break;  
                        case 7:    
                        case 8:  
                        case 9:  
                            pos = (numDigits % 7) + 1;  
                            place = " Million ";  
                            break;  
                        case 10:    
                        case 11:  
                        case 12:  
        
                            pos = (numDigits % 10) + 1;  
                            place = " Milliard ";  
                            break;    
                        default:  
                            isDone = true;  
                            break;  
                    }  
                    if (!isDone)  
                    {
                        if (Number.Substring(0, pos) != "0" && Number.Substring(pos) != "0")  
                        {  
                            try  
                            {  
                                word = ConvertWholeNumber(Number.Substring(0, pos)) + place + ConvertWholeNumber(Number.Substring(pos));  
                            }  
                            catch { }  
                        }  
                        else  
                        {  
                            word = ConvertWholeNumber(Number.Substring(0, pos)) + ConvertWholeNumber(Number.Substring(pos));  
                        }    
                    }  
                      
                    if (word.Trim().Equals(place.Trim())) word = "";  
                }  
            }  
            catch { }  
            return word.Trim();  
        }
    }
}