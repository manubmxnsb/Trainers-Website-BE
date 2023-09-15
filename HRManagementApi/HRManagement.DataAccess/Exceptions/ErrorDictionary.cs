using System.Net;

namespace HRManagement.DataAccess.Exceptions
{
    public class ErrorDictionary
    {
        public static readonly Dictionary<HttpStatusCode, int> ErrorCode = new Dictionary<HttpStatusCode, int>
        {
            { HttpStatusCode.BadRequest, 400 },
            { HttpStatusCode.NotFound, 404 },
            { HttpStatusCode.InternalServerError, 500 },
        };
    }
}