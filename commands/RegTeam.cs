namespace TheBattleBot.commands
{
    using DSharpPlus.CommandsNext;
    using DSharpPlus.CommandsNext.Attributes;

    public class RegTeam : BaseCommandModule
    {
        [Command("regteam")]
        public async Task RegisterTeam(CommandContext context)
        {
            await context.Channel.SendMessageAsync("Hello");
        }
    }
}
