//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZzukBotAuthenticationServer.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class core_moderator_logs
    {
        public long id { get; set; }
        public Nullable<long> member_id { get; set; }
        public Nullable<int> ctime { get; set; }
        public string note { get; set; }
        public string ip_address { get; set; }
        public string appcomponent { get; set; }
        public string module { get; set; }
        public string controller { get; set; }
        public string @do { get; set; }
        public string lang_key { get; set; }
        public string @class { get; set; }
        public Nullable<long> item_id { get; set; }
        public string member_name { get; set; }
    }
}
