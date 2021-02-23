
using System.Threading.Tasks;
using Discord.Commands;
using Discord;

namespace DiscordBot.Modules
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        [Command("slam")]
        public async Task slam()
        {
            await ReplyAsync(":dog: Slam the Ma'am! :dog:");
        }

        [Command("SayHi")]
        public async Task SayHi()
        {
            await ReplyAsync("Woof :loudspeaker:");
        }

        [Command("WhoAmI")]
        public async Task WhoAmI(ushort size = 512)
        {
            await ReplyAsync(CDN.GetUserAvatarUrl(Context.User.Id, Context.User.AvatarId, size, ImageFormat.Auto));
        }
    }
}
