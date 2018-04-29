using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_VeryLong
{     //VeryLong
    class CVeryLong
    {
        private static uint size = 1000;   //максимальное число разрядов
        public static uint Size
        {
            get { return size; }
            private set { size = value; }
        }

        private int vlen;  //длина строки
        public int Vlen
        {
            get { return vlen; }
            private set { vlen = value; }
        }
       
        private char[] vlstr;//число как строка
        public char[] Vlstr
        {
            get { return vlstr; }
            private set { vlstr = value; }
        } 

        public CVeryLong()  //конструктор без аргументов
        {
            vlen = 0;
            vlstr = new char[size];
            vlstr[0] = '\0';
        }

        public CVeryLong(char[] s) //АХТУНГ! Передавать "перевернутые" массивы.
        {                          //Array.Reverse(массив); перевернуть
            vlstr = new char[size];
            vlen = s.Length;
            Array.Copy(s, vlstr, s.Length); //Array.Copy(Источник, Куда, Длина)
        }

        public CVeryLong(ulong num)
        {
            string strNum = num.ToString();
            vlstr = strNum.ToCharArray();
            Array.Reverse(vlstr);
            vlen = vlstr.Length;  
        }
        
        public string ReturnVeryLongLikeStr()  //Вернуть число как строку. В нормальном порядке.
        {
            char[] toReturn = new char[vlen];
            string str = string.Empty;
            Array.Copy(vlstr, toReturn, vlen);
            Array.Reverse(toReturn);

            foreach (char c in toReturn)
            {
                str += c;
            }

            return str; 
        }

        public char[] ReturnCharArray() //Вернуть массив. В перевернутой последовательности
        {
            return vlstr;
        }

        public static CVeryLong operator +(CVeryLong l, CVeryLong d)  //Дисторшн операции "+" для класса
        {
            char[] temp = new char[size];
            int j;

            //ищем самое длинное число.
            int maxlen = (l.vlen > d.vlen) ? l.vlen : d.vlen;
            //maxlen += 3;
            int carry = 0;
            for (j = 0; j < maxlen; j++)
            {
                int d1L = (j > l.vlen - 1) ? 0 : l.vlstr[j] - '0';
                int d2D = (j > d.vlen - 1) ? 0 : d.vlstr[j] - '0';
                int digitsum = d1L + d2D + carry;
                if (digitsum >= 10)
                {
                    digitsum -= 10;
                    carry = 1;
                }
                else
                    carry = 0;
                char ch = (char)digitsum;
                ch += '0';
                temp[j] = ch;
            }
                if (carry == 1)
                    temp[j++] = '1';
                temp[j] = '\0';

            char[] tt = new char[j];
            Array.Copy(temp, tt, j); 

            CVeryLong vl = new CVeryLong(tt);
            return vl;
        }

        public static CVeryLong operator *(CVeryLong l, CVeryLong d) //Дисторшн операции "*" для класса
        {
            CVeryLong pprod = new CVeryLong(0); //произведние одного разряда
            CVeryLong tempsum = new CVeryLong(0); //текущая сумма
            for(int j = 0; j<d.vlen; j++)
            {
                int digit = d.vlstr[j] - '0';
                pprod = Muldigit(digit, l);
                for (int k = 0; k < j; k++)
                    pprod = Mult10(pprod);
                tempsum = tempsum + pprod;
            }
            return tempsum;
        }

        private static CVeryLong Muldigit(int d2, CVeryLong l) //утножить число на аргумент(цифру)
        {
            char[] temp = new char[size];
            int j;
            int carry = 0;
            for(j = 0; j< l.vlen; j++)
            {
                int d1 = l.vlstr[j] - '0';
                int digitprod = d1 * d2;
                digitprod += carry;
                if (digitprod >= 10)
                {
                    carry = digitprod / 10;
                    digitprod -= carry * 10;
                }
                else
                    carry = 0;
                char ch = (char)digitprod;
                ch += '0';
                temp[j] = ch;
            }
            if (carry != 0)
            {
                char c = (char)carry;
                c += '0';
                temp[j++] = c;
            }

            temp[j] = '\0';

            char[] dd = new char[j];
            Array.Copy(temp, dd, j);
            CVeryLong vl = new CVeryLong(dd);
            return vl;
        }

        private static CVeryLong Mult10(CVeryLong l) //умножить аргумент на 10 
        {
            char[] temp = new char[size];
            for (int j = l.vlen; j >= 0; j--)
                temp[j + 1] = l.vlstr[j];
            temp[0] = '0';
            temp[l.vlen + 1] = '\0';

            char[] c = new char[l.vlen + 1];
            Array.Copy(temp, c, l.vlen + 1);
            CVeryLong vl = new CVeryLong(c);
            return vl;
        }

    }
}
