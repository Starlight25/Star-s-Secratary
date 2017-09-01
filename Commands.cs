using Discord.Commands;
using System.Threading.Tasks;

namespace Star_s_Secretary.Modules

//basic simple layout, just follow the commands!
// [Command("COMMAND NAME")]
        public async Task PUT RANDOM SPAM HERE()
        {
            await Context.Channel.SendMessageAsync("WHAT U WANT IT TO SAY");
        }

{
    public class test : ModuleBase<SocketCommandContext>
    {
        [Command("say")]
        public async Task jidfhnefnheo(string repeat)
        {
            await Context.Channel.SendMessageAsync(repeat);
        }
        [Command("help")]
        public async Task fghghgjgf()
        {
            await Context.Channel.SendMessageAsync("__List of commands:__ " +
                "-invite , -say");
        }
        [Command("invite")]
        public async Task hcsgcahis()
        {
            await Context.Channel.SendMessageAsync("Click here to invite me to your server <3: " +
                "https://discordapp.com/oauth2/authorize?client_id=351380462847131659&scope=bot&permissions=0");
        }
        [Command("cookie")]
        public async Task irgfbevtyba()
        {
            await Context.Channel.SendMessageAsync("You got a cookie! Enjoy!");
        }
        [Command("f")]
        public async Task jfuffgsncogn()
        {
            await Context.Channel.SendMessageAsync("%user% has paid your respects :heart:");
        }
    }
}
