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
    
    public partial class core_groups
    {
        public long g_id { get; set; }
        public Nullable<bool> g_view_board { get; set; }
        public Nullable<bool> g_mem_info { get; set; }
        public Nullable<bool> g_use_search { get; set; }
        public Nullable<bool> g_edit_profile { get; set; }
        public Nullable<bool> g_edit_posts { get; set; }
        public Nullable<bool> g_delete_own_posts { get; set; }
        public Nullable<bool> g_use_pm { get; set; }
        public Nullable<bool> g_is_supmod { get; set; }
        public Nullable<bool> g_access_cp { get; set; }
        public Nullable<bool> g_append_edit { get; set; }
        public Nullable<bool> g_access_offline { get; set; }
        public Nullable<bool> g_avoid_q { get; set; }
        public Nullable<bool> g_avoid_flood { get; set; }
        public string g_icon { get; set; }
        public Nullable<long> g_attach_max { get; set; }
        public string prefix { get; set; }
        public string suffix { get; set; }
        public Nullable<int> g_max_messages { get; set; }
        public Nullable<int> g_max_mass_pm { get; set; }
        public Nullable<int> g_search_flood { get; set; }
        public Nullable<int> g_edit_cutoff { get; set; }
        public string g_promotion { get; set; }
        public string g_photo_max_vars { get; set; }
        public bool g_dohtml { get; set; }
        public bool g_bypass_badwords { get; set; }
        public bool g_can_msg_attach { get; set; }
        public int g_attach_per_post { get; set; }
        public int g_dname_changes { get; set; }
        public int g_dname_date { get; set; }
        public bool g_mod_preview { get; set; }
        public int g_rep_max_positive { get; set; }
        public int g_rep_max_negative { get; set; }
        public string g_signature_limits { get; set; }
        public bool g_hide_online_list { get; set; }
        public long g_bitoptions { get; set; }
        public short g_pm_perday { get; set; }
        public long g_mod_post_unit { get; set; }
        public long g_ppd_limit { get; set; }
        public long g_ppd_unit { get; set; }
        public long g_displayname_unit { get; set; }
        public long g_sig_unit { get; set; }
        public int g_pm_flood_mins { get; set; }
        public int g_max_bgimg_upload { get; set; }
        public Nullable<bool> g_post_polls { get; set; }
        public Nullable<bool> g_vote_polls { get; set; }
        public short g_topic_rate_setting { get; set; }
        public long g_bitoptions2 { get; set; }
        public bool g_upload_animated_photos { get; set; }
        public Nullable<bool> g_view_displaynamehistory { get; set; }
        public Nullable<bool> g_promotion_type { get; set; }
    }
}
