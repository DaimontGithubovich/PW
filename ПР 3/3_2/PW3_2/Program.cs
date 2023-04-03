﻿namespace PW3_2
{
    class programm
    {
        static void Main()
        {
            
            Console.WriteLine("Введите текст");
            string sms = Console.ReadLine();
            SmsMessage message = new SmsMessage(sms);
            message.Displayinfo();


        }
    }
    class SmsMessage
    {
        private string Messagetext;
        public double Price;



        public SmsMessage( string smstext)
        {
            Messagetext = smstext; 
        }
        public string smstext
        {
            get { return smstext; }
            set { smstext = Normalizesms(value); }
        }

        public string Normalizesms( string value)
        {
            string S = value;
            char[] A_S = new char[S.Length];
            for (int i = 0; i < A_S.Length; i++)
            {
                A_S[i] = S[i];
            }
            if (S.Length < 65)
            {

                Console.WriteLine("Цена : "+1.5+" ");


            }
            else
            {
                if ((S.Length > 65) && (S.Length < 250))
                {
                    double n = 0;
                    for (int i = 0; i < A_S.Length - 65; i++)
                    {
                        n = n + 0.5;
                    }
                    Price = 1.5 + n;
                    Console.WriteLine("Цена : " + Price+ " ");
                    

                }
                else
                {
                    value = "";
                    double n = 0;
                    for (int i = 0; i < 250; i++)
                    {
                        value = value + Convert.ToString(A_S[i]);
                        n = n + 0.5;
                    }
                    Price = 1.5 + n;
                    Console.WriteLine("Цена : " + Price + " ");
                }
            }

            return value;
        }
        public void Displayinfo()
        {
            Console.WriteLine($"{Normalizesms(Messagetext)}");
        }
    }
}