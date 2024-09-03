using DiscordRPC;
using DiscordRPC.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace byZyczu.Modules
{
    internal class DiscordPresence
    {
        static public DiscordRpcClient client;


        static Timestamps sprmawdupie = Timestamps.Now;

        public static void initializediscord(string stejt)
        {
            try
            {
                client = new DiscordRpcClient("1197120924294586378");
                client.OnReady += async delegate (object sender, ReadyMessage e)
                {

                };
                client.OnPresenceUpdate += delegate (object sender, PresenceMessage e)
                {
                };
                client.Initialize();
                client.SetPresence(new RichPresence
                {
                    Details = "byZyczu | " + Form1.version,
                    State = stejt,
                    Timestamps = sprmawdupie,
                    Assets = new Assets
                    {
                        LargeImageKey = "http://mksteam.ovh/zyczumc.png"
                    },
                    Buttons = new DiscordRPC.Button[2]
                    {
                    new DiscordRPC.Button
                    {
                        Label = "Github",
                        Url = "https://github.com/mksmaicja/byZyczu"
                    },
                    new DiscordRPC.Button
                    {
                        Label = "Discord",
                        Url = "http://dc.mksteam.ovh/"
                    }
                    }
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void SetPresence(string stejt, string details)
        {
            client.SetPresence(new RichPresence
            {
                Details = details,
                State = stejt,
                Timestamps = sprmawdupie,
                Assets = new Assets
                {
                    LargeImageKey = "http://mksteam.ovh/zyczumc.png"
                },
                Buttons = new DiscordRPC.Button[2]
                {
                    new DiscordRPC.Button
                    {
                        Label = "Github",
                        Url = "https://github.com/mksmaicja/byZyczu"
                    },
                    new DiscordRPC.Button
                    {
                        Label = "Discord",
                        Url = "http://dc.mksteam.ovh/"
                    }
                }
            });
        }
    }
}
