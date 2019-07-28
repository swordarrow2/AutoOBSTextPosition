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
        public static MainForm instence;
        private THCode thCode;
        private Process THprocess;
        private Process OBSProcess;
        public string[] names = new string[] { "th07","th08","th09","th09c","th10","th10chs","th10cht","th12","th12c","th128","th128_CN","th13","th13c","th14","th15","th16","th165","th17" };
        private int pid = 0;
        private int gameIndex = 0;

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
            switch(gameIndex) {
                case 0: thCode=new TH07Code(new MemoryTool(THprocess,OBSProcess)); break;
                case 1: thCode=new TH08Code(new MemoryTool(THprocess,OBSProcess)); break;
                case 4:
                case 5:
                case 6: thCode=new TH10Code(new MemoryTool(THprocess,OBSProcess)); break;
                case 7:
                case 8: thCode=new TH12Code(new MemoryTool(THprocess,OBSProcess)); break;
                case 9:
                case 10: thCode=new TH128Code(new MemoryTool(THprocess,OBSProcess)); break;
                case 11:
                case 12: thCode=new TH13Code(new MemoryTool(THprocess,OBSProcess)); break;
                case 13: thCode=new TH14Code(new MemoryTool(THprocess,OBSProcess)); break;
                case 14: thCode=new TH15Code(new MemoryTool(THprocess,OBSProcess)); break;
                case 15: thCode=new TH16Code(new MemoryTool(THprocess,OBSProcess)); break;
                case 16: thCode=new TH165Code(new MemoryTool(THprocess,OBSProcess)); break;
                case 17: thCode=new TH17Code(new MemoryTool(THprocess,OBSProcess)); break;
            }
            Text=thCode.GetTitle();
            instence=this;
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
            timer1.Enabled=true;
        }

        private void timer1_Tick(object sender,EventArgs e) {
            labelX.Text=Convert.ToString(thCode.ProcessX());
            labelY.Text=Convert.ToString(thCode.ProcessY());
        }
    }
}
