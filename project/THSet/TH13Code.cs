using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace THSet {
    public class TH13Code:THCode {
        MemoryTool mt;
        public TH13Code(MemoryTool m) => mt=m;
        public override string GetTitle() => new Random().Next()%2==0 ? "东方崩盘庙" : "东方神灵庙";

        public override float ProcessX() {
            throw new NotImplementedException();
        }

        public override float ProcessY() {
            throw new NotImplementedException();
        } 
    }
}
