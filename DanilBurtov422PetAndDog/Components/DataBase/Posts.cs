//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DanilBurtov422PetAndDog.Components.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Posts
    {
        public int id { get; set; }
        public Nullable<int> idPet { get; set; }
        public Nullable<int> idRate { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> DateNTime { get; set; }
        public byte[] Image { get; set; }
    
        public virtual Pet Pet { get; set; }
        public virtual PostRate PostRate { get; set; }
    }
}
