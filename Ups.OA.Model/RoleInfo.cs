//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ups.OA.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class RoleInfo
    {
        public RoleInfo()
        {
            this.R_Customer_RoleInfo = new HashSet<R_Customer_RoleInfo>();
        }
    
        public int Id { get; set; }
        public int CustomerId { get; set; }
    
        public virtual ICollection<R_Customer_RoleInfo> R_Customer_RoleInfo { get; set; }
    }
}
