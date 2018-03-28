using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Fluffy.Mods
{
    public class Hello : ModuleBase<SocketCommandContext>
    {
        [Command("hi")]
        public async Task PingAsync()
        {
            EmbedBuilder builder = new EmbedBuilder();

            builder.WithTitle("Hey there!")
                .WithDescription("Thanks for checking on me!")
                .WithColor(Color.DarkRed);

            await ReplyAsync("", false, builder.Build());
        }
    }
}
