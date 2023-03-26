namespace HotelListing.API.Exceptions
{
    internal class BadRequestException : ApplicationException
    {
        public BadRequestException(string name, object key) : base($"{name} ({key}) Got a BAD REQUEST")
        {


        }
    }
}