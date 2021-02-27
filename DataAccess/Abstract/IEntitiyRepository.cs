using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    // Generic constraint : generic kısıtlama.
    // class : referans tip olabilir anlamına gelir, aşağıdaki "T:class" ifadesi.
    // T:class,IEntity : IEntity ya da IEntity implemente eden bir nesne olabilir anlamına gelir.
    // T:class, IEntity, new() : newlenebilir olmalı anlamına geldiğinden ve interface'ler new'lenemediğinden, IEntity'i kullandığımızda hata verir.
    // Böylelikle sistemimiz yalnızca veritabanı nesneleri ile çalışan bir repository oldu. 
    public interface IEntitiyRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null); // filtremeler yapabilmek için linq.expression kütüphanesini eklemeliyiz.
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
