using System.Collections.Generic;

namespace RockApi
{
    /// <summary>
    /// Object returned by the API. Contains a collections of members and other info
    /// </summary>
    public class MemberSet : IRockEntitySet
    {
        public int offset { get; set; }
        public int total { get; set; }
        public string message { get; set; }
        public List<Member> members { get; set; }
    }
}
