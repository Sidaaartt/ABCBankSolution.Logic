namespace ABCBankSolution.API.DTO
{
    public class CreateAccountRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public decimal InitialBalance { get; set; }
    }
}
