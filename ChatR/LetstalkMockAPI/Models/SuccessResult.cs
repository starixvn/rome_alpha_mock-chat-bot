namespace LetstalkMockAPI.Models
{
    public class SuccessResult : Result
    {
        public SuccessResult()
        {
            status = 1;
            message = "success";
        }
    }
}
