
using Microsoft.AspNetCore.Mvc;

namespace HerediaJ_MC_2_NumbersEndpoint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NumbersController : ControllerBase
    {
        
        public List<string> numbers = new();

        [HttpPost]
        [Route("SumNumbers/{firstNum}/{secondNum}")]
        public List<string> TotalSum(int firstNum, int secondNum)
        {
            string total = "The sum of " + firstNum.ToString() + " and " + secondNum.ToString() + " is equal to " + (firstNum + secondNum).ToString();
            numbers.Add(total);
            return numbers;
        }

    }
}