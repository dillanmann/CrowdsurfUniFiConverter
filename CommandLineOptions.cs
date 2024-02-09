using CommandLine;

namespace UnifiJsonConverter
{
    internal class CommandLineOptions
    {
        [Option("inputFilePath", Required = true, HelpText = "JSON file to convert from", Default = null)]
        public string InputFilePath { get; set; }

        [Option("outputFilePath", Required = true, HelpText = "File path to output conversion into", Default = null)]
        public string OutputFilePath { get; set; }
    }
}
