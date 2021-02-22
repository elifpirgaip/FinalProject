using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Category:IEntity
    {
        //Çıplak Class Kalmasın (Classlarda herhangi bir inheritance veya interface implementasyonu almıyorsa ilerde sıkıntı yaşama ihtimalimiz yüksektir.
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
