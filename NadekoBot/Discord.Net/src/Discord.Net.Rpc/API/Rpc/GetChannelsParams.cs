﻿#pragma warning disable CS1591
using Newtonsoft.Json;

namespace Discord.API.Rpc
{
    internal class GetChannelsParams
    {
        [JsonProperty("guild_id")]
        public ulong GuildId { get; set; }
    }
}
