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
    
    public partial class core_upgrade_history
    {
        public int upgrade_id { get; set; }
        public int upgrade_version_id { get; set; }
        public string upgrade_version_human { get; set; }
        public int upgrade_date { get; set; }
        public int upgrade_mid { get; set; }
        public string upgrade_app { get; set; }
    }
}