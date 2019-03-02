using System;
using System.IO;
using System.Linq;

namespace DotNetProject {
    class Program {
        static void Main(bool projectPath, FileInfo file) {
            if (projectPath) {
                FindProject(file);
            }
        }

        static void FindProject(FileInfo file) {
            var dir = file.Directory;
            while (dir.Parent != null) {
                var project = dir.GetFiles("*.?sproj").FirstOrDefault();
                if (project != null) {
                    Console.WriteLine(project.FullName);
                    return;
                }
                dir = dir.Parent;
            }
        }
    }
}
