
using System.Reflection;
using McMaster.Extensions.CommandLineUtils;

namespace CliSample;

[Command(Name = "cliSample", OptionsComparison = StringComparison.InvariantCultureIgnoreCase)]
[VersionOptionFromMember("--version", MemberName = nameof(GetVersion))]
public class CliSampleCmd
{
    protected Task<int> OnExecute(CommandLineApplication app)
    {
        app.ShowHelp();
        return Task.FromResult(0);
    }

    private static string? GetVersion() => typeof(CliSampleCmd).Assembly?.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion;
}