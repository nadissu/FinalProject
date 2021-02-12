using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Category:IEntity   
    {
        //Çıplak Class Kalmasın eğer herhangi bir class inheritens interface implementasyonu almıyorsan problem yaşayacaksın demektir.
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
