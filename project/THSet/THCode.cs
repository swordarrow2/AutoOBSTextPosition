using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace THSet {
    public class THCode {

        MemoryTool mt;

        THaddrs addrs;

        private float textMinX;
        private float textSubX;
        private float textMinY;
        private float textSubY;
        private float beilvX;
        private float beilvY;
        private long addrX;
        private long addrY;
        private float plOffsetX = 0;
        private float plOffsetY = 0;

        struct THaddrs {
            public long baseAddr;
            public long offsetX;
            public long offsetY;
            public float playerMinX;
            public float plSubX;
            public float playerMinY;
            public float plSubY;
        }

        public THCode(MemoryTool m,int THnum) {
            mt=m;
            switch(THnum) {
                //        case 7: initTh7(); break;
                //        case 8: initTh8(); break;
                //       case 9: initTh9(); break;
                case 10: initTh10(); break;
                //      case 11: initTh11(); break;
                case 12: initTh12(); break;
                case 128: initTh128(); plOffsetX=143; break;
                case 13: initTh13(); break;
                case 14: initTh14(); break;
                case 15: initTh15(); break;
                case 16: initTh16(); break;
                case 165: initTh165(); plOffsetX=143; break;
                case 17: initTh17(); break;
            }
        }

        public float ProcessX() {
            float posX = mt.ReadGame(addrs.baseAddr,addrs.offsetX);
            mt.WriteToOBS(addrX,(posX-addrs.playerMinX)*beilvX+plOffsetX);//0x051E1070
            return posX;
        }

        public float ProcessY() {
            float posY = mt.ReadGame(addrs.baseAddr,addrs.offsetY);
            mt.WriteToOBS(addrY,(posY-addrs.playerMinY)*beilvY+plOffsetY);//0x051E1074
            return posY;
        }

        public void InitAddr(long addr) {
            addrX=addr;
            addrY=addr+4;
        }

        public void InitText(float minX,float maxX,float minY,float maxY) {
            textSubX=maxX;
            textSubY=maxY;
            beilvX=textSubX/addrs.plSubX;
            beilvY=textSubY/addrs.plSubY;
            plOffsetX=minX;
            plOffsetY=minY;
        }
        /*
        private void initTh7() {
            addrs.baseAddr=0x004B4514;
            addrs.offsetX=0x988;
            addrs.offsetY=addrs.offsetX+4;
            addrs.playerMinX=-23552f;
            addrs.plSubX=23552f+23552f;
            addrs.playerMinY=4096f;
        }
        private void initTh8() {
            addrs.baseAddr=0x017D61AC;
            addrs.offsetX=0;
            addrs.offsetY=addrs.offsetX+4;
            addrs.playerMinX=8f;
            addrs.plSubX=376f-8f;
            addrs.playerMinY=16f;
        }
         private void initTh9() {
                addrs.baseAddr=0x004A7D94;
                addrs.offsetX=0x2C8;
                addrs.offsetY=addrs.offsetX+4;
                addrs.playerMinX=-296f;
                addrs.plSubX=296f+296f;
                addrs.playerMinY=32f;
            }
            */
        private void initTh10() {
            addrs.baseAddr=0x00477834;
            addrs.offsetX=0x3CC;
            addrs.offsetY=addrs.offsetX+4;
            addrs.playerMinX=-18400f;
            addrs.plSubX=18400f-addrs.playerMinX;
            addrs.playerMinY=3200f;
            addrs.plSubY=43200f-addrs.playerMinY;
        }

        private void initTh12() {
            addrs.baseAddr=0x004B4514;
            addrs.offsetX=0x988;
            addrs.offsetY=addrs.offsetX+4;
            addrs.playerMinX=-23552f;
            addrs.plSubX=23552f-addrs.playerMinX;
            addrs.playerMinY=4096f;
            addrs.plSubY=55296f-addrs.playerMinY;
        }

        private void initTh128() {
            addrs.baseAddr=0x004B8A80;
            addrs.offsetX=0xED8;
            addrs.offsetY=addrs.offsetX+4;
            addrs.playerMinX=-23552f;
            addrs.plSubX=23552f-addrs.playerMinX;
            addrs.playerMinY=4096f;
            addrs.plSubY=55296f-addrs.playerMinY;
        }

        private void initTh13() {
            addrs.baseAddr=0x004C22C4;
            addrs.offsetX=0x5C4;
            addrs.offsetY=addrs.offsetX+4;
            addrs.playerMinX=-23552f;
            addrs.plSubX=23552f-addrs.playerMinX;
            addrs.playerMinY=4096f;
            addrs.plSubY=55296f-addrs.playerMinY;
        }

        private void initTh14() {
            addrs.baseAddr=0x004DB67C;
            addrs.offsetX=0x5EC;
            addrs.offsetY=addrs.offsetX+4;
            addrs.playerMinX=-23552f;
            addrs.plSubX=23552f-addrs.playerMinX;
            addrs.playerMinY=4096f;
            addrs.plSubY=55296f-addrs.playerMinY;
        }

        private void initTh15() {
            addrs.baseAddr=0x004E9BB8;
            addrs.offsetX=0x624;
            addrs.offsetY=addrs.offsetX+4;
            addrs.playerMinX=-23552f;
            addrs.plSubX=23552f-addrs.playerMinX;
            addrs.playerMinY=4096f;
            addrs.plSubY=55296f-addrs.playerMinY;
        }
        private void initTh16() {
            addrs.baseAddr=0x004A6EF8;
            addrs.offsetX=0x61C;
            addrs.offsetY=addrs.offsetX+4;
            addrs.playerMinX=-23552f;
            addrs.plSubX=23552f-addrs.playerMinX;
            addrs.playerMinY=4096f;
            addrs.plSubY=55296f-addrs.playerMinY;
        }
        private void initTh165() {
            addrs.baseAddr=0x004B5654;
            addrs.offsetX=0x618;
            addrs.offsetY=addrs.offsetX+4;
            addrs.playerMinX=-23552f;
            addrs.plSubX=23552f-addrs.playerMinX;
            addrs.playerMinY=4096f;
            addrs.plSubY=55296f-addrs.playerMinY;
        }
        private void initTh17() {
            addrs.baseAddr=0x004B33EC;
            addrs.offsetX=0x618;
            addrs.offsetY=0x61C;
            addrs.playerMinX=-23552f;
            addrs.plSubX=23552f-addrs.playerMinX;
            addrs.playerMinY=4096f;
            addrs.plSubY=55296f-addrs.playerMinY;
        }
    }
}
