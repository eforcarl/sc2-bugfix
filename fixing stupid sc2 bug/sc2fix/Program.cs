using System.Diagnostics;
using System.Threading;

void lol()
{
    var fpath = Environment.CurrentDirectory + "\\" + "fix.bat";
    Process proc = new Process();
    proc.StartInfo.FileName = fpath;
    proc.Start();
    proc.WaitForExit();
    while (true)
    {
        Process[] pname = Process.GetProcessesByName("SC2_x64");
        if (pname.Length == 0)
        {
            Console.WriteLine("process killed");
            loop();
        }
        else
        {
            Console.WriteLine("still running");
        }
        Task.Delay(1000).Wait();
    }
}

void loop()
{
    while (true)
    {
        Process[] pname = Process.GetProcessesByName("SC2_x64");
        if (pname.Length == 0)
        {
            Console.WriteLine("no proc");
        }
        else
        {
            Console.WriteLine("proc found");
            Task.Delay(10000).Wait();
            lol();
            break;
        }
        Task.Delay(1000).Wait();
    }

}

loop();