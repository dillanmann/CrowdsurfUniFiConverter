using CommandLine;
using CsvHelper;
using Newtonsoft.Json;
using System.Globalization;
using UnifiJsonConverter;
using UnifiJsonConverter.Model;
Parser.Default.ParseArguments<CommandLineOptions>(args)
.WithParsed(o =>
{
    Console.WriteLine(string.Join(",", args));
    using (var inputStream = new FileStream(path: o.InputFilePath, FileMode.Open))
    using (StreamReader sr = new StreamReader(inputStream))
    using (JsonReader reader = new JsonTextReader(sr))
    using (var writer = new StreamWriter(o.OutputFilePath))
    using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
    {
        JsonSerializer serializer = new JsonSerializer();
        var result = serializer.Deserialize<PastConnectionsData>(reader);

        csv.WriteRecords(result.Connections);
    }
});