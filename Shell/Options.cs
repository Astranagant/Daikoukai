using CommandLine;

namespace Daikoukai.Shell
{
    class Options
    {
        [Option('d', "decrypt", Required = true, HelpText = "Text to decrypt")] 
        public string DecryptionText { get; set; }

        [Option('v', "verbose")]
        public bool Verbose { get; set; }

        [Option('e', "encrypt", Required = true, HelpText = "Text to encrypt")]
        public string EncryptionText { get; set; }

        [HelpOption]
        public string GetUsage()
        {

            string usage = @"Usage:
                Daikoukai.Shell <-d cipher|-e plain>";
            return usage;
        }
    }
}
