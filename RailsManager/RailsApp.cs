using System;
using System.IO;
using System.Diagnostics;

namespace RailsManager
{
    public class RailsApp
    {
        private string appdir;
        private string pidfile;
        private string railsExecutable;
        private Process appProcess;
        private Process railsProcess;


        public bool isRunning
        {
            get
            {
                return this.railsProcess != null && !this.railsProcess.HasExited;
            }
        }


        public RailsApp(string railsExecutable, string directory)
        {
            if (!Directory.Exists(directory)) throw new DirectoryNotFoundException(directory + " does not exist.");
            if (!File.Exists(railsExecutable)) throw new FileNotFoundException(railsExecutable + " does not exist");
            this.appdir = directory;
            this.railsExecutable = railsExecutable;
            this.pidfile = Path.Combine(new string[]{directory, "tmp", "pids", "server.pid"});
            readPID();
        }

        private void readPID()
        {
            if (!File.Exists(this.pidfile))
            {
                this.railsProcess = null;
                return;
            }

            StreamReader sr = File.OpenText(this.pidfile);
            try
            {
                int pid = Convert.ToInt32(sr.ReadLine(), 10);
                Process p = Process.GetProcessById(pid);
                this.railsProcess = p;
            }
            catch (ArgumentException)
            {
                removePidFile();
                this.railsProcess = null;
                return;
            }
            finally
            {
                sr.Close();
            }
        }

        public bool stop(string environment)
        {
            readPID();
            this.railsProcess.Kill();
            this.railsProcess = null;
            this.appProcess.Kill();
            this.appProcess = null;
            this.removePidFile();
            return true;
        }


        public bool run(string environment, int port)
        {
            if (this.isRunning) return true;
            

            this.appProcess = new Process();
            this.appProcess.StartInfo = new ProcessStartInfo(this.railsExecutable, String.Format("server -e {0} -p {1}", environment, port));
            this.appProcess.StartInfo.WorkingDirectory = this.appdir;
            this.appProcess.StartInfo.UseShellExecute = false;
            this.appProcess.StartInfo.CreateNoWindow = true;
            this.appProcess.Start();

            return false;
        }

        private void removePidFile()
        {
            try
            {
                File.Delete(this.pidfile);
            }
            catch (FileNotFoundException)
            {

            }
        }


        public override string ToString()
        {
            return this.appdir;
        }
    }
}
