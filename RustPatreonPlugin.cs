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
        #region variables
        [JsonProperty(PropertyName = "Patreon Command", ObjectCreationHandling = ObjectCreationHandling.Replace)]
        public string[] PatreonCommandTextMatch = { "patreon", "patr" };

        private const string rustPatreonDataFile = "RustPatreonDataFile";

        private const string claimPermission = "patreonApi.claim";
        private const string unlinkPermission = "patreonApi.unlink";
        private const string linkPermission = "patreonApi.link";
        private const string updatePermission = "patreonApi.update";
        private const string checkPermission = "patreonApi.check";

        private bool pluginIsReady = false;
        private bool pluginIsSaving = false;

        private readonly Dictionary<string, string> infoText = new Dictionary<string, string>
        {
            ["Permission"] = "Permission requiered"
        };

        private PatreonData patreonDataList;

        /*#region Localization
        protected override void LoadDefaultMessages()
        {
            lang.RegisterMessages(new Dictionary<string, string>
            {
                ["Permission"] = "Permission requiered"
            }, this);
        }
        #endregion Localization*/
        #endregion

        #region class
        private class PatreonSupporter
        {
            public string patreonID { get; set; }
            public string steamID { get; set; }
            public string tier { get; set; }
        }

        private class PatreonData
        {
            public HashSet<PatreonSupporter> PatreonSupporterList = new HashSet<PatreonSupporter>();
        }
        #endregion

        #region methods
        void Init()
        {
            pluginIsReady = false;
            AddCovalenceCommand(PatreonCommandTextMatch, nameof(PatreonCommand));
            permission.RegisterPermission(claimPermission, this);
            permission.RegisterPermission(unlinkPermission, this);
            permission.RegisterPermission(linkPermission, this);
            permission.RegisterPermission(updatePermission, this);
            permission.RegisterPermission(checkPermission, this);

            patreonDataList = Interface.Oxide.DataFileSystem.ReadObject<PatreonData>(rustPatreonDataFile);
            pluginIsReady = true;

            Puts("Plugin is ready");
        }

        void OnServerInitialized(bool serverInitialized)
        {
            Puts("Server Initialized");
        }

        private void PatreonCommand(IPlayer player, string command, string[] args)
        {
            Puts("Debug PatreonCommand");

            if (args.Length == 1 && pluginIsReady)
            {
                if (String.Equals(args[0].ToLower(), "claim"))
                {
                    if (player.HasPermission(claimPermission))
                    {
                        player.Reply("Successfully claimed");
                    }
                    else
                        player.Reply(infoText["Permission"]);
                }
                else if (String.Equals(args[0].ToLower(), "unlink"))
                {
                    if (player.HasPermission(unlinkPermission))
                    {
                        player.Reply("Successfully unlinked");
                    }
                    else
                        player.Reply(infoText["Permission"]);
                }
                else if (String.Equals(args[0].ToLower(), "link"))
                {
                    if (player.HasPermission(linkPermission))
                    {
                        player.Reply("Successfully linked");
                    }
                    else
                        player.Reply(infoText["Permission"]);
                }
                else if (String.Equals(args[0].ToLower(), "update"))
                {
                    if (player.HasPermission(updatePermission))
                    {
                        player.Reply("Successfully updated");
                    }
                    else
                        player.Reply(infoText["Permission"]);
                }
                else if (String.Equals(args[0].ToLower(), "check"))
                {
                    if (player.HasPermission(checkPermission))
                    {
                        player.Reply("Successfully checked");
                    }
                    else
                        player.Reply("Permission requiered");
                }
                else
                {
                    player.Reply("Unrecognized command, please retry.");
                }
            }
            else
                player.Reply("Command incorrect, an option is requiered to use /" + command);
        }

        private void SavePatreonData()
        {
            Puts("Saving data to the file...");
            pluginIsSaving = true;
            Interface.Oxide.DataFileSystem.WriteObject(rustPatreonDataFile, patreonDataList);
            pluginIsSaving = false;
            Puts("Data saved");
        }
        #endregion
    }
}