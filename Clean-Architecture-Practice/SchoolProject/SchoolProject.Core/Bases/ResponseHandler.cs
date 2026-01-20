using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Bases
{
    public class ResponseHandler
    {
        // 1. Delete
        public Response<T> Deleted<T>(string message = "Deleted Successfully")
        {
            return new Response<T>(message) // بنستخدم الكونستركتور المناسب
            {
                StatusCode = System.Net.HttpStatusCode.OK,
                Succeeded = true
            };
        }

        // 2. Success (Get Data)
        // عدلت الرسالة عشان تبقى عامة، او تاخدها من الباراميتر
        public Response<T> Success<T>(T entity, object? Meta = null, string message = "Operation Succeeded")
        {
            return new Response<T>(entity, message)
            {
                StatusCode = System.Net.HttpStatusCode.OK,
                Succeeded = true,
                Meta = Meta
            };
        }

        // 3. Unauthorized
        public Response<T> Unauthorized<T>(string message = "UnAuthorized")
        {
            return new Response<T>(message)
            {
                StatusCode = System.Net.HttpStatusCode.Unauthorized,
                Succeeded = false
            };
        }

        // 4. Bad Request
        public Response<T> BadRequest<T>(string message = "Bad Request")
        {
            return new Response<T>(message)
            {
                StatusCode = System.Net.HttpStatusCode.BadRequest,
                Succeeded = false
            };
        }

        // 5. Not Found
        public Response<T> NotFound<T>(string message = "Not Found")
        {
            return new Response<T>(message)
            {
                StatusCode = System.Net.HttpStatusCode.NotFound,
                Succeeded = false
            };
        }

        // 6. Created (Add)
        public Response<T> Created<T>(T entity, object? Meta = null, string message = "Added Successfully")
        {
            return new Response<T>(entity, message)
            {
                StatusCode = System.Net.HttpStatusCode.Created,
                Succeeded = true,
                Meta = Meta
            };
        }
    }
}
