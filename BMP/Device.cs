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
    
    public partial class Device
    {
        public int Id { get; set; }
        public string DevNo { get; set; }
        public string PolNo { get; set; }
        public System.DateTime LastConnected { get; set; }
        public int VideosLastUploaded { get; set; }
        public string DeviceStatus { get; set; }
        public Nullable<int> DeviceStatusProgress { get; set; }
    }
}
