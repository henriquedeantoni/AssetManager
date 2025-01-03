﻿namespace AssetManager.Services
{
    public class MetadataPagination
    {
        public int TotalItemCount { get; set; }
        public int TotalPageCount { get; set; }
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }

        public MetadataPagination(int totalItemCount, int currentPage, int pageSize)
        {
            TotalItemCount = totalItemCount;
            CurrentPage = currentPage;
            PageSize = pageSize;
            TotalPageCount = (int)Math.Ceiling(totalItemCount / (double)pageSize);
        }   
    }
}
