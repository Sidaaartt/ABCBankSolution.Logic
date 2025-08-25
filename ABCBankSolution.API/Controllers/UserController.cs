using ABCBankSolution.API.DTO;
using ABCBankSolution.Logic.Services;
using Microsoft.AspNetCore.Mvc;

namespace ABCBankSolution.API.Controllers
{
    [ApiController]
    [Route("api/user")]
    public class UserController : ControllerBase
    {
        private readonly UserService userService = new UserService();
        private readonly BankService bankService = new BankService();

        [HttpPost("login")]
        public IActionResult Login(UserLoginRequest request)
        {
            bool isValid = userService.ValidateUser(request.Email, request.Password);
            if (isValid)
                return Ok(new { success = true, message = "Login successful" });
            else
                return Unauthorized(new { success = false, message = "Invalid credentials" });
        }

        [HttpPost("create")]
        public IActionResult Create(CreateAccountRequest request)
        {
            bool created = bankService.CreateAccount(request.Email, request.Password, request.InitialBalance);
            if (created)
                return Ok(new { success = true, message = "Account created successfully" });
            else
                return BadRequest(new { success = false, message = "Account creation failed. Email may already exist or input is invalid." });
        }

        [HttpGet("balance")]
        public IActionResult GetBalance(string email)
        {
            var balance = bankService.GetBalance(email);
            if (balance.HasValue)
                return Ok(new { success = true, balance });
            else
                return NotFound(new { success = false, message = "Account not found" });
        }

        [HttpPost("deposit")]
        public IActionResult Deposit(TransactionRequest request)
        {
            bool success = bankService.Deposit(request.Email, request.Amount);
            if (success)
                return Ok(new { success = true, message = "Deposit successful" });
            else
                return BadRequest(new { success = false, message = "Deposit failed. Check email or amount." });
        }

        [HttpPost("withdraw")]
        public IActionResult Withdraw(TransactionRequest request)
        {
            bool success = bankService.Withdraw(request.Email, request.Amount);
            if (success)
                return Ok(new { success = true, message = "Withdrawal successful" });
            else
                return BadRequest(new { success = false, message = "Withdrawal failed. Check balance or email." });
        }
    }
}
