using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Delegate
{
    public class EventExample
    {

        public static void Event()
        {
            var fileLister = new FileSearcher();
            int filesFound = 0;

            EventHandler<FileFoundArgs> onFileFound = (sender, eventArgs) =>
            {
                Console.WriteLine(eventArgs.FoundFile);
                filesFound++;
            };

            fileLister.FileFound += onFileFound;
            //FileFOund의 등록된 메소드들 실행
            fileLister.Search("fakeDirectory", "fakeDirectory");
        }
    }
    
    public class FileSearcher
    {
        // 다음과 같은 형태로 필드 선언
        public event EventHandler<FileFoundArgs> FileFound;

        public void Search(string directory, string searchPattern)
        {
            foreach (var file in Directory.EnumerateFiles(directory, searchPattern))
            {
                FileFound?.Invoke(this, new FileFoundArgs(file));
            }
        }
    }
    public class FileFoundArgs : EventArgs
    {
        public string FoundFile { get; }

        public FileFoundArgs(string fileName)
        {
            FoundFile = fileName;
        }
    }
}
