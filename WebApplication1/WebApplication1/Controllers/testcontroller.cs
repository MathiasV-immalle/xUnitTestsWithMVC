using Microsoft.AspNetCore.Mvc;
using System;
using System.Text.Encodings.Web;

namespace WebApplication1.Controllers
{
    public class testcontroller : Controller
    {
        // 
        // GET: /HelloWorld/

        public string Index()
        {

            // Make some variables and use your methods. Return your final variable and check it on localhost://.../controllername - "controller".
            // Feel free to test 'em all, just change the return value.

            string TwoWordsJoined = JoinTwoWords("hal", "lo");
            string amountOfDNAParts = ClashCountDNAParts("ATGCTTCAGAAAAGGTCAGCG");
            string AmountYouNeedToBorrow = BorrowMoney("3 17 4");

            return AmountYouNeedToBorrow;
        }
        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }

        // Put your methods over here


        public static string JoinTwoWords(string firstStr, string secondStr)
        {
            return firstStr + secondStr;
        }

        public static string BorrowMoney(string CostAvailablemoneyAmountyouwanttobuy)
        {
            string[] inputs = CostAvailablemoneyAmountyouwanttobuy.Split(' ');
            int MMM = int.Parse(inputs[0]);
            int AAA = int.Parse(inputs[1]);
            int NNN = int.Parse(inputs[2]);

            int costs = 0;

            for (int x = 1; x <= NNN; x++)
            {

                costs += x * MMM;

            }

            int borrow = costs - AAA;

            if (borrow < 0)
            {

                borrow = 0;

            }

            return $"Borrowed: {borrow} coins.";
        }

        public static string ClashCountDNAParts(string DNA)
        {
            int aantalA = 0;
            int aantalC = 0;
            int aantalG = 0;
            int aantalT = 0;

            foreach (char x in DNA)
            {

                if (x == 'A')
                {
                    aantalA += 1;
                }
                else if (x == 'C')
                {
                    aantalC += 1;
                }
                else if (x == 'G')
                {
                    aantalG += 1;
                }
                else if (x == 'T')
                {
                    aantalT += 1;
                }
            }

            return $"Amount A:{aantalA} Amount C:{aantalC} Amount G:{aantalG} Amount T:{aantalT}.";
        }
    }
}

