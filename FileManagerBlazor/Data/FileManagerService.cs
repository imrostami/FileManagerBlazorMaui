global using static FileManagerBlazor.Data.FileManagerService;


namespace FileManagerBlazor.Data
{
    public class FileManagerService
    {

        static FileManagerService fileManagerService;
        public List<string> GetSystemDrives()
        {
            var drives = Directory.GetLogicalDrives()
                .ToList();


            return drives;
        }

        public string GetSystemDriveName()
        {
            var sdriveName = Environment.GetFolderPath(Environment.SpecialFolder.System);
            return sdriveName;
        }


        public static FileManagerService FileService 
        {
            get
            {
                if (fileManagerService is null)
                {
                    fileManagerService = new();
                    return fileManagerService;
                }
                    return fileManagerService;
            }
        }
    }
}
