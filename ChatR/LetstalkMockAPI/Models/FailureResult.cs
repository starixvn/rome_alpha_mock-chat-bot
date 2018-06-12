namespace LetstalkMockAPI.Models
{
    public class FailureResult : Result
    {
        public FailureResult()
        {
            status = 0;
            message = "failure";
        }
    }
}
