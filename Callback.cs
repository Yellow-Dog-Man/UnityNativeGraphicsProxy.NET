using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace NativeGraphics.NET
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void RenderEventDelegate();

    public static class Callback
    {
        [DllImport("NativeGraphics")]
        public static extern System.IntPtr GetRenderEventFunc();

        [DllImport("NativeGraphics")]
        public static extern void SetUpdateCallback(RenderEventDelegate callback);
    }
}
