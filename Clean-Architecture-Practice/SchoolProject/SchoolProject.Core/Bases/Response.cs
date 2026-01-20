using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Bases
{
    public class Response<T>
    {
        // Constructor 1: في حالة الـ Success ومعانا Data
        public Response(T data, string? message = null)
        {
            Succeeded = true;
            Message = message;
            Data = data;
        }

        // Constructor 2: في حالة الـ Error (مفيش data)
        public Response(string message)
        {
            Succeeded = false;
            Message = message;
        }

        // Constructor 3: عام
        public Response(string message, bool succeeded)
        {
            Succeeded = succeeded;
            Message = message;
        }

        // لازم نخليهم Nullable (?) عشان نتجنب الـ Warnings
        public HttpStatusCode StatusCode { get; set; }
        public object? Meta { get; set; }

        public bool Succeeded { get; set; }
        public string? Message { get; set; } // ممكن ميكونش فيه رسالة
        public List<string>? Errors { get; set; }
        public T? Data { get; set; } // ممكن تكون null في حالة الخطأ
    }

}
