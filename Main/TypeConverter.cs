using System;

namespace TESVSnip {
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
    struct TypeConverter {
        [System.Runtime.InteropServices.FieldOffset(0)]
        private uint i;
        [System.Runtime.InteropServices.FieldOffset(0)]
        private int si;
        [System.Runtime.InteropServices.FieldOffset(0)]
        private ushort s;
        [System.Runtime.InteropServices.FieldOffset(0)]
        private short ss;
        [System.Runtime.InteropServices.FieldOffset(0)]
        private float f;
        [System.Runtime.InteropServices.FieldOffset(0)]
        private byte b1;
        [System.Runtime.InteropServices.FieldOffset(1)]
        private byte b2;
        [System.Runtime.InteropServices.FieldOffset(2)]
        private byte b3;
        [System.Runtime.InteropServices.FieldOffset(3)]
        private byte b4;
        [System.Runtime.InteropServices.FieldOffset(0)]
        private sbyte sb1;

        private static TypeConverter tc;
        private static readonly byte[] bytes=new byte[4];

        /*public static float i2f(uint i) {
            tc.i=i;
            return tc.f;
        }*/
        /*public static uint f2i(float f) {
            tc.f=f;
            return tc.i;
        }*/

        public static float h2f(byte b1, byte b2, byte b3, byte b4) {
            tc.b1=b1;
            tc.b2=b2;
            tc.b3=b3;
            tc.b4=b4;
            return tc.f;
        }

        public static object GetObject<T>(byte[] data, int offset)
        {
            T result = default(T);
            if (result is float)
                return h2f(data, offset);
            else if (result is int)
                return h2si(data, offset);
            return default(T);
        }
        public static bool TryGetObject<T>(byte[] data, int offset, out object result)
        {
            result = default(T);
            if (result is float)
            {
                result = h2f(data, offset);
                return true;
            }            
            return false;
        }

        public static float h2f(byte[] data, int offset)
        {
            if (offset + sizeof(float) > data.Length)
                return default(float);
            tc.b1 = data[offset+0];
            tc.b2 = data[offset + 1];
            tc.b3 = data[offset + 2];
            tc.b4 = data[offset + 3];
            return tc.f;
        }
        public static float h2f(ArraySegment<byte> data)
        {
            if (data.Count >= 4)
            {
                tc.b1 = data.Array[data.Offset + 0];
                tc.b2 = data.Array[data.Offset + 1];
                tc.b3 = data.Array[data.Offset + 2];
                tc.b4 = data.Array[data.Offset + 3];
                return tc.f;
            }
            return default(float);
        }

        public static uint h2i(byte b1, byte b2, byte b3, byte b4) {
            tc.b1=b1;
            tc.b2=b2;
            tc.b3=b3;
            tc.b4=b4;
            return tc.i;
        }
        public static uint h2i(ArraySegment<byte> data)
        {
            if (data.Count >= 4)
            {
                tc.b1 = data.Array[data.Offset + 0];
                tc.b2 = data.Array[data.Offset + 1];
                tc.b3 = data.Array[data.Offset + 2];
                tc.b4 = data.Array[data.Offset + 3];
                return tc.i;
            }
            return 0;            
        }
        public static int h2si(byte b1, byte b2, byte b3, byte b4)
        {
            tc.b1=b1;
            tc.b2=b2;
            tc.b3=b3;
            tc.b4=b4;
            return tc.si;
        }
        public static int h2si(byte[] data, int offset)
        {
            if (data.Length >= 4)
            {
                tc.b1 = data[offset + 0];
                tc.b2 = data[offset + 1];
                tc.b3 = data[offset + 2];
                tc.b4 = data[offset + 3];
                return tc.si;
            }
            return 0;            
        }
        public static int h2si(ArraySegment<byte> data)
        {
            if (data.Count >= 4)
            {
                tc.b1 = data.Array[data.Offset + 0];
                tc.b2 = data.Array[data.Offset + 1];
                tc.b3 = data.Array[data.Offset + 2];
                tc.b4 = data.Array[data.Offset + 3];
                return tc.si;
            }
            return 0;
        }

        public static ushort h2s(byte b1, byte b2)
        {
            tc.b1=b1;
            tc.b2=b2;
            return tc.s;
        }
        public static ushort h2s(ArraySegment<byte> data)
        {
            if (data.Count >= 2)
            {
                tc.b1 = data.Array[data.Offset + 0];
                tc.b2 = data.Array[data.Offset + 1];
                return tc.s;
            }
            return default(ushort);
        }
        public static short h2ss(byte b1, byte b2)
        {
            tc.b1=b1;
            tc.b2=b2;
            return tc.ss;
        }
        public static short h2ss(ArraySegment<byte> data)
        {
            if (data.Count >= 2)
            {
                tc.b1 = data.Array[data.Offset + 0];
                tc.b2 = data.Array[data.Offset + 1];
                return tc.ss;
            }
            return default(short);
        }

        public static byte h2b(ArraySegment<byte> data)
        {
            if (data.Count >= 1)
            {
                return data.Array[data.Offset + 0];
            }
            return default(byte);
        }
        public static sbyte h2sb(ArraySegment<byte> data)
        {
            if (data.Count >= 1)
            {
                tc.b1 = data.Array[data.Offset + 0];
                return tc.sb1;
            }
            return default(sbyte);
        }

        private static byte[] UpdateBytes() {
            bytes[0]=tc.b1;
            bytes[1]=tc.b2;
            bytes[2]=tc.b3;
            bytes[3]=tc.b4;
            return bytes;
        }
        public static byte[] f2h(float f) {
            tc.f=f;
            return UpdateBytes();
        }
        public static byte[] i2h(uint i) {
            tc.i=i;
            return UpdateBytes();
        }
        public static byte[] si2h(int si) {
            tc.si=si;
            return UpdateBytes();
        }
        public static byte[] ss2h(short ss) {
            tc.ss=ss;
            return new byte[] { tc.b1, tc.b2 };
        }
        public static byte[] s2h(ushort ss)
        {
            tc.s = ss;
            return new byte[] { tc.b1, tc.b2 };
        }

        /*public static void f2h(float f, byte[] data, int offset) {
            tc.f=f;
            data[offset+0]=tc.b1;
            data[offset+1]=tc.b2;
            data[offset+2]=tc.b3;
            data[offset+3]=tc.b4;
        }*/
        public static void i2h(uint i, byte[] data, int offset) {
            tc.i=i;
            data[offset+0]=tc.b1;
            data[offset+1]=tc.b2;
            data[offset+2]=tc.b3;
            data[offset+3]=tc.b4;
        }
        public static void si2h(int si, byte[] data, int offset) {
            tc.si=si;
            data[offset+0]=tc.b1;
            data[offset+1]=tc.b2;
            data[offset+2]=tc.b3;
            data[offset+3]=tc.b4;
        }
        public static void ss2h(short ss, byte[] data, int offset) {
            tc.ss=ss;
            data[offset+0]=tc.b1;
            data[offset+1]=tc.b2;
        }
        public static void s2h(ushort ss, byte[] data, int offset)
        {
            tc.s = ss;
            data[offset + 0] = tc.b1;
            data[offset + 1] = tc.b2;
        }
        public static bool IsLikelyString(ArraySegment<byte> data)
        {
            bool isAscii = true;
            for (int i = 0; i < data.Count - 1 && isAscii; ++i)
            {
                char c = (char)data.Array[data.Offset + i];
                //if (c == 0) return (i > 0);
                isAscii = !Char.IsControl(c);
            }
            return (isAscii && data.Array[data.Count - 1] == 0);
        }

        public static string GetZString(ArraySegment<byte> data)
        {
            var sb = new System.Text.StringBuilder();
            for (int i = 0; i < data.Count; ++i)
            {
                char c = (char)data.Array[data.Offset + i];
                if (c == 0) return sb.ToString();
                sb.Append(c);
            }
            return sb.ToString();
        }

        public static string GetBString(ArraySegment<byte> data)
        {
            ushort len = h2s(data);
            if (len > 0 && len <= data.Count + 2)
                return TESVSnip.Encoding.CP1252.GetString(data.Array, data.Offset + 2, len);
            return "";
        }

        public static string GetString(ArraySegment<byte> data)
        {
            // remove the tailing null
            int len = data.Count > 0 && data.Array[data.Count - 1] == 0 ? data.Count - 1 : data.Count;
            return TESVSnip.Encoding.CP1252.GetString(data.Array, data.Offset, len);
        }

        public static string GetHexData(byte[] data, int offset, int count)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for (int i = 0; i < count && (offset + i) < data.Length; ++i)
                sb.Append( data[offset + i].ToString("X2") ).Append( " " );            
            return sb.ToString();
        }
        public static string GetHexData(ArraySegment<byte> data)
        {
            return GetHexData(data.Array, data.Offset, data.Count);
        }

        /// <summary>
        /// Encode string including null termination character
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static byte[] str2h(string str)
        {
            int len = TESVSnip.Encoding.CP1252.GetByteCount(str);
            byte[] data = new byte[len + 1];
            TESVSnip.Encoding.CP1252.GetBytes(str,0,len,data,0);
            data[len] = 0;
            return data;
        }

        /// <summary>
        /// Encode short byte length prefixed string
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static byte[] bstr2h(string str)
        {
            int len = TESVSnip.Encoding.CP1252.GetByteCount(str);
            byte[] data = new byte[2 + len];
            Array.Copy(TypeConverter.s2h((ushort)len), 0, data, 0, 2);
            Array.Copy(TESVSnip.Encoding.CP1252.GetBytes(str), 0, data, 2, len);
            return data;
        }

        public static byte[] b2h(byte i)
        {
            return new byte[] { i };
        }

        public static byte[] sb2h(sbyte i)
        {
            return new byte[] { (byte)i };
        }

    }
}
