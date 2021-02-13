using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using NetCoreAPI.DTOs;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreAPI.Helpers
{
    public static class HttpContextExtensions
    {
        public async static Task<PaginationResultDto> InsertPaginationParametersInResponse<T>(this HttpContext httpContext, IQueryable<T> queryable, int recordsPerPage, int currentPage)
        {
            if (httpContext == null) { throw new ArgumentNullException(nameof(httpContext)); }

            double totalAmountRecords = await queryable.CountAsync();
            double totalAmountPages = Math.Ceiling(totalAmountRecords / recordsPerPage);
            int pageIndex = currentPage - 1;

            PaginationResultDto resultDto = new PaginationResultDto()
            {
                TotalAmountRecords = totalAmountRecords,
                TotalAmountPages = totalAmountPages,
                CurrentPage = currentPage,
                RecordsPerPage = recordsPerPage,
                PageIndex = pageIndex
            };

            //Add Pagination to Header

            //httpContext.Response.Headers.Add("totalAmountRecords", totalAmountRecords.ToString());
            //httpContext.Response.Headers.Add("totalAmountPages", totalAmountPages.ToString());
            //httpContext.Response.Headers.Add("currentPage", currentPage.ToString());
            //httpContext.Response.Headers.Add("recordsPerPage", recordsPerPage.ToString());
            //httpContext.Response.Headers.Add("pageIndex", pageIndex.ToString());

            return resultDto;
        }
    }
}