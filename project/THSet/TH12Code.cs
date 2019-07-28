using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace THSet {
    public class TH12Code:THCode {
        MemoryTool mt;
        public TH12Code(MemoryTool m) => mt=m;
        public override string GetTitle() => new Random().Next()%2==0 ? "春之岸边播放器" : "东方红红蓝";

        public override float ProcessX() {
            throw new NotImplementedException();
        }

        public override float ProcessY() {
            throw new NotImplementedException();
        } 
    }
}
