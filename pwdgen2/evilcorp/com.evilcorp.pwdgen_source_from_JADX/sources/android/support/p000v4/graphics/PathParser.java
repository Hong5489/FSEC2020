package android.support.p000v4.graphics;

import android.graphics.Path;
import android.util.Log;
import java.util.ArrayList;

/* renamed from: android.support.v4.graphics.PathParser */
public class PathParser {
    private static final String LOGTAG = "PathParser";

    /* renamed from: android.support.v4.graphics.PathParser$ExtractFloatResult */
    private static class ExtractFloatResult {
        int mEndPosition;
        boolean mEndWithNegOrDot;

        ExtractFloatResult() {
        }
    }

    /* renamed from: android.support.v4.graphics.PathParser$PathDataNode */
    public static class PathDataNode {
        public float[] mParams;
        public char mType;

        PathDataNode(char c, float[] fArr) {
            this.mType = c;
            this.mParams = fArr;
        }

        PathDataNode(PathDataNode pathDataNode) {
            this.mType = pathDataNode.mType;
            float[] fArr = pathDataNode.mParams;
            this.mParams = PathParser.copyOfRange(fArr, 0, fArr.length);
        }

        public static void nodesToPath(PathDataNode[] pathDataNodeArr, Path path) {
            float[] fArr = new float[6];
            char c = 'm';
            for (int i = 0; i < pathDataNodeArr.length; i++) {
                addCommand(path, fArr, c, pathDataNodeArr[i].mType, pathDataNodeArr[i].mParams);
                c = pathDataNodeArr[i].mType;
            }
        }

        public void interpolatePathDataNode(PathDataNode pathDataNode, PathDataNode pathDataNode2, float f) {
            int i = 0;
            while (true) {
                float[] fArr = pathDataNode.mParams;
                if (i < fArr.length) {
                    this.mParams[i] = (fArr[i] * (1.0f - f)) + (pathDataNode2.mParams[i] * f);
                    i++;
                } else {
                    return;
                }
            }
        }

        /* JADX WARNING: Code restructure failed: missing block: B:100:0x0231, code lost:
            r22 = false;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:102:0x0239, code lost:
            if (r12[r9 + 4] == 0.0f) goto L_0x023e;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:103:0x023b, code lost:
            r23 = true;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:104:0x023e, code lost:
            r23 = false;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:105:0x0240, code lost:
            r1 = r8;
            r2 = r7;
            r11 = r7;
            r7 = r15;
            r15 = r8;
            r8 = r22;
            r22 = r9;
            drawArc(r24, r1, r2, r3, r4, r5, r6, r7, r8, r23);
            r8 = r15 + r12[r13];
            r7 = r11 + r12[r14];
         */
        /* JADX WARNING: Code restructure failed: missing block: B:106:0x025a, code lost:
            r22 = r9;
            r9 = r22 + 0;
            r10.lineTo(r8, r12[r9]);
            r7 = r12[r9];
         */
        /* JADX WARNING: Code restructure failed: missing block: B:107:0x0268, code lost:
            r22 = r9;
            r9 = r22 + 0;
            r1 = r22 + 1;
            r3 = r22 + 2;
            r5 = r22 + 3;
            r10.quadTo(r12[r9], r12[r1], r12[r3], r12[r5]);
            r0 = r12[r9];
            r1 = r12[r1];
            r8 = r12[r3];
            r7 = r12[r5];
            r2 = r0;
            r3 = r1;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:108:0x0289, code lost:
            r22 = r9;
            r9 = r22 + 0;
            r10.lineTo(r12[r9], r7);
            r8 = r12[r9];
         */
        /* JADX WARNING: Code restructure failed: missing block: B:109:0x0297, code lost:
            r22 = r9;
            r9 = r22 + 2;
            r7 = r22 + 3;
            r8 = r22 + 4;
            r11 = r22 + 5;
            r0 = r24;
            r0.cubicTo(r12[r22 + 0], r12[r22 + 1], r12[r9], r12[r7], r12[r8], r12[r11]);
            r8 = r12[r8];
            r0 = r12[r11];
            r1 = r12[r9];
            r2 = r12[r7];
            r7 = r0;
            r3 = r2;
            r2 = r1;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:110:0x02c2, code lost:
            r11 = r7;
            r15 = r8;
            r22 = r9;
            r13 = r22 + 5;
            r3 = r12[r13];
            r14 = r22 + 6;
            r4 = r12[r14];
            r5 = r12[r22 + 0];
            r6 = r12[r22 + 1];
            r7 = r12[r22 + 2];
         */
        /* JADX WARNING: Code restructure failed: missing block: B:111:0x02e1, code lost:
            if (r12[r22 + 3] == 0.0f) goto L_0x02e5;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:112:0x02e3, code lost:
            r8 = true;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:113:0x02e5, code lost:
            r8 = false;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:115:0x02ec, code lost:
            if (r12[r22 + 4] == 0.0f) goto L_0x02f0;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:116:0x02ee, code lost:
            r9 = true;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:117:0x02f0, code lost:
            r9 = false;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:118:0x02f1, code lost:
            drawArc(r24, r15, r11, r3, r4, r5, r6, r7, r8, r9);
            r8 = r12[r13];
            r7 = r12[r14];
         */
        /* JADX WARNING: Code restructure failed: missing block: B:119:0x02fc, code lost:
            r3 = r7;
            r2 = r8;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:11:0x0041, code lost:
            if (r9 >= r12.length) goto L_0x0308;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:120:0x02fe, code lost:
            r9 = r22 + r19;
            r0 = r27;
            r11 = r0;
            r13 = 0;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:121:0x0308, code lost:
            r11 = r7;
            r25[r13] = r8;
            r25[1] = r11;
            r25[2] = r2;
            r25[3] = r3;
            r25[4] = r20;
            r25[5] = r21;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:122:0x0319, code lost:
            return;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:13:0x0045, code lost:
            if (r11 == 'A') goto L_0x02c2;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:15:0x0049, code lost:
            if (r11 == 'C') goto L_0x0297;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:17:0x004d, code lost:
            if (r11 == 'H') goto L_0x0289;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:19:0x0051, code lost:
            if (r11 == 'Q') goto L_0x0268;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:21:0x0055, code lost:
            if (r11 == 'V') goto L_0x025a;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:23:0x0059, code lost:
            if (r11 == 'a') goto L_0x020d;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:25:0x005d, code lost:
            if (r11 == 'c') goto L_0x01e0;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:27:0x0061, code lost:
            if (r11 == 'h') goto L_0x01d3;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:29:0x0065, code lost:
            if (r11 == 'q') goto L_0x01b4;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:2:0x001e, code lost:
            r19 = 2;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:31:0x0069, code lost:
            if (r11 == 'v') goto L_0x01a8;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:33:0x006d, code lost:
            if (r11 == 'L') goto L_0x0197;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:35:0x0071, code lost:
            if (r11 == 'M') goto L_0x0177;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:37:0x0077, code lost:
            if (r11 == 'S') goto L_0x0146;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:39:0x007b, code lost:
            if (r11 == 'T') goto L_0x011f;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:41:0x007f, code lost:
            if (r11 == 'l') goto L_0x010c;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:43:0x0083, code lost:
            if (r11 == 'm') goto L_0x00ef;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:45:0x0087, code lost:
            if (r11 == 's') goto L_0x00b9;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:47:0x008b, code lost:
            if (r11 == 't') goto L_0x0091;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:48:0x008d, code lost:
            r22 = r9;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:49:0x0091, code lost:
            if (r0 == 'q') goto L_0x009f;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:51:0x0095, code lost:
            if (r0 == 't') goto L_0x009f;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:52:0x0097, code lost:
            if (r0 == 'Q') goto L_0x009f;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:53:0x0099, code lost:
            if (r0 != 'T') goto L_0x009c;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:54:0x009c, code lost:
            r0 = 0.0f;
            r4 = 0.0f;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:55:0x009f, code lost:
            r4 = r8 - r2;
            r0 = r7 - r3;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:56:0x00a3, code lost:
            r1 = r9 + 0;
            r3 = r9 + 1;
            r10.rQuadTo(r4, r0, r12[r1], r12[r3]);
            r4 = r4 + r8;
            r0 = r0 + r7;
            r8 = r8 + r12[r1];
            r7 = r7 + r12[r3];
            r3 = r0;
            r2 = r4;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:57:0x00b9, code lost:
            if (r0 == 'c') goto L_0x00c7;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:59:0x00bd, code lost:
            if (r0 == 's') goto L_0x00c7;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:60:0x00bf, code lost:
            if (r0 == 'C') goto L_0x00c7;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:61:0x00c1, code lost:
            if (r0 != 'S') goto L_0x00c4;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:62:0x00c4, code lost:
            r1 = 0.0f;
            r2 = 0.0f;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:63:0x00c7, code lost:
            r0 = r8 - r2;
            r2 = r7 - r3;
            r1 = r0;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:64:0x00cd, code lost:
            r13 = r9 + 0;
            r14 = r9 + 1;
            r15 = r9 + 2;
            r22 = r9 + 3;
            r24.rCubicTo(r1, r2, r12[r13], r12[r14], r12[r15], r12[r22]);
            r0 = r12[r13] + r8;
            r1 = r12[r14] + r7;
            r8 = r8 + r12[r15];
            r2 = r12[r22];
         */
        /* JADX WARNING: Code restructure failed: missing block: B:65:0x00ef, code lost:
            r0 = r9 + 0;
            r8 = r8 + r12[r0];
            r1 = r9 + 1;
            r7 = r7 + r12[r1];
         */
        /* JADX WARNING: Code restructure failed: missing block: B:66:0x00f9, code lost:
            if (r9 <= 0) goto L_0x0103;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:67:0x00fb, code lost:
            r10.rLineTo(r12[r0], r12[r1]);
         */
        /* JADX WARNING: Code restructure failed: missing block: B:68:0x0103, code lost:
            r10.rMoveTo(r12[r0], r12[r1]);
         */
        /* JADX WARNING: Code restructure failed: missing block: B:69:0x010c, code lost:
            r0 = r9 + 0;
            r4 = r9 + 1;
            r10.rLineTo(r12[r0], r12[r4]);
            r8 = r8 + r12[r0];
            r0 = r12[r4];
         */
        /* JADX WARNING: Code restructure failed: missing block: B:70:0x011c, code lost:
            r7 = r7 + r0;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:71:0x011f, code lost:
            if (r0 == 'q') goto L_0x0129;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:73:0x0123, code lost:
            if (r0 == 't') goto L_0x0129;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:74:0x0125, code lost:
            if (r0 == 'Q') goto L_0x0129;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:75:0x0127, code lost:
            if (r0 != 'T') goto L_0x012f;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:76:0x0129, code lost:
            r8 = (r8 * 2.0f) - r2;
            r7 = (r7 * 2.0f) - r3;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:77:0x012f, code lost:
            r0 = r9 + 0;
            r2 = r9 + 1;
            r10.quadTo(r8, r7, r12[r0], r12[r2]);
            r0 = r12[r0];
            r1 = r12[r2];
            r3 = r7;
            r2 = r8;
            r22 = r9;
            r8 = r0;
            r7 = r1;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:78:0x0146, code lost:
            if (r0 == 'c') goto L_0x0150;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:80:0x014a, code lost:
            if (r0 == 's') goto L_0x0150;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:81:0x014c, code lost:
            if (r0 == 'C') goto L_0x0150;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:82:0x014e, code lost:
            if (r0 != 'S') goto L_0x0156;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:83:0x0150, code lost:
            r8 = (r8 * 2.0f) - r2;
            r7 = (r7 * 2.0f) - r3;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:84:0x0156, code lost:
            r2 = r7;
            r7 = r9 + 0;
            r8 = r9 + 1;
            r13 = r9 + 2;
            r14 = r9 + 3;
            r24.cubicTo(r8, r2, r12[r7], r12[r8], r12[r13], r12[r14]);
            r0 = r12[r7];
            r1 = r12[r8];
            r8 = r12[r13];
            r7 = r12[r14];
         */
        /* JADX WARNING: Code restructure failed: missing block: B:85:0x0177, code lost:
            r0 = r9 + 0;
            r8 = r12[r0];
            r1 = r9 + 1;
            r7 = r12[r1];
         */
        /* JADX WARNING: Code restructure failed: missing block: B:86:0x017f, code lost:
            if (r9 <= 0) goto L_0x018a;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:87:0x0181, code lost:
            r10.lineTo(r12[r0], r12[r1]);
         */
        /* JADX WARNING: Code restructure failed: missing block: B:88:0x018a, code lost:
            r10.moveTo(r12[r0], r12[r1]);
         */
        /* JADX WARNING: Code restructure failed: missing block: B:89:0x0191, code lost:
            r21 = r7;
            r20 = r8;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:8:0x0035, code lost:
            r19 = r6;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:90:0x0197, code lost:
            r0 = r9 + 0;
            r4 = r9 + 1;
            r10.lineTo(r12[r0], r12[r4]);
            r8 = r12[r0];
            r7 = r12[r4];
         */
        /* JADX WARNING: Code restructure failed: missing block: B:91:0x01a8, code lost:
            r0 = r9 + 0;
            r10.rLineTo(0.0f, r12[r0]);
            r0 = r12[r0];
         */
        /* JADX WARNING: Code restructure failed: missing block: B:92:0x01b4, code lost:
            r0 = r9 + 0;
            r2 = r9 + 1;
            r4 = r9 + 2;
            r6 = r9 + 3;
            r10.rQuadTo(r12[r0], r12[r2], r12[r4], r12[r6]);
            r0 = r12[r0] + r8;
            r1 = r12[r2] + r7;
            r8 = r8 + r12[r4];
            r2 = r12[r6];
         */
        /* JADX WARNING: Code restructure failed: missing block: B:93:0x01d3, code lost:
            r0 = r9 + 0;
            r10.rLineTo(r12[r0], 0.0f);
            r8 = r8 + r12[r0];
         */
        /* JADX WARNING: Code restructure failed: missing block: B:94:0x01e0, code lost:
            r13 = r9 + 2;
            r14 = r9 + 3;
            r15 = r9 + 4;
            r22 = r9 + 5;
            r24.rCubicTo(r12[r9 + 0], r12[r9 + 1], r12[r13], r12[r14], r12[r15], r12[r22]);
            r0 = r12[r13] + r8;
            r1 = r12[r14] + r7;
            r8 = r8 + r12[r15];
            r2 = r12[r22];
         */
        /* JADX WARNING: Code restructure failed: missing block: B:95:0x0208, code lost:
            r7 = r7 + r2;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:96:0x0209, code lost:
            r2 = r0;
            r3 = r1;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:97:0x020d, code lost:
            r13 = r9 + 5;
            r3 = r12[r13] + r8;
            r14 = r9 + 6;
            r4 = r12[r14] + r7;
            r5 = r12[r9 + 0];
            r6 = r12[r9 + 1];
            r15 = r12[r9 + 2];
         */
        /* JADX WARNING: Code restructure failed: missing block: B:98:0x022c, code lost:
            if (r12[r9 + 3] == 0.0f) goto L_0x0231;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:99:0x022e, code lost:
            r22 = true;
         */
        /* JADX WARNING: Code restructure failed: missing block: B:9:0x0037, code lost:
            r8 = r0;
            r7 = r1;
            r20 = r4;
            r21 = r5;
            r9 = 0;
            r0 = r26;
         */
        /* Code decompiled incorrectly, please refer to instructions dump. */
        private static void addCommand(android.graphics.Path r24, float[] r25, char r26, char r27, float[] r28) {
            /*
                r10 = r24
                r11 = r27
                r12 = r28
                r13 = 0
                r0 = r25[r13]
                r14 = 1
                r1 = r25[r14]
                r15 = 2
                r2 = r25[r15]
                r16 = 3
                r3 = r25[r16]
                r17 = 4
                r4 = r25[r17]
                r18 = 5
                r5 = r25[r18]
                switch(r11) {
                    case 65: goto L_0x0034;
                    case 67: goto L_0x0032;
                    case 72: goto L_0x002f;
                    case 76: goto L_0x001e;
                    case 77: goto L_0x001e;
                    case 81: goto L_0x002c;
                    case 83: goto L_0x002c;
                    case 84: goto L_0x001e;
                    case 86: goto L_0x002f;
                    case 90: goto L_0x0021;
                    case 97: goto L_0x0034;
                    case 99: goto L_0x0032;
                    case 104: goto L_0x002f;
                    case 108: goto L_0x001e;
                    case 109: goto L_0x001e;
                    case 113: goto L_0x002c;
                    case 115: goto L_0x002c;
                    case 116: goto L_0x001e;
                    case 118: goto L_0x002f;
                    case 122: goto L_0x0021;
                    default: goto L_0x001e;
                }
            L_0x001e:
                r19 = r15
                goto L_0x0037
            L_0x0021:
                r24.close()
                r10.moveTo(r4, r5)
                r0 = r4
                r2 = r0
                r1 = r5
                r3 = r1
                goto L_0x001e
            L_0x002c:
                r19 = r17
                goto L_0x0037
            L_0x002f:
                r19 = r14
                goto L_0x0037
            L_0x0032:
                r6 = 6
                goto L_0x0035
            L_0x0034:
                r6 = 7
            L_0x0035:
                r19 = r6
            L_0x0037:
                r8 = r0
                r7 = r1
                r20 = r4
                r21 = r5
                r9 = r13
                r0 = r26
            L_0x0040:
                int r1 = r12.length
                if (r9 >= r1) goto L_0x0308
                r1 = 65
                if (r11 == r1) goto L_0x02c2
                r1 = 67
                if (r11 == r1) goto L_0x0297
                r5 = 72
                if (r11 == r5) goto L_0x0289
                r5 = 81
                if (r11 == r5) goto L_0x0268
                r6 = 86
                if (r11 == r6) goto L_0x025a
                r6 = 97
                if (r11 == r6) goto L_0x020d
                r6 = 99
                if (r11 == r6) goto L_0x01e0
                r15 = 104(0x68, float:1.46E-43)
                if (r11 == r15) goto L_0x01d3
                r15 = 113(0x71, float:1.58E-43)
                if (r11 == r15) goto L_0x01b4
                r14 = 118(0x76, float:1.65E-43)
                if (r11 == r14) goto L_0x01a8
                r14 = 76
                if (r11 == r14) goto L_0x0197
                r14 = 77
                if (r11 == r14) goto L_0x0177
                r14 = 83
                r22 = 1073741824(0x40000000, float:2.0)
                if (r11 == r14) goto L_0x0146
                r13 = 84
                if (r11 == r13) goto L_0x011f
                r4 = 108(0x6c, float:1.51E-43)
                if (r11 == r4) goto L_0x010c
                r4 = 109(0x6d, float:1.53E-43)
                if (r11 == r4) goto L_0x00ef
                r4 = 115(0x73, float:1.61E-43)
                if (r11 == r4) goto L_0x00b9
                r1 = 116(0x74, float:1.63E-43)
                if (r11 == r1) goto L_0x0091
            L_0x008d:
                r22 = r9
                goto L_0x02fe
            L_0x0091:
                if (r0 == r15) goto L_0x009f
                r1 = 116(0x74, float:1.63E-43)
                if (r0 == r1) goto L_0x009f
                if (r0 == r5) goto L_0x009f
                if (r0 != r13) goto L_0x009c
                goto L_0x009f
            L_0x009c:
                r0 = 0
                r4 = 0
                goto L_0x00a3
            L_0x009f:
                float r4 = r8 - r2
                float r0 = r7 - r3
            L_0x00a3:
                int r1 = r9 + 0
                r2 = r12[r1]
                int r3 = r9 + 1
                r5 = r12[r3]
                r10.rQuadTo(r4, r0, r2, r5)
                float r4 = r4 + r8
                float r0 = r0 + r7
                r1 = r12[r1]
                float r8 = r8 + r1
                r1 = r12[r3]
                float r7 = r7 + r1
                r3 = r0
                r2 = r4
                goto L_0x008d
            L_0x00b9:
                if (r0 == r6) goto L_0x00c7
                r4 = 115(0x73, float:1.61E-43)
                if (r0 == r4) goto L_0x00c7
                if (r0 == r1) goto L_0x00c7
                if (r0 != r14) goto L_0x00c4
                goto L_0x00c7
            L_0x00c4:
                r1 = 0
                r2 = 0
                goto L_0x00cd
            L_0x00c7:
                float r0 = r8 - r2
                float r1 = r7 - r3
                r2 = r1
                r1 = r0
            L_0x00cd:
                int r13 = r9 + 0
                r3 = r12[r13]
                int r14 = r9 + 1
                r4 = r12[r14]
                int r15 = r9 + 2
                r5 = r12[r15]
                int r22 = r9 + 3
                r6 = r12[r22]
                r0 = r24
                r0.rCubicTo(r1, r2, r3, r4, r5, r6)
                r0 = r12[r13]
                float r0 = r0 + r8
                r1 = r12[r14]
                float r1 = r1 + r7
                r2 = r12[r15]
                float r8 = r8 + r2
                r2 = r12[r22]
                goto L_0x0208
            L_0x00ef:
                int r0 = r9 + 0
                r1 = r12[r0]
                float r8 = r8 + r1
                int r1 = r9 + 1
                r4 = r12[r1]
                float r7 = r7 + r4
                if (r9 <= 0) goto L_0x0103
                r0 = r12[r0]
                r1 = r12[r1]
                r10.rLineTo(r0, r1)
                goto L_0x008d
            L_0x0103:
                r0 = r12[r0]
                r1 = r12[r1]
                r10.rMoveTo(r0, r1)
                goto L_0x0191
            L_0x010c:
                int r0 = r9 + 0
                r1 = r12[r0]
                int r4 = r9 + 1
                r5 = r12[r4]
                r10.rLineTo(r1, r5)
                r0 = r12[r0]
                float r8 = r8 + r0
                r0 = r12[r4]
            L_0x011c:
                float r7 = r7 + r0
                goto L_0x008d
            L_0x011f:
                if (r0 == r15) goto L_0x0129
                r1 = 116(0x74, float:1.63E-43)
                if (r0 == r1) goto L_0x0129
                if (r0 == r5) goto L_0x0129
                if (r0 != r13) goto L_0x012f
            L_0x0129:
                float r8 = r8 * r22
                float r8 = r8 - r2
                float r7 = r7 * r22
                float r7 = r7 - r3
            L_0x012f:
                int r0 = r9 + 0
                r1 = r12[r0]
                int r2 = r9 + 1
                r3 = r12[r2]
                r10.quadTo(r8, r7, r1, r3)
                r0 = r12[r0]
                r1 = r12[r2]
                r3 = r7
                r2 = r8
                r22 = r9
                r8 = r0
                r7 = r1
                goto L_0x02fe
            L_0x0146:
                if (r0 == r6) goto L_0x0150
                r4 = 115(0x73, float:1.61E-43)
                if (r0 == r4) goto L_0x0150
                if (r0 == r1) goto L_0x0150
                if (r0 != r14) goto L_0x0156
            L_0x0150:
                float r8 = r8 * r22
                float r8 = r8 - r2
                float r7 = r7 * r22
                float r7 = r7 - r3
            L_0x0156:
                r2 = r7
                r1 = r8
                int r7 = r9 + 0
                r3 = r12[r7]
                int r8 = r9 + 1
                r4 = r12[r8]
                int r13 = r9 + 2
                r5 = r12[r13]
                int r14 = r9 + 3
                r6 = r12[r14]
                r0 = r24
                r0.cubicTo(r1, r2, r3, r4, r5, r6)
                r0 = r12[r7]
                r1 = r12[r8]
                r8 = r12[r13]
                r7 = r12[r14]
                goto L_0x0209
            L_0x0177:
                int r0 = r9 + 0
                r8 = r12[r0]
                int r1 = r9 + 1
                r7 = r12[r1]
                if (r9 <= 0) goto L_0x018a
                r0 = r12[r0]
                r1 = r12[r1]
                r10.lineTo(r0, r1)
                goto L_0x008d
            L_0x018a:
                r0 = r12[r0]
                r1 = r12[r1]
                r10.moveTo(r0, r1)
            L_0x0191:
                r21 = r7
                r20 = r8
                goto L_0x008d
            L_0x0197:
                int r0 = r9 + 0
                r1 = r12[r0]
                int r4 = r9 + 1
                r5 = r12[r4]
                r10.lineTo(r1, r5)
                r8 = r12[r0]
                r7 = r12[r4]
                goto L_0x008d
            L_0x01a8:
                int r0 = r9 + 0
                r1 = r12[r0]
                r4 = 0
                r10.rLineTo(r4, r1)
                r0 = r12[r0]
                goto L_0x011c
            L_0x01b4:
                int r0 = r9 + 0
                r1 = r12[r0]
                int r2 = r9 + 1
                r3 = r12[r2]
                int r4 = r9 + 2
                r5 = r12[r4]
                int r6 = r9 + 3
                r13 = r12[r6]
                r10.rQuadTo(r1, r3, r5, r13)
                r0 = r12[r0]
                float r0 = r0 + r8
                r1 = r12[r2]
                float r1 = r1 + r7
                r2 = r12[r4]
                float r8 = r8 + r2
                r2 = r12[r6]
                goto L_0x0208
            L_0x01d3:
                int r0 = r9 + 0
                r1 = r12[r0]
                r4 = 0
                r10.rLineTo(r1, r4)
                r0 = r12[r0]
                float r8 = r8 + r0
                goto L_0x008d
            L_0x01e0:
                int r0 = r9 + 0
                r1 = r12[r0]
                int r0 = r9 + 1
                r2 = r12[r0]
                int r13 = r9 + 2
                r3 = r12[r13]
                int r14 = r9 + 3
                r4 = r12[r14]
                int r15 = r9 + 4
                r5 = r12[r15]
                int r22 = r9 + 5
                r6 = r12[r22]
                r0 = r24
                r0.rCubicTo(r1, r2, r3, r4, r5, r6)
                r0 = r12[r13]
                float r0 = r0 + r8
                r1 = r12[r14]
                float r1 = r1 + r7
                r2 = r12[r15]
                float r8 = r8 + r2
                r2 = r12[r22]
            L_0x0208:
                float r7 = r7 + r2
            L_0x0209:
                r2 = r0
                r3 = r1
                goto L_0x008d
            L_0x020d:
                int r13 = r9 + 5
                r0 = r12[r13]
                float r3 = r0 + r8
                int r14 = r9 + 6
                r0 = r12[r14]
                float r4 = r0 + r7
                int r0 = r9 + 0
                r5 = r12[r0]
                int r0 = r9 + 1
                r6 = r12[r0]
                int r0 = r9 + 2
                r15 = r12[r0]
                int r0 = r9 + 3
                r0 = r12[r0]
                r1 = 0
                int r0 = (r0 > r1 ? 1 : (r0 == r1 ? 0 : -1))
                if (r0 == 0) goto L_0x0231
                r22 = 1
                goto L_0x0233
            L_0x0231:
                r22 = 0
            L_0x0233:
                int r0 = r9 + 4
                r0 = r12[r0]
                int r0 = (r0 > r1 ? 1 : (r0 == r1 ? 0 : -1))
                if (r0 == 0) goto L_0x023e
                r23 = 1
                goto L_0x0240
            L_0x023e:
                r23 = 0
            L_0x0240:
                r0 = r24
                r1 = r8
                r2 = r7
                r11 = r7
                r7 = r15
                r15 = r8
                r8 = r22
                r22 = r9
                r9 = r23
                drawArc(r0, r1, r2, r3, r4, r5, r6, r7, r8, r9)
                r0 = r12[r13]
                float r8 = r15 + r0
                r0 = r12[r14]
                float r7 = r11 + r0
                goto L_0x02fc
            L_0x025a:
                r15 = r8
                r22 = r9
                int r9 = r22 + 0
                r0 = r12[r9]
                r10.lineTo(r15, r0)
                r7 = r12[r9]
                goto L_0x02fe
            L_0x0268:
                r22 = r9
                int r9 = r22 + 0
                r0 = r12[r9]
                int r1 = r22 + 1
                r2 = r12[r1]
                int r3 = r22 + 2
                r4 = r12[r3]
                int r5 = r22 + 3
                r6 = r12[r5]
                r10.quadTo(r0, r2, r4, r6)
                r0 = r12[r9]
                r1 = r12[r1]
                r8 = r12[r3]
                r7 = r12[r5]
                r2 = r0
                r3 = r1
                goto L_0x02fe
            L_0x0289:
                r11 = r7
                r22 = r9
                int r9 = r22 + 0
                r0 = r12[r9]
                r10.lineTo(r0, r11)
                r8 = r12[r9]
                goto L_0x02fe
            L_0x0297:
                r22 = r9
                int r9 = r22 + 0
                r1 = r12[r9]
                int r9 = r22 + 1
                r2 = r12[r9]
                int r9 = r22 + 2
                r3 = r12[r9]
                int r7 = r22 + 3
                r4 = r12[r7]
                int r8 = r22 + 4
                r5 = r12[r8]
                int r11 = r22 + 5
                r6 = r12[r11]
                r0 = r24
                r0.cubicTo(r1, r2, r3, r4, r5, r6)
                r8 = r12[r8]
                r0 = r12[r11]
                r1 = r12[r9]
                r2 = r12[r7]
                r7 = r0
                r3 = r2
                r2 = r1
                goto L_0x02fe
            L_0x02c2:
                r11 = r7
                r15 = r8
                r22 = r9
                int r13 = r22 + 5
                r3 = r12[r13]
                int r14 = r22 + 6
                r4 = r12[r14]
                int r9 = r22 + 0
                r5 = r12[r9]
                int r9 = r22 + 1
                r6 = r12[r9]
                int r9 = r22 + 2
                r7 = r12[r9]
                int r9 = r22 + 3
                r0 = r12[r9]
                r1 = 0
                int r0 = (r0 > r1 ? 1 : (r0 == r1 ? 0 : -1))
                if (r0 == 0) goto L_0x02e5
                r8 = 1
                goto L_0x02e6
            L_0x02e5:
                r8 = 0
            L_0x02e6:
                int r9 = r22 + 4
                r0 = r12[r9]
                int r0 = (r0 > r1 ? 1 : (r0 == r1 ? 0 : -1))
                if (r0 == 0) goto L_0x02f0
                r9 = 1
                goto L_0x02f1
            L_0x02f0:
                r9 = 0
            L_0x02f1:
                r0 = r24
                r1 = r15
                r2 = r11
                drawArc(r0, r1, r2, r3, r4, r5, r6, r7, r8, r9)
                r8 = r12[r13]
                r7 = r12[r14]
            L_0x02fc:
                r3 = r7
                r2 = r8
            L_0x02fe:
                int r9 = r22 + r19
                r0 = r27
                r11 = r0
                r13 = 0
                r14 = 1
                r15 = 2
                goto L_0x0040
            L_0x0308:
                r11 = r7
                r15 = r8
                r0 = r13
                r25[r0] = r15
                r0 = 1
                r25[r0] = r11
                r0 = 2
                r25[r0] = r2
                r25[r16] = r3
                r25[r17] = r20
                r25[r18] = r21
                return
            */
            throw new UnsupportedOperationException("Method not decompiled: android.support.p000v4.graphics.PathParser.PathDataNode.addCommand(android.graphics.Path, float[], char, char, float[]):void");
        }

        private static void drawArc(Path path, float f, float f2, float f3, float f4, float f5, float f6, float f7, boolean z, boolean z2) {
            double d;
            double d2;
            float f8 = f;
            float f9 = f3;
            float f10 = f5;
            float f11 = f6;
            boolean z3 = z2;
            double radians = Math.toRadians((double) f7);
            double cos = Math.cos(radians);
            double sin = Math.sin(radians);
            double d3 = (double) f8;
            double d4 = d3 * cos;
            double d5 = d3;
            double d6 = (double) f2;
            double d7 = (double) f10;
            double d8 = (d4 + (d6 * sin)) / d7;
            double d9 = (((double) (-f8)) * sin) + (d6 * cos);
            double d10 = d6;
            double d11 = (double) f11;
            double d12 = d9 / d11;
            double d13 = (double) f4;
            double d14 = ((((double) f9) * cos) + (d13 * sin)) / d7;
            double d15 = d7;
            double d16 = ((((double) (-f9)) * sin) + (d13 * cos)) / d11;
            double d17 = d8 - d14;
            double d18 = d12 - d16;
            double d19 = (d8 + d14) / 2.0d;
            double d20 = (d12 + d16) / 2.0d;
            double d21 = sin;
            double d22 = (d17 * d17) + (d18 * d18);
            int i = (d22 > 0.0d ? 1 : (d22 == 0.0d ? 0 : -1));
            String str = PathParser.LOGTAG;
            if (i == 0) {
                Log.w(str, " Points are coincident");
                return;
            }
            double d23 = (1.0d / d22) - 0.25d;
            if (d23 < 0.0d) {
                StringBuilder sb = new StringBuilder();
                sb.append("Points are too far apart ");
                sb.append(d22);
                Log.w(str, sb.toString());
                float sqrt = (float) (Math.sqrt(d22) / 1.99999d);
                drawArc(path, f, f2, f3, f4, f10 * sqrt, f6 * sqrt, f7, z, z2);
                return;
            }
            double sqrt2 = Math.sqrt(d23);
            double d24 = d17 * sqrt2;
            double d25 = sqrt2 * d18;
            boolean z4 = z2;
            if (z == z4) {
                d2 = d19 - d25;
                d = d20 + d24;
            } else {
                d2 = d19 + d25;
                d = d20 - d24;
            }
            double atan2 = Math.atan2(d12 - d, d8 - d2);
            double atan22 = Math.atan2(d16 - d, d14 - d2) - atan2;
            int i2 = (atan22 > 0.0d ? 1 : (atan22 == 0.0d ? 0 : -1));
            if (z4 != (i2 >= 0)) {
                atan22 = i2 > 0 ? atan22 - 6.283185307179586d : atan22 + 6.283185307179586d;
            }
            double d26 = d2 * d15;
            double d27 = d * d11;
            arcToBezier(path, (d26 * cos) - (d27 * d21), (d26 * d21) + (d27 * cos), d15, d11, d5, d10, radians, atan2, atan22);
        }

        private static void arcToBezier(Path path, double d, double d2, double d3, double d4, double d5, double d6, double d7, double d8, double d9) {
            double d10 = d3;
            int ceil = (int) Math.ceil(Math.abs((d9 * 4.0d) / 3.141592653589793d));
            double cos = Math.cos(d7);
            double sin = Math.sin(d7);
            double cos2 = Math.cos(d8);
            double sin2 = Math.sin(d8);
            double d11 = -d10;
            double d12 = d11 * cos;
            double d13 = d4 * sin;
            double d14 = (d12 * sin2) - (d13 * cos2);
            double d15 = d11 * sin;
            double d16 = d4 * cos;
            double d17 = (sin2 * d15) + (cos2 * d16);
            double d18 = d9 / ((double) ceil);
            double d19 = d6;
            double d20 = d17;
            double d21 = d14;
            int i = 0;
            double d22 = d5;
            double d23 = d8;
            while (i < ceil) {
                double d24 = d23 + d18;
                double sin3 = Math.sin(d24);
                double cos3 = Math.cos(d24);
                double d25 = (d + ((d10 * cos) * cos3)) - (d13 * sin3);
                double d26 = d2 + (d10 * sin * cos3) + (d16 * sin3);
                double d27 = (d12 * sin3) - (d13 * cos3);
                double d28 = (sin3 * d15) + (cos3 * d16);
                double d29 = d24 - d23;
                double tan = Math.tan(d29 / 2.0d);
                double sin4 = (Math.sin(d29) * (Math.sqrt(((tan * 3.0d) * tan) + 4.0d) - 1.0d)) / 3.0d;
                int i2 = ceil;
                double d30 = cos;
                double d31 = d22 + (d21 * sin4);
                double d32 = sin;
                double d33 = d19 + (d20 * sin4);
                double d34 = d18;
                double d35 = d25 - (sin4 * d27);
                int i3 = i2;
                double d36 = d15;
                double d37 = d26 - (sin4 * d28);
                path.rLineTo(0.0f, 0.0f);
                path.cubicTo((float) d31, (float) d33, (float) d35, (float) d37, (float) d25, (float) d26);
                i++;
                d18 = d34;
                ceil = i3;
                sin = d32;
                d19 = d26;
                d15 = d36;
                d23 = d24;
                d20 = d28;
                d21 = d27;
                cos = d30;
                d10 = d3;
                d22 = d25;
            }
        }
    }

    static float[] copyOfRange(float[] fArr, int i, int i2) {
        if (i <= i2) {
            int length = fArr.length;
            if (i < 0 || i > length) {
                throw new ArrayIndexOutOfBoundsException();
            }
            int i3 = i2 - i;
            int min = Math.min(i3, length - i);
            float[] fArr2 = new float[i3];
            System.arraycopy(fArr, i, fArr2, 0, min);
            return fArr2;
        }
        throw new IllegalArgumentException();
    }

    public static Path createPathFromPathData(String str) {
        Path path = new Path();
        PathDataNode[] createNodesFromPathData = createNodesFromPathData(str);
        if (createNodesFromPathData == null) {
            return null;
        }
        try {
            PathDataNode.nodesToPath(createNodesFromPathData, path);
            return path;
        } catch (RuntimeException e) {
            StringBuilder sb = new StringBuilder();
            sb.append("Error in parsing ");
            sb.append(str);
            throw new RuntimeException(sb.toString(), e);
        }
    }

    public static PathDataNode[] createNodesFromPathData(String str) {
        if (str == null) {
            return null;
        }
        ArrayList arrayList = new ArrayList();
        int i = 1;
        int i2 = 0;
        while (i < str.length()) {
            int nextStart = nextStart(str, i);
            String trim = str.substring(i2, nextStart).trim();
            if (trim.length() > 0) {
                addNode(arrayList, trim.charAt(0), getFloats(trim));
            }
            i2 = nextStart;
            i = nextStart + 1;
        }
        if (i - i2 == 1 && i2 < str.length()) {
            addNode(arrayList, str.charAt(i2), new float[0]);
        }
        return (PathDataNode[]) arrayList.toArray(new PathDataNode[arrayList.size()]);
    }

    public static PathDataNode[] deepCopyNodes(PathDataNode[] pathDataNodeArr) {
        if (pathDataNodeArr == null) {
            return null;
        }
        PathDataNode[] pathDataNodeArr2 = new PathDataNode[pathDataNodeArr.length];
        for (int i = 0; i < pathDataNodeArr.length; i++) {
            pathDataNodeArr2[i] = new PathDataNode(pathDataNodeArr[i]);
        }
        return pathDataNodeArr2;
    }

    public static boolean canMorph(PathDataNode[] pathDataNodeArr, PathDataNode[] pathDataNodeArr2) {
        if (pathDataNodeArr == null || pathDataNodeArr2 == null || pathDataNodeArr.length != pathDataNodeArr2.length) {
            return false;
        }
        for (int i = 0; i < pathDataNodeArr.length; i++) {
            if (pathDataNodeArr[i].mType != pathDataNodeArr2[i].mType || pathDataNodeArr[i].mParams.length != pathDataNodeArr2[i].mParams.length) {
                return false;
            }
        }
        return true;
    }

    public static void updateNodes(PathDataNode[] pathDataNodeArr, PathDataNode[] pathDataNodeArr2) {
        for (int i = 0; i < pathDataNodeArr2.length; i++) {
            pathDataNodeArr[i].mType = pathDataNodeArr2[i].mType;
            for (int i2 = 0; i2 < pathDataNodeArr2[i].mParams.length; i2++) {
                pathDataNodeArr[i].mParams[i2] = pathDataNodeArr2[i].mParams[i2];
            }
        }
    }

    private static int nextStart(String str, int i) {
        while (i < str.length()) {
            char charAt = str.charAt(i);
            if (((charAt - 'A') * (charAt - 'Z') <= 0 || (charAt - 'a') * (charAt - 'z') <= 0) && charAt != 'e' && charAt != 'E') {
                return i;
            }
            i++;
        }
        return i;
    }

    private static void addNode(ArrayList<PathDataNode> arrayList, char c, float[] fArr) {
        arrayList.add(new PathDataNode(c, fArr));
    }

    private static float[] getFloats(String str) {
        if (str.charAt(0) == 'z' || str.charAt(0) == 'Z') {
            return new float[0];
        }
        try {
            float[] fArr = new float[str.length()];
            ExtractFloatResult extractFloatResult = new ExtractFloatResult();
            int length = str.length();
            int i = 1;
            int i2 = 0;
            while (i < length) {
                extract(str, i, extractFloatResult);
                int i3 = extractFloatResult.mEndPosition;
                if (i < i3) {
                    int i4 = i2 + 1;
                    fArr[i2] = Float.parseFloat(str.substring(i, i3));
                    i2 = i4;
                }
                i = extractFloatResult.mEndWithNegOrDot ? i3 : i3 + 1;
            }
            return copyOfRange(fArr, 0, i2);
        } catch (NumberFormatException e) {
            StringBuilder sb = new StringBuilder();
            sb.append("error in parsing \"");
            sb.append(str);
            sb.append("\"");
            throw new RuntimeException(sb.toString(), e);
        }
    }

    /* JADX WARNING: Code restructure failed: missing block: B:16:0x0031, code lost:
        r2 = false;
     */
    /* JADX WARNING: Removed duplicated region for block: B:20:0x003a A[LOOP:0: B:1:0x0007->B:20:0x003a, LOOP_END] */
    /* JADX WARNING: Removed duplicated region for block: B:24:0x003d A[SYNTHETIC] */
    /* Code decompiled incorrectly, please refer to instructions dump. */
    private static void extract(java.lang.String r8, int r9, android.support.p000v4.graphics.PathParser.ExtractFloatResult r10) {
        /*
            r0 = 0
            r10.mEndWithNegOrDot = r0
            r1 = r9
            r2 = r0
            r3 = r2
            r4 = r3
        L_0x0007:
            int r5 = r8.length()
            if (r1 >= r5) goto L_0x003d
            char r5 = r8.charAt(r1)
            r6 = 32
            r7 = 1
            if (r5 == r6) goto L_0x0035
            r6 = 69
            if (r5 == r6) goto L_0x0033
            r6 = 101(0x65, float:1.42E-43)
            if (r5 == r6) goto L_0x0033
            switch(r5) {
                case 44: goto L_0x0035;
                case 45: goto L_0x002a;
                case 46: goto L_0x0022;
                default: goto L_0x0021;
            }
        L_0x0021:
            goto L_0x0031
        L_0x0022:
            if (r3 != 0) goto L_0x0027
            r2 = r0
            r3 = r7
            goto L_0x0037
        L_0x0027:
            r10.mEndWithNegOrDot = r7
            goto L_0x0035
        L_0x002a:
            if (r1 == r9) goto L_0x0031
            if (r2 != 0) goto L_0x0031
            r10.mEndWithNegOrDot = r7
            goto L_0x0035
        L_0x0031:
            r2 = r0
            goto L_0x0037
        L_0x0033:
            r2 = r7
            goto L_0x0037
        L_0x0035:
            r2 = r0
            r4 = r7
        L_0x0037:
            if (r4 == 0) goto L_0x003a
            goto L_0x003d
        L_0x003a:
            int r1 = r1 + 1
            goto L_0x0007
        L_0x003d:
            r10.mEndPosition = r1
            return
        */
        throw new UnsupportedOperationException("Method not decompiled: android.support.p000v4.graphics.PathParser.extract(java.lang.String, int, android.support.v4.graphics.PathParser$ExtractFloatResult):void");
    }
}
