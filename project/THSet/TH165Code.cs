using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace THSet {
    public class TH165Code:THCode {
        MemoryTool mt;
        public TH165Code(MemoryTool m) => mt=m;
        public override string GetTitle() => new Random().Next()%2==0 ? "蜜蜂bug日记" : "排列与组合";

        public override float ProcessX() {
            throw new NotImplementedException();
        }

        public override float ProcessY() {
            throw new NotImplementedException();
        } 
    }
}
