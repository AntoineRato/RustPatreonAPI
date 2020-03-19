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
            Puts("Debug Init");
        }

        void OnServerInitialized(bool serverInitialized)
        {
            Puts("Debug OnServerInitialized");
        }

        //#region Commands
        [Command("patreon")]
        public void PatreonCommand(IPlayer player, string command, string[] args)
        {
            //if (args.Length < 1)
            Puts("Debug PatreonCommand");

            if (String.Equals(args[0].ToLower(), "claim"))
            {
                Puts("Command send : " + command);
                Puts("Arguments : " + args[0].ToLower());
                Puts("Command recognized : claim");

                player.Reply("Command send : " + command);
                player.Reply("Arguments : " + args[0].ToLower());
                player.Reply("Command recognized : claim");

                player.Message("Message : \nCommand send : " + command);
                player.Message("Arguments : " + args[0].ToLower());
                player.Message("Command recognized : claim");
            }
            else if (String.Equals(args[0].ToLower(), "unlink"))
            {
                Puts("Command send : " + command);
                Puts("Arguments : " + args[0].ToLower());
                Puts("Command recognized : unlink");

                player.Reply("Command send : " + command);
                player.Reply("Arguments : " + args[0].ToLower());
                player.Reply("Command recognized : unlink");

                player.Message("Message : \nCommand send : " + command);
                player.Message("Arguments : " + args[0].ToLower());
                player.Message("Command recognized : unlink");
            }
            else if (String.Equals(args[0].ToLower(), "link"))
            {
                Puts("Command send : " + command);
                Puts("Arguments : " + args[0].ToLower());
                Puts("Command recognized : link");

                player.Reply("Command send : " + command);
                player.Reply("Arguments : " + args[0].ToLower());
                player.Reply("Command recognized : link");

                player.Message("Message : \nCommand send : " + command);
                player.Message("Arguments : " + args[0].ToLower());
                player.Message("Command recognized : link");
            }
            else if (String.Equals(args[0].ToLower(), "update"))
            {
                Puts("Command send : " + command);
                Puts("Arguments : " + args[0].ToLower());
                Puts("Command recognized : update");

                player.Reply("Command send : " + command);
                player.Reply("Arguments : " + args[0].ToLower());
                player.Reply("Command recognized : update");

                player.Message("Message : \nCommand send : " + command);
                player.Message("Arguments : " + args[0].ToLower());
                player.Message("Command recognized : update");
            }
            else if (String.Equals(args[0].ToLower(), "check"))
            {
                Puts("Command send : " + command);
                Puts("Arguments : " + args[0].ToLower());
                Puts("Command recognized : check");

                player.Reply("Command send : " + command);
                player.Reply("Arguments : " + args[0].ToLower());
                player.Reply("Command recognized : check");

                player.Message("Message : \nCommand send : " + command);
                player.Message("Arguments : " + args[0].ToLower());
                player.Message("Command recognized : check");
            }
            else
            {
                Puts("Unrecognized command, please retry.");
                player.Reply("Unrecognized command, please retry.");
                player.Message("Message : \nUnrecognized command, please retry.");
            }
        }
    }
}