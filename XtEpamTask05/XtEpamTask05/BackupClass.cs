using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace XtEpamTask05
{
    class BackupClass
    {
        FileSystemWatcher _watcher = new FileSystemWatcher();
        string _directoryBackupName = "Backup";
        //string _logFileName = "log.json";

        public BackupClass(string path)
        {
            _watcher = new FileSystemWatcher(path);
            Directory.CreateDirectory(_directoryBackupName);
            //File.Create(string.Format("{0}/{1}", _directoryBackupName, _logFileName));
        }

        public void Watching()
        {
            //_watcher.Filter = "*.txt";
            _watcher.Changed += OnChanged;
            //_watcher.Created += OnChanged;
            _watcher.Deleted += OnChanged;
            _watcher.Renamed += OnRenamed;
            _watcher.EnableRaisingEvents = true;
            while (true) { }
        }

        public string GetAllDateBackups()
        {
            StringBuilder info = new StringBuilder();
            DirectoryInfo dirInfo = new DirectoryInfo(_directoryBackupName);
            foreach (var subderictory in dirInfo.GetDirectories())
            {
                info.Append(subderictory.ToString() + Environment.NewLine);
            }
            return info.ToString();
        }

        public void Recovery(string date)
        {
            CopyDir(string.Format("{0}/{1}", _directoryBackupName, date), _watcher.Path);
        }

        private void OnChanged(object source, FileSystemEventArgs e)
        {
            Backup(e.FullPath, e.Name);
        }

        private void OnRenamed(object source, RenamedEventArgs e)
        {
            Backup(e.FullPath, e.Name);
        }

        private void Backup(string path, string fileName)
        {
            string dateNow = DateTime.Now.ToString().Replace('/', '-').Replace(':', '.');
            string currentBackupDirectoryName = string.Format("{0}/{1}", _directoryBackupName, dateNow);
            Directory.CreateDirectory(currentBackupDirectoryName);
            CopyDir(_watcher.Path, currentBackupDirectoryName);
            //File.Copy(path, string.Format("{0}/{1}", currentBackupDirectoryName, fileName), true);
        }


        //Copy all directory
        private void CopyDir(string FromDir, string ToDir)
        {
            Directory.CreateDirectory(ToDir);
            foreach (string s1 in Directory.GetFiles(FromDir))
            {
                string s2 = ToDir + "\\" + Path.GetFileName(s1);
                File.Copy(s1, s2, true);
            }
            foreach (string s in Directory.GetDirectories(FromDir))
            {
                CopyDir(s, ToDir + "\\" + Path.GetFileName(s));
            }
        }
    }
}
