using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace THSet {
    public class MemoryTool {

        [DllImport("kernel32.dll")]
        public static extern int WriteProcessMemory(IntPtr Handle,long Address,byte[] buffer,int Size,int BytesWritten = 0);
        [DllImport("kernel32.dll")]
        public static extern int ReadProcessMemory(IntPtr Handle,long Address,byte[] buffer,int Size,int BytesRead = 0);
        [DllImport("user32.dll",EntryPoint = "keybd_event",SetLastError = true)]
        public static extern void keybd_event(Keys bVk,byte bScan,uint dwFlags,uint dwExtraInfo);
        [DllImport("user32.dll")]
        public static extern byte MapVirtualKey(byte wCode,int wMap);

        Process touhouGameProcess;
        Process obsProcess;

        public MemoryTool(Process touhouGameProcess,Process obsProcess) {
            this.touhouGameProcess=touhouGameProcess;
            this.obsProcess=obsProcess;
        } 

        public int ReadInteger(long Address) {
            byte[] Buffer = new byte[4];
            ReadProcessMemory(touhouGameProcess.Handle,Address,Buffer,4);
            return BitConverter.ToInt32(Buffer,0);
        }

        public IntPtr GetOBSProcessHandle() {
            return obsProcess.Handle;
        }

        public int WriteToOBS(long Address,float f) {
            return WriteProcessMemory(GetOBSProcessHandle(),Address,BitConverter.GetBytes(f),4);
        }

        public int ReadGame(long baseAddr,long offset) {
            byte[] Buffer = new byte[4];
            ReadProcessMemory(touhouGameProcess.Handle,ReadInteger(baseAddr)+offset,Buffer,4);
            return BitConverter.ToInt32(Buffer,0);
        }

        /*   public float ReadGame8(long baseAddr) {
               byte[] Buffer = new byte[4];
               ReadProcessMemory(touhouGameProcess.Handle,ReadInteger(baseAddr),Buffer,4);
               return BitConverter.ToSingle(Buffer,0);
           }
           public float ReadGame9(long baseAddr,long offset) { 
               byte[] Buffer = new byte[4];
               ReadProcessMemory(touhouGameProcess.Handle,ReadInteger(baseAddr)+offset,Buffer,4);
               return BitConverter.ToSingle(Buffer,0);
           }*/
    }
}
