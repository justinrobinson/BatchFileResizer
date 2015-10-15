using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandLine;
using CommandLine.Text;

namespace BatchImageResizer
{
    /*  usage info: https://commandline.codeplex.com/documentation
        Github Wiki: https://github.com/gsscoder/commandline/wiki 
        StackOverflow Link: http://stackoverflow.com/questions/10639320/command-line-parser-with-mutually-exclusive-required-parameters
    */

    /// <summary>
    /// CommandLineOptions Settings 
    /// </summary>
    public class Options
    {
        private FileVersionInfo _fileVersionInfo;

        public Options()
        {
            _fileVersionInfo = Helpers.GetProductAssemblyInformation();
        }

        [Option('f', "file", Required = false, HelpText = "Input file to read.")]
        public string FilePath { get; set; }

        [Option('d', "directory", Required = false, HelpText = "Directory path of input file(s).")]
        public string DirectoryPath { get; set; }

        [Option('w', "width", Required = false, DefaultValue = 500, HelpText = "Maximum width of modified image.")]
        public int MaximumWidth { get; set; }

        [Option('h', "height", Required = false, HelpText = "Maximum height of modified image.")]
        public int MaximumHeight { get; set; }

        [Option('c', "compression", Required = false, DefaultValue = 90, HelpText = "Jpeg compression level.")]
        public int CompressionLevel { get; set; }

        [Option('t', "type", Required = false, DefaultValue = ImageFormatType.jpg, HelpText = "Output image type.")]
        public ImageFormatType ImageFormatTypes { get; set; }

        //[Option("i", "input", Required = true, HelpText = "Input file to read.")]
        //public string InputFile { get; set; }

        //[Option(null, "length", HelpText = "The maximum number of bytes to process.")]
        //public int MaximumLenght { get; set; }

        [Option('v', "verbose", Required = false, HelpText = "Print details during execution.")]
        public bool Verbose { get; set; }

        //[HelpOption(HelpText = "Display this help screen.")]
        //public string GetUsage()
        //{
        //    var usage = new StringBuilder();
        //    usage.AppendLine("Batch Image Resizer 1.0");
        //    usage.AppendLine("Please visit the Github Wiki for more details");
        //    usage.AppendLine(Environment.NewLine);
        //    return usage.ToString();
        //}

        [HelpOption]
        public string GetUsage()
        {
            var help = new HelpText
            {
                Heading = new HeadingInfo(_fileVersionInfo.ProductName, _fileVersionInfo.ProductVersion),
                Copyright = new CopyrightInfo(_fileVersionInfo.CompanyName, 2015),
                AdditionalNewLineAfterOption = true,
                AddDashesToOption = true
            };
            help.AddPreOptionsLine("Apache License verson 2.0");
            help.AddPreOptionsLine("Usage: batchfileresizer -d c:\\documents\\images -w 500");
            help.AddOptions(this);
            return help;
        }

        //public enum InputType
        //{
        //    File,
        //    Directory
        //}

    }

}
