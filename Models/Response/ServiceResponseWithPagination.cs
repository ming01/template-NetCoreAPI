using NetCoreAPI.DTOs;

namespace NetCoreAPI.Models
{
    public class ServiceResponseWithPagination<T> : ServiceResponse<T>
    {
        public double TotalAmountRecords { get; set; }
        public double TotalAmountPages { get; set; }
        public double CurrentPage { get; set; }
        public double RecordsPerPage { get; set; }

        public int PageIndex { get; set; }
    }

    public static class ResponseResultWithPagination
    {
        public static ServiceResponseWithPagination<T> Success<T>(T data, PaginationResultDto paginationResult, string message = "")
        {
            return new ServiceResponseWithPagination<T>
            {
                Data = data,
                Message = message,
                TotalAmountRecords = paginationResult.TotalAmountRecords,
                TotalAmountPages = paginationResult.TotalAmountPages,
                CurrentPage = paginationResult.CurrentPage,
                RecordsPerPage = paginationResult.RecordsPerPage,
                PageIndex = paginationResult.PageIndex
            };
        }

        public static ServiceResponseWithPagination<T> Success<T>(T data, PaginationResultDto paginationResult)
        {
            return new ServiceResponseWithPagination<T>
            {
                Data = data,
                TotalAmountRecords = paginationResult.TotalAmountRecords,
                TotalAmountPages = paginationResult.TotalAmountPages,
                CurrentPage = paginationResult.CurrentPage,
                RecordsPerPage = paginationResult.RecordsPerPage,
                PageIndex = paginationResult.PageIndex
            };
        }

        public static ServiceResponseWithPagination<T> Failure<T>(string message) where T : class
        {
            return new ServiceResponseWithPagination<T>
            {
                Data = null,
                IsSuccess = false,
                Message = message
            };
        }
    }
}