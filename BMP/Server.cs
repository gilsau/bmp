//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BMP
{
    using System;
    using System.Collections.Generic;
    
    public partial class Server
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string IPaddress { get; set; }
        public Nullable<int> DocRetentionPeriod { get; set; }
        public string SpaceAvailable { get; set; }
        public string SpaceUsed { get; set; }
        public string StorePath { get; set; }
        public Nullable<int> SaveDays { get; set; }
    }
}
