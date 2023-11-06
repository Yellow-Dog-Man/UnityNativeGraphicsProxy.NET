using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace NativeGraphics.NET
{
    public static partial class OpenGL
    {
        [DllImport("NativeGraphics")]
        public static extern int GL_Init();

        [DllImport("NativeGraphics")]
        public static extern void GL_PixelStoreInt(int name, int param);

        [DllImport("NativeGraphics")]
        public static extern uint GL_GenTexture();

        [DllImport("NativeGraphics")]
        public static extern Error GL_GetError();

        [DllImport("NativeGraphics")]
        public static extern void GL_DeleteTexture(uint texture);

        [DllImport("NativeGraphics")]
        public static extern void GL_BindTexture(TextureTarget type, uint texture);

        [DllImport("NativeGraphics")]
        public static extern void GL_TexStorage2D(TextureTarget type, int levels, TextureFormat internalFormat, int width, int height);

        [DllImport("NativeGraphics")]
        public static extern void GL_TexParameterInt(TextureTarget type, TextureParameterName parameter, int value);

        [DllImport("NativeGraphics")]
        public static extern void GL_TexParameterFloat(TextureTarget type, TextureParameterName parameter, float value);

        [DllImport("NativeGraphics")]
        public static extern void GL_TexImage2D(TextureTarget target, int level, int internalFormat, int width, int height, int border, TextureFormat format, PixelType type, System.IntPtr data);

        [DllImport("NativeGraphics")]
        public static extern void GL_TexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, TextureFormat format, PixelType type, System.IntPtr data);

        [DllImport("NativeGraphics")]
        public static extern void GL_CompressedTexImage2D(TextureTarget target, int level, TextureFormat internalFormat, int width, int height, int border, int imageSize, System.IntPtr data);

        [DllImport("NativeGraphics")]
        public static extern void GL_CompressedTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, TextureFormat format, int imageSize, System.IntPtr data);
    }
}
