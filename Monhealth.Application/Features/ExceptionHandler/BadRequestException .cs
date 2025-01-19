namespace Monhealth.Application.Features.ExceptionHandler
{
    public class BadRequestException : Exception
    {
        public BadRequestException(string message) : base(message)
        {
        }
    }

}