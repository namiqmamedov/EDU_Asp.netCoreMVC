using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.ViewModels
{
    public class PageNationList<TEntity> : List<TEntity>
    {
        public PageNationList(IQueryable<TEntity> entities, int pageIndex, int totalPages)
        {
            TotalPages = totalPages;
            PageIndex = pageIndex;

            Start = PageIndex - 2;
            End = PageIndex + 2;

            if (Start <= 0)
            {
                End = End - (Start - 1);
                Start = 1;
            }

            if (End > TotalPages)
            {
                End = TotalPages;
                if (End > 3)
                {
                    Start = End - 2;
                }
            }
             
            AddRange(entities);
        }

        public int TotalPages { get; }
        public int PageIndex  { get;  }

        public bool HasNext => PageIndex < TotalPages;
        public bool HasPrev => PageIndex > 1;

        public int Start { get; }
        public int End { get; }

        public static PageNationList<TEntity> Create(IQueryable<TEntity> entities, int pageIndex, int pageItemCount)
        {
            int totalPages = (int)Math.Ceiling((decimal)entities.Count() / 4);


            if (pageIndex < 1 || pageIndex > totalPages)
            {
                pageIndex = 1;
            }

            entities = entities
          .Skip((pageIndex - 1) * pageItemCount)
          .Take(pageItemCount);


            return new PageNationList<TEntity>(entities,pageIndex,totalPages);

        }
    }
}
