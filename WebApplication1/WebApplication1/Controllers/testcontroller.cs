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

            string total = Join("hal", "lo");
            return total;
        }
        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }

        // Put your methods over here


        public static string Join(string firstStr, string secondStr)
        {
            return firstStr + secondStr;
        }
    }
}

