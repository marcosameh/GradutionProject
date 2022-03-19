using System;
using System.Collections.Generic;
using System.Linq;

namespace App.UI.Infrastructure
{
    public class PagedList<T> : List<T>
    {
        public PagingData PagingData { get; set; } = new PagingData();

        public PagedList(IEnumerable<T> items, int count, int pageNumber, int pageSize)
        {
            PagingData.TotalCount = count;
            PagingData.PageSize = pageSize;
            PagingData.CurrentPage = pageNumber;
            PagingData.TotalPages = (int) Math.Ceiling(count / (double) pageSize);
            PagingData.FromPage = PagingData.CurrentPage - 2;
            PagingData.ToPage = PagingData.CurrentPage + 2;

            if (PagingData.FromPage <= 0)
            {
                PagingData.ToPage += 1 - PagingData.FromPage;
                PagingData.FromPage = 1;
            }

            if (PagingData.ToPage >= PagingData.TotalPages)
            {
                PagingData.ToPage = PagingData.TotalPages;
                PagingData.FromPage -= PagingData.ToPage - PagingData.TotalPages;

                if (PagingData.FromPage <= 0)
                {
                    PagingData.FromPage = 1;
                }
            }

            PagingData.FromCount = (PagingData.CurrentPage - 1) * PagingData.PageSize;

            PagingData.ToCount = PagingData.CurrentPage < PagingData.TotalPages
                ? PagingData.CurrentPage * PagingData.PageSize
                : PagingData.TotalCount;

            AddRange(items);
        }

        public static PagedList<T> Create(IQueryable<T> source, int pageNumber, int pageSize)
        {
            var count = source.Count();
            var items = source.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
            return new PagedList<T>(items, count, pageNumber, pageSize);
        }
    }

    public class PagingData
    {
        public int CurrentPage { get; set; }
        public int FromCount { get; set; }
        public int FromPage { get; set; }
        public bool HasNext => CurrentPage < TotalPages;
        public bool HasPrevious => CurrentPage > 1;
        public int PageSize { get; set; }
        public int ToCount { get; set; }
        public int ToPage { get; set; }
        public int TotalCount { get; set; }
        public int TotalPages { get; set; }

    }
}