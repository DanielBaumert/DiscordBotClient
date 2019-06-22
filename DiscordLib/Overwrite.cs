using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordLib {
    public struct PermissionOverwrite {
        /// <summary>
        /// Role or user id
        /// </summary>
        public string Id;
        /// <summary>
        /// either "role" or "member"
        /// </summary>
        public string Type;
        /// <summary>
        /// permission bit set
        /// </summary>
        public int Allow;
        /// <summary>
        /// permission bit set
        /// </summary>
        public int Deny;
    }
}
