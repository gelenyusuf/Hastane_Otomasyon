﻿using Project.ENTİTİES.Modals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.GenericRepository.IntRep
{
   public  interface IRepository<T> where T:BaseEntity
    {
        List<T> GetActives();
        List<T> GetPasssives();

        List<T> GetModifies();

        List<T> GetAll();

        void Add(T item);
        void AddRange(List<T> list);

        void Update(T item);
        void UpdateRange(List<T> list);

        void Delete(T item);
        void DeleteRange(List<T> list);

        void Destroy(T item);
        void DestroyRange(List<T> list);

        List<T> Where(Expression<Func<T,bool>>exp);
        T FirstOrDefault(Expression<Func<T, bool>> exp);

        bool Any(Expression<Func<T, bool>> exp);

        IQueryable<X> Select<X>(Expression<Func<T, X>> exp);

        T Find(int id);

        List<T> GetLastDatas(int count=1);

        List<T> GetFirstDatas(int count=1);

        List<T> GetDatas(int count=1);
    }
}
