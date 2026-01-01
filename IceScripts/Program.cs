using System.CommandLine;
using IceScripts.Scripts.Zaim;

namespace IceScripts;

public static class Program
{
    public static int Main(string[] args)
    {
        var rootCommand = new RootCommand("Ice Scripts CLI Tool");
        rootCommand.SetZaimCommands();
        
        return rootCommand.Parse(args).Invoke();
    }

    private static RootCommand SetZaimCommands(this RootCommand rootCommand)
    {
        var zaimCommand = new Command("zaim", "Zaim 関連のコマンド");
        rootCommand.Subcommands.Add(zaimCommand);
        
        var getTokenCommand = new Command("get-token", "Zaim のアクセストークンとシークレットを取得");
        getTokenCommand.SetAction(parseResult =>
        {
            try
            {
                GetZaimAccessTokenAndSecrets.GetZaimAccessToken();
                return 0;
            }
            catch (Exception e)
            {
                Console.Error.WriteLine($"Error: {e.Message}");
                return 1;
            }
        });
        zaimCommand.Subcommands.Add(getTokenCommand);
        
        return rootCommand;
    }
}