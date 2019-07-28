using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace THSet {
    public class TH15Code:THCode {
        MemoryTool mt;
        public TH15Code(MemoryTool m) => mt=m;
        public override string GetTitle() => new Random().Next()%2==0 ? "东方跟着转" : "东方199";
        private long baseAddr = 0x004E9BB8;
        public override float ProcessX() {
            float f = mt.ReadGame(baseAddr,0x624)/100;
            float playerMin = -235f;
            float playerMax = 235f;
            float beilv =Convert.ToInt32(MainForm.instence.tbOBSXMax.Text)/(playerMax-playerMin);
            mt.WriteToOBS(Convert.ToInt64(MainForm.instence.tbAddrX.Text,16),(f-playerMin)*beilv);//0x051E1070
            return f;
        }

        public override float ProcessY() {
            float f = mt.ReadGame(baseAddr,0x628)/100;
            float playerMin = 40f;
            float playerMax = 552f;
            float beilv = Convert.ToInt32(MainForm.instence.tbOBSXMax.Text)/(playerMax-playerMin);
            mt.WriteToOBS(Convert.ToInt64(MainForm.instence.tbAddrY.Text,16),(f-playerMin)*beilv);//0x051E1074
            return f;
        }
    }
}
