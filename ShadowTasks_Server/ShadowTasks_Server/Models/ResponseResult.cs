using System.ComponentModel.DataAnnotations;

namespace ShadowTasks_Server.Models
{
    public class ResponseResult<T>
    {
        [Required]
        public bool IsSuccessful { get; set; }
        public string? Message { get; set; }
        public T? Content { get; set; }

        public ResponseResult(int _index)
        {
            IsSuccessful = false;
            Message = _index switch
            {
                1 => "Something Went Wrong, Didn't Connect With the Sql Server.",
                _ => "Something Went Wrong, Please Try Again"
            };
        }

        public ResponseResult(string? _message)
        {
            IsSuccessful = false;
            Message = _message;
        }

        public ResponseResult(bool _isSuccessful, string? _message)
        {
            IsSuccessful = _isSuccessful;
            Message = _message;
        }

        public ResponseResult(bool _isSuccessful, string? _message, T? _content) : this(_isSuccessful, _message)
        {
            Content = _content;
        }

        public ResponseResult(Exception _ex)
        {
            IsSuccessful = false;
            Message = _ex.Message;
        }
    }
}
