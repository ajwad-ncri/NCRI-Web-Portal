//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NCRI_WEBPORTALFORMISC.Models.DBMODEL
{
    using System;
    using System.Collections.Generic;
    
    public partial class ExcelSheetLog
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ExcelSheetLog()
        {
            this.CustomersDatas = new HashSet<CustomersData>();
        }
    
        public int Id { get; set; }
        public string BankName { get; set; }
        public string ExcelFileName { get; set; }
        public string FilePath { get; set; }
        public string ExcelSheetLogKey { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomersData> CustomersDatas { get; set; }
    }
}
