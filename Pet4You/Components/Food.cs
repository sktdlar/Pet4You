//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pet4You.Components
{
    using System;
    using System.Collections.Generic;
    
    public partial class Food
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Food()
        {
            this.FoodTimeTable = new HashSet<FoodTimeTable>();
        }
    
        public int Id { get; set; }
        public string TitleFood { get; set; }
        public int CalorieCount { get; set; }
        public int ProteinCount { get; set; }
        public int FatCount { get; set; }
        public int CarbohydratesCount { get; set; }
        public int Brand_Id { get; set; }
    
        public virtual FoodBrand FoodBrand { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FoodTimeTable> FoodTimeTable { get; set; }
    }
}
