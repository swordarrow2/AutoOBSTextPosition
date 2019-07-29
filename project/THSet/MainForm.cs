using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace THSet {
    public partial class MainForm:Form {
        public const string versonCode = "Powered by THSet v3.4.9";
        private THCode thCode;
        private Process THprocess;
        private Process OBSProcess;
        private int pid = 0;
        private int gameIndex = 0;
        public string[] names = new string[] {"th10","th10chs","th10cht","th12","th12c","th128","th128_CN","th13","th13c","th14","th15","th16","th165","th17" };

        public MainForm() {
            InitializeComponent();
            Process tmp = Process.GetProcessesByName("obs64")[0];
            if(tmp.Id!=0) {
                OBSProcess=tmp;
            } else {
                tmp=Process.GetProcessesByName("obs32")[0];
                if(tmp.Id==0) {
                    MessageBox.Show("没有发现obs",versonCode,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    Environment.Exit(Environment.ExitCode);
                } else {
                    OBSProcess=tmp;
                }
            }
            for(;gameIndex<names.Length;gameIndex++) {
                pid=GetGamePID(names[gameIndex]);
                if(pid!=0) { break; }
            }
            if(pid==0) {
                StringBuilder sb = new StringBuilder();
                foreach(string s in names) {
                    sb.Append(s);
                    sb.Append(".exe\n");
                }
                MessageBox.Show("没有发现支持的车万进程\n目前支持:\n"+sb.ToString(),versonCode,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                Environment.Exit(Environment.ExitCode);
            }
            int THnum = 0;
            switch(gameIndex) {
                case 0:
                case 1:
                case 2: THnum=10; break;
                case 3:
                case 4: THnum=12; break;
                case 5:
                case 6: THnum=128; break;
                case 7:
                case 8: THnum=13; break;
                case 9: THnum=14; break;
                case 10: THnum=15; break;
                case 11: THnum=16; break;
                case 12: THnum=165; break;
                case 13: THnum=17; break;
            }
            thCode=new THCode(new MemoryTool(THprocess,OBSProcess),THnum);
        }

        private int GetGamePID(string exeName) {
            try {
                THprocess=Process.GetProcessesByName(exeName)[0];
                return THprocess.Id;
            } catch {
                return 0;
            }
        }

        private void btnStart_Click(object sender,EventArgs e) {
            thCode.InitAddr(Convert.ToInt64(tbAddrX.Text,16));
            thCode.InitText(Convert.ToSingle(tbMinX.Text),Convert.ToSingle(tbMaxX.Text),Convert.ToSingle(tbMinY.Text),Convert.ToSingle(tbMaxY.Text));
            timer1.Enabled=true;
        }

        private void timer1_Tick(object sender,EventArgs e) {
            labelX.Text=Convert.ToString(thCode.ProcessX());
            labelY.Text=Convert.ToString(thCode.ProcessY());
        }
    }
}
