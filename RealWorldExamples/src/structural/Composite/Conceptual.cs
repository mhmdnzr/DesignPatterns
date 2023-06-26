
namespace RealWorldExamples.src.structural.Composite
{
    interface IFile
    {
        public string getType();
        public long getSize();
    }

    class Directory : IFile
    {
        private List<IFile> files = new();
        public string getType()
        {
            return "directory";
        }

        public void AddFile(IFile file)
        {
            files.Add(file);
        }

        public long getSize()
        {
            long size = 0L;
            foreach (IFile file in files)
            {
                size += file.getSize();
            }
            return size;
        }
    }

    class TextFile : IFile
    {
        private long size;
        public TextFile(long size)
        {
            this.size = size;
        }
        public String getType()
        {
            return "txt";
        }

        public long getSize()
        {
            return this.size;
        }
    }


    class RunCompositeProgram
    {
        public static void Main()
        {
            TextFile child1 = new(100L);
            TextFile child2 = new(200L);
            Directory root = new Directory();
            root.AddFile(child1);
            root.AddFile(child2);
            Console.WriteLine(child1.getSize());      // output : 100
            Console.WriteLine(root.getSize());    // output : 300
        }
    }
}
