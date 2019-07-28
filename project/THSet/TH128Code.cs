using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace THSet {
    public class TH128Code:THCode {
        MemoryTool mt;
        public TH128Code(MemoryTool m) => mt=m;
        public override string GetTitle() => new Random().Next()%2==0 ? "1+1=9" : "妖精大战争";

        public override float ProcessX() {
            throw new NotImplementedException();
        }

        public override float ProcessY() {
            throw new NotImplementedException();
        } 
    }
}
