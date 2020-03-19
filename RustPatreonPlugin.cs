using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Newtonsoft.Json;
using Oxide.Core;
using Oxide.Core.Libraries.Covalence;

namespace Oxide.Plugins
{
    [Info("Rust Patreon Plugin", "Zlino", "1.0.0")]
    [Description("Link patreon account with their steam account.")]

    class RustPatreonPlugin : CovalencePlugin
    {
        //[JsonProperty(PropertyName = "Patreon Command", ObjectCreationHandling = ObjectCreationHandling.Replace)]
        //public string[] PatreonCommandTextMatch = { "patreon" };

        class PatreonSupporter
        {
            string patreonID;
            string steamID;
            string tier;
        }

        void Init()
        {
            //AddCovalenceCommand(PatreonCommandTextMatch, nameof(PatreonCommand));
        }

        //#region Commands
        [ChatCommand("patreon")]
        public void PatreonCommand(IPlayer player, string command, string[] args)
        {
            //if (args.Length < 1)

            if (String.Equals(args[0].ToLower(), "claim"))
            {
                player.Reply("Command send : " + command);
                player.Reply("Arguments : " + args[0].ToLower());
                player.Reply("Command recognized : claim");
            }
            else if(String.Equals(args[0].ToLower(), "unlink"))
            {
                player.Reply("Command send : " + command);
                player.Reply("Arguments : " + args[0].ToLower());
                player.Reply("Command recognized : unlink");
            }
            else if (String.Equals(args[0].ToLower(), "link"))
            {
                player.Reply("Command send : " + command);
                player.Reply("Arguments : " + args[0].ToLower());
                player.Reply("Command recognized : link");
            }
            else if (String.Equals(args[0].ToLower(), "update"))
            {
                player.Reply("Command send : " + command);
                player.Reply("Arguments : " + args[0].ToLower());
                player.Reply("Command recognized : update");
            }
            else if (String.Equals(args[0].ToLower(), "check"))
            {
                player.Reply("Command send : " + command);
                player.Reply("Arguments : " + args[0].ToLower());
                player.Reply("Command recognized : check");
            }
            else
            {
                player.Reply("Unrecognized command, please retry.");
            }
        }
    }
}
