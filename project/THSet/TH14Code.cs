using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace THSet {
    public class TH14Code:THCode {
        MemoryTool mt;
        public TH14Code(MemoryTool m) => mt=m;
        public override string GetTitle() => new Random().Next()%2==0 ? "东方掉帧城" : "东方1.6";

        public override float ProcessX() {
            throw new NotImplementedException();
        }

        public override float ProcessY() {
            throw new NotImplementedException();
        } 
    }
}
