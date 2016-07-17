using Numeric_Sequence_Calculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Numeric_Sequence_Calculator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new MagicNumber());
        }

        [HttpPost]
        public ActionResult CalculateSequence(int MagicNumber)
        {
            SequenceResult model = new SequenceResult();
            model.MagicNumber = MagicNumber;
            model.AllNumbersUpTo = GetNumbersUpTo(model.MagicNumber);
            model.OddNumbersUpTo = GetOddNumbersFromList(model.AllNumbersUpTo);
            model.EvenNumbersUpTo = GetEvenNumbersFromList(model.AllNumbersUpTo);
            model.AllNumbersConditional = GetConditionalNumbersUpTo(model.AllNumbersUpTo);
            model.FibonacciNumbersUpTo = GetFibonacciSequenceUpTo(1, model.MagicNumber);
            return PartialView("_sequenceResults", model);
        }

        public List<int> GetFibonacciSequenceUpTo(int startNumber,int magicNumber)
        {
            var returnList = new List<int>();
            int calculation=0;
            for (int i = startNumber; calculation<=magicNumber;i++)
            {
                if (returnList.Count>1)
                {
                    calculation = (returnList[i - 2] + returnList[i - 3]);
                    if (calculation<=magicNumber)
                        returnList.Add(calculation);
                }
                else
                {
                    returnList.Add(startNumber);
                }
            }
            return returnList;
        }

        public List<string> GetConditionalNumbersUpTo(List<int> numberList)
        {
            //All numbers up to and including the number entered, except when,
            var returnList = new List<string>();
            foreach (var number in numberList.OrderBy(x => x))
            {
                if (number % 3 == 0)
                {
                    //A number is a multiple of both 3 and 5 output Z
                    if (number % 5 == 0)
                        returnList.Add("Z");
                    //.1 A number is a multiple of 3 output C
                    else
                        returnList.Add("C");
                }
                //2 A number is a multiple of 5 output E
                else if (number % 5 == 0)
                    returnList.Add("E");
                else
                    returnList.Add(number.ToString());
            }
            return returnList;
        }

        public List<int> GetEvenNumbersFromList(List<int> numberList)
        {
            var returnList = numberList.OrderBy(x=> x).Where(x => x % 2 == 0).ToList();
            return returnList;
        }

        public List<int> GetOddNumbersFromList(List<int> numberList)
        {
            var returnList = numberList.OrderBy(x => x).Where(x => x % 2 != 0).ToList();
            return returnList;
        }

        public List<int> GetNumbersUpTo(int magicNumber)
        {
            List<int> returnList = new List<int>(magicNumber);
            for (int currentCount = 1; currentCount <= magicNumber; currentCount++)
            {
                returnList.Add(currentCount);
            }
            return returnList;
        }
    }
}