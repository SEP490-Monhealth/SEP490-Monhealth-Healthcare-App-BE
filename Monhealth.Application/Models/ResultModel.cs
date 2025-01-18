namespace Monhealth.Application.Models
{
    public class ResultModel
    {
        public bool Success { get; set; }
        public int Status { get; set; }
        public object? Data { get; set; }
        public string? Message { get; set; }
        //public override string ToString() => JsonSerializer.Serialize(this);
        public static ResultModel Succeed(object data = null!,string message = "")
            => new()
            {
                Data = data,
                Status = 200,
                Success = true,
                Message = message
            };
        public static ResultModel Fail(string message="")
            => new(){
                Data = null!,
                Success = false,
                Status = 404,
                Message = message
            };
    }
}
