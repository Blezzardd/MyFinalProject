﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    //Temel voidler için başlangıç
    public interface IResult
    {
        bool Success { get; }//Ekleme işlemi başarılı yada hata gibisinden yönlendirme
        string Message { get; }//Buda mesaj vurgulamak için 
    }
}
