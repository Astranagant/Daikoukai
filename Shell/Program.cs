using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Daikoukai.Core.Crypto;
using Daikoukai.Shell.Manager;
using CommandLine;

namespace Daikoukai.Shell
{
    class Program
    {
        static void Main(string[] args)
        {
            var options = new Options();

            CommandLine.Parser parser = new Parser();
            if (parser.ParseArguments(args, options))
            {
                if (options.Verbose)
                {
                    Console.WriteLine("Processing: " + options.DecryptionText);
                }

                //aTNvFD5MCZbArJd2RiCgA5AdEgAjgvybzmncr5gHo3M=

                string plainString = CryptoManager.Decrypt(options.DecryptionText, Encoding.UTF8);

                Console.WriteLine(plainString);
            }
            else
            {
                Console.WriteLine(options.GetUsage());
            }

        }
    }
}
