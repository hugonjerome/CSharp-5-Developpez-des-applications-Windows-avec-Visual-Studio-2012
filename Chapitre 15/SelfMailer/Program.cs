using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace SelfMailer
{
    static class Program
    {
        public static Library.Project Project;
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!EventLog.SourceExists("SelfMailer"))
            {
                EventLog.CreateEventSource("SelfMailer", "Mes applications");
            }
            EventLog eventLog = new EventLog("Mes applications", ".", "SelfMailer");
            eventLog.WriteEntry("Mon message", EventLogEntryType.Warning);

            BooleanSwitch booleanSwitch = new BooleanSwitch("BooleanSwitch", "Commutateur booléen.");
            TraceSwitch traceSwitch = new TraceSwitch("TraceSwitch", "Commutateur complexe.");

            TextWriterTraceListener textListener = new TextWriterTraceListener(@".\Trace.txt");
            Trace.Listeners.Add(textListener);

            Trace.AutoFlush = true;
            Trace.WriteLineIf(booleanSwitch.Enabled, "Démarrage de l'application SelfMailer");

            Project = new Library.Project();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.Main());

            Trace.WriteLineIf(traceSwitch.TraceInfo, "Arrêt de l'application SelfMailer");
        }
    }
}
