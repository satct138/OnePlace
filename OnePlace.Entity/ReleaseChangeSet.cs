//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnePlace.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class ReleaseChangeSet
    {
        public System.Guid ReleaseID { get; set; }
        public string ChangeSetNumber { get; set; }
        public string Comment { get; set; }
    
        public virtual Release Release { get; set; }
    }
}
