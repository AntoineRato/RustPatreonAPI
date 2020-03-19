using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Newtonsoft.Json;
using Oxide.Core;
using Oxide.Core.Libraries.Covalence;

namespace Oxide.Plugins
{
    class RustPatreonPlugin : CovalencePlugin
    {
        [JsonProperty(PropertyName = "Patreon Command", ObjectCreationHandling = ObjectCreationHandling.Replace)]
        public string[] PatreonCommandTextMatch = { "patreon" };

        class PatreonSupporter
        {
            string patreonID;
            string steamID;
            string tier;
        }

        void Init()
        {
            AddCovalenceCommand(PatreonCommandTextMatch, nameof(PatreonCommand));
        }

        public void PatreonCommand(IPlayer player, string command, string[] args)
        {
            if(String.Equals(args[0].ToLower(), "claim"))
            {
                Puts("Command send : " + command);
                Puts("Arguments : " + args[0].ToLower());
                Puts("Command recognized : claim");
            }
            else if(String.Equals(args[0].ToLower(), "unlink"))
            {
                Puts("Command send : " + command);
                Puts("Arguments : " + args[0].ToLower());
                Puts("Command recognized : unlink");
            }
            else if (String.Equals(args[0].ToLower(), "link"))
            {
                Puts("Command send : " + command);
                Puts("Arguments : " + args[0].ToLower());
                Puts("Command recognized : link");
            }
            else if (String.Equals(args[0].ToLower(), "update"))
            {
                Puts("Command send : " + command);
                Puts("Arguments : " + args[0].ToLower());
                Puts("Command recognized : update");
            }
            else if (String.Equals(args[0].ToLower(), "check"))
            {
                Puts("Command send : " + command);
                Puts("Arguments : " + args[0].ToLower());
                Puts("Command recognized : check");
            }
            else
            {
                player.Reply("Unrecognized command, please retry.");
            }
        }
    }
}
