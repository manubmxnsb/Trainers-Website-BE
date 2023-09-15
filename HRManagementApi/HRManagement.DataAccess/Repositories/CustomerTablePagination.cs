﻿namespace HRManagement.DataAccess.Repositories
{
    public class CustomerTablePagination
    {
        public int TotalPageCount { get; set; }
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }

        public CustomerTablePagination(
            int totalItemCount, int pageSize, int currentPage)
        {
            PageSize = pageSize;
            CurrentPage = currentPage;
            TotalPageCount = (int)Math.Ceiling(totalItemCount / (double)PageSize);
        }
    }
}