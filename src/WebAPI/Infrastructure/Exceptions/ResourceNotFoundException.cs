using System;

namespace WebAPI.Infrastructure.Exceptions
{
    public class ResourceNotFoundException : Exception
    {
        public ResourceNotFoundException() { }
        public ResourceNotFoundException(string message) : base(message) { }
        public ResourceNotFoundException(string message, Exception innerException) : base(message, innerException)
        { }

        public ResourceNotFoundException(string name, object key)
            : base($"Resource \"{name}\" ({key}) was not found.")
        {
        }
    }
}
