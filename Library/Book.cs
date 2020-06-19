//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library
{
    using System;
    using System.Collections.Generic;
    
    public partial class Book
    {
        public int BookID { get; set; }
        public string BookName { get; set; }
        public string Autor { get; set; }
        public int FK_GENRE { get; set; }
        public int FK_Section { get; set; }
        public int FK_BookLocation { get; set; }
        public Nullable<int> FK_RentID { get; set; }
    
        public virtual BookLocation BookLocation { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual Rent Rent { get; set; }
        public virtual Section Section { get; set; }
    }
}
