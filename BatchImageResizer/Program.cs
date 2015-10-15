using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using CommandLine;
using CommandLine.Text;

namespace BatchImageResizer
{
    /* Image Libraries Source: http://imageresizing.net/plugins/editions/free */
    class Program
    {
        static void Main(string[] args)
        {
            // settings: https://commandline.codeplex.com/wikipage?title=The-Parsing-Process&referringTitle=Documentation
            // more info: https://github.com/gsscoder/commandline/wiki 
            var options = new Options();

            /* todo: get this working (it doesn't work with --help flag */
            //if (CommandLine.Parser.Default.ParseArgumentsStrict(args, cmdOptions, () =>
            //{
            //    //ProperlyDisposeYourResources((ex) => Log.Error(ex.Message));
            //    Console.WriteLine("Invalid Usage, please try 'BatchFileResizer --help' for help\n");
            //    Environment.Exit(-2);
            //}))
            //{
            //    // Domain logic here
            //    Console.WriteLine("it's working\n");
            //}

            if (!CommandLine.Parser.Default.ParseArguments(args, options))
            {
                //Console.WriteLine("Invalid Usage, please try 'BatchFileResizer --help' for help\n");
                Environment.Exit(CommandLine.Parser.DefaultExitCodeFail);
            }

            //Console.WriteLine("t|ext: " + options.TextValue);
            //Console.WriteLine("n|umeric: " + options.NumericValue);
            //Console.WriteLine("b|ool: " + options.BooleanValue.ToString().ToLowerInvariant());

            var directoryPath = options.DirectoryPath;
            var filePath = options.FilePath;

            var directoryMode = (!string.IsNullOrEmpty(directoryPath));

            Console.WriteLine("directoryMode?: " + directoryMode);
            Console.WriteLine("Directory Path: " + directoryPath);
            Console.WriteLine("File Path: " + filePath);


        }
    }

}
