using IR.Domain.Constants;

namespace IR.Services.Resource.Response
{
    public class ApiResponse<T>
    {
        public bool Succeeded { get; set; }
        public string Message { get; set; } = string.Empty;
        public T? Data { get; set; }

        public static ApiResponse<T> Fail(string errorMessage)
        {
            return new ApiResponse<T> { Succeeded = false, Message = errorMessage };
        }

        public static ApiResponse<T> Success(T data)
        {
            return new ApiResponse<T> { Succeeded = true, Data = data, Message = SuccessMessage.SuccessRequest };
        }

        public static ApiResponse<T> Success(T data, string successMessage)
        {
            return new ApiResponse<T> { Succeeded = true, Data = data, Message = successMessage };
        }
    }
}
