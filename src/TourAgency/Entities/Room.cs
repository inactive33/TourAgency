//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TourAgency.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Room
    {
        public int ID_room { get; set; }
        public int Hotel_id { get; set; }
        public int Spot_number { get; set; }
        public int Price_per_room { get; set; }
        public int Price_per_spot { get; set; }
        public int Free_number { get; set; }
    
        public virtual Hotel Hotel { get; set; }
    }
}