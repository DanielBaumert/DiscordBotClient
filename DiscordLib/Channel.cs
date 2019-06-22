using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordLib {
    internal struct Channel {
        /// <summary>
        /// the id of this channel
        /// </summary>
        public string ID;
        /// <summary>
        /// the type of channel
        /// </summary>
        public ChannelTypes Type;
        /// <summary>
        /// the id of the guild
        /// </summary>
        public string GuilID;
        /// <summary>
        /// sorting position of the channel
        /// </summary>
        public int Position;
        /// <summary>
        /// explicit permission overwrites for members and roles
        /// </summary>
        public PermissionOverwrite[] PermissionOverwrites;
        public string Name;
        public string Topic;
        public bool Nsfw;
        public string LastMessageId;
        public int Bitrate;
        public int UserLimit;
        public int RateLimitPerUser;
        public User[] Recipients;
        public string Icon;
        public string OwnerId;
        public string ApplicationId;
        public string ParentId;
    }
}
