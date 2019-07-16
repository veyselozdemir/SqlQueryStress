using CommandLine;
using CommandLine.Text;

namespace SQLQueryStress
{
    public class CommandLineOptions
    {
        private readonly HeadingInfo _headingInfo = new HeadingInfo(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name, System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString());

        [Option("c", "config", HelpText = "File name of saved session settings\r\n")]
        public string SessionFile = string.Empty;

        [Option("u", "unattended", HelpText = "Run unattended (start, run settings file and quit)")]
        public bool Unattended = false;

        [Option("t", "threads", HelpText = "Number of threads in unattended mode")]
        public int NumberOfThreads = -1;

        [Option("s", "saveTo", HelpText = "File name to auto save the results to")]
        public string AutoSaveFilePath = string.Empty;

        [Option("n", "name", HelpText = "Name of this run")]
        public string TestName = string.Empty;

        [Option("d", "db", HelpText = "Database Server")]
        public string DbServer = string.Empty;

        [HelpOption("?", null, HelpText = "Display this help screen")]
        public string GetUsage()
        {
            HelpText help = new HelpText(_headingInfo);
            help.Copyright = new CopyrightInfo("Adam Machanic", 2006);
            help.AddPreOptionsLine("Check for updates at: https://github.com/ErikEJ/SqlQueryStress");
            help.AddPreOptionsLine("");
            help.AddPreOptionsLine("Sample usage:");
            help.AddPreOptionsLine("SqlQueryStress -c \"saved.SqlStress\" -u  -t 32 -s \"results.csv\" ");
            help.AddOptions(this);
            return help;
        }
    }


}
