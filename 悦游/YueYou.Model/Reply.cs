//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace YueYou.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reply
    {
        public int Reply_id { get; set; }
        public int User_id { get; set; }
        public int Guide_id { get; set; }
        public System.DateTime Reply_time { get; set; }
        public string Reply_contents { get; set; }
    
        public virtual Guide Guide { get; set; }
        public virtual UserInfo UserInfo { get; set; }
    }
}
