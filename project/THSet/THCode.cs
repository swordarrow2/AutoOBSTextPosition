using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace THSet {
    public abstract class THCode {
        public abstract string GetTitle();
        public abstract float ProcessX();
        public abstract float ProcessY();
    }
}
