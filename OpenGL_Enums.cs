using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NativeGraphics.NET
{
    public static partial class OpenGL
    {
        public enum TextureTarget
        {
            GL_TEXTURE_2D = 0x0DE1,
            GL_TEXTURE_CUBE_MAP = 0x8513,

            GL_TEXTURE_CUBE_MAP_POSITIVE_X = 0x8515,
            GL_TEXTURE_CUBE_MAP_NEGATIVE_X = 0x8516,
            GL_TEXTURE_CUBE_MAP_POSITIVE_Y = 0x8517,
            GL_TEXTURE_CUBE_MAP_NEGATIVE_Y = 0x8518,
            GL_TEXTURE_CUBE_MAP_POSITIVE_Z = 0x8519,
            GL_TEXTURE_CUBE_MAP_NEGATIVE_Z = 0x851A,
        }

        public enum Error
        {
            GL_NO_ERROR = 0,
            GL_INVALID_ENUM = 0x0500,
            GL_INVALID_VALUE = 0x0501,
            GL_INVALID_OPERATION = 0x0502,
            GL_STACK_OVERFLOW = 0x0503,
            GL_STACK_UNDERFLOW = 0x0504,
            GL_OUT_OF_MEMORY = 0x0505,
        }

        public enum TextureFormat
        {
            GL_STENCIL_INDEX = 0x1901,
            GL_DEPTH_COMPONENT = 0x1902,
            GL_RED = 0x1903,
            GL_GREEN = 0x1904,
            GL_BLUE = 0x1905,
            GL_ALPHA = 0x1906,
            GL_RG = 0x8227,
            GL_RGB = 0x1907,
            GL_SRGB = 0x8C40,
            GL_RGBA = 0x1908,
            GL_SRGB_ALPHA = 0x8C42,

            GL_ALPHA4 = 0x803B,
            GL_ALPHA8 = 0x803C,
            GL_ALPHA12 = 0x803D,
            GL_ALPHA16 = 0x803E,

            GL_RGB4 = 0x804F,
            GL_RGB5 = 0x8050,
            GL_RGB8 = 0x8051,
            GL_SRGB8 = 0x8C41,
            GL_RGB10 = 0x8052,
            GL_RGB12 = 0x8053,
            GL_RGB16 = 0x8054,
            GL_RGBA2 = 0x8055,
            GL_RGBA4 = 0x8056,
            GL_RGB5_A1 = 0x8057,
            GL_RGBA8 = 0x8058,
            GL_SRGB8_ALPHA8 = 0x8C43,
            GL_RGB10_A2 = 0x8059,
            GL_RGBA12 = 0x805A,
            GL_RGBA16 = 0x805B,

            GL_RGBA32F = 0x8814,
            GL_RGB32F = 0x8815,
            GL_RGBA16F = 0x881A,
            GL_RGB16F = 0x881B,

            GL_COMPRESSED_RGB = 0x84ED,
            GL_COMPRESSED_RGBA = 0x84EE,
            GL_COMPRESSED_SRGB = 0x8C48,

            GL_COMPRESSED_RGB8_ETC2 = 0x9274,
            GL_COMPRESSED_SRGB8_ETC2 = 0x9275,
            GL_COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9276,
            GL_COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9277,
            GL_COMPRESSED_RGBA8_ETC2_EAC = 0x9278,
            GL_COMPRESSED_SRGB8_ALPHA8_ETC2_EAC = 0x9279,

            // https://www.khronos.org/registry/OpenGL/extensions/ARB/ARB_texture_compression_rgtc.txt
            GL_COMPRESSED_RED_RGTC1 = 0x8DBB, // should be BC4
            GL_COMPRESSED_RG_RGTC2 = 0x8DBD, // should be BC5

            GL_COMPRESSED_RGB_S3TC_DXT1_EXT = 0x83F0,
            GL_COMPRESSED_RGBA_S3TC_DXT1_EXT = 0x83F1,
            GL_COMPRESSED_RGBA_S3TC_DXT3_EXT = 0x83F2,
            GL_COMPRESSED_RGBA_S3TC_DXT5_EXT = 0x83F3,

            GL_COMPRESSED_SRGB_S3TC_DXT1_EXT = 0x8C4C,

            GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT1_EXT = 0x8C4D,
            GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT3_EXT = 0x8C4E,
            GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT5_EXT = 0x8C4F,

            GL_COMPRESSED_RGBA_BPTC_UNORM_ARB = 0x8E8C, // should be BC7?
            GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM_ARB = 0x8E8D,
            GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT_ARB = 0x8E8E,
            GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT_ARB = 0x8E8F, // BC6?

            GL_COMPRESSED_RGBA_ASTC_4x4_KHR = 0x93B0,
            GL_COMPRESSED_RGBA_ASTC_5x4_KHR = 0x93B1,
            GL_COMPRESSED_RGBA_ASTC_5x5_KHR = 0x93B2,
            GL_COMPRESSED_RGBA_ASTC_6x5_KHR = 0x93B3,
            GL_COMPRESSED_RGBA_ASTC_6x6_KHR = 0x93B4,
            GL_COMPRESSED_RGBA_ASTC_8x5_KHR = 0x93B5,
            GL_COMPRESSED_RGBA_ASTC_8x6_KHR = 0x93B6,
            GL_COMPRESSED_RGBA_ASTC_8x8_KHR = 0x93B7,
            GL_COMPRESSED_RGBA_ASTC_10x5_KHR = 0x93B8,
            GL_COMPRESSED_RGBA_ASTC_10x6_KHR = 0x93B9,
            GL_COMPRESSED_RGBA_ASTC_10x8_KHR = 0x93BA,
            GL_COMPRESSED_RGBA_ASTC_10x10_KHR = 0x93BB,
            GL_COMPRESSED_RGBA_ASTC_12x10_KHR = 0x93BC,
            GL_COMPRESSED_RGBA_ASTC_12x12_KHR = 0x93BD,

            GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x4_KHR = 0x93D0,
            GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x4_KHR = 0x93D1,
            GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x5_KHR = 0x93D2,
            GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x5_KHR = 0x93D3,
            GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x6_KHR = 0x93D4,
            GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x5_KHR = 0x93D5,
            GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x6_KHR = 0x93D6,
            GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x8_KHR = 0x93D7,
            GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x5_KHR = 0x93D8,
            GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x6_KHR = 0x93D9,
            GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x8_KHR = 0x93DA,
            GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x10_KHR = 0x93DB,
            GL_COMPRESSED_SRGB8_ALPHA8_ASTC_12x10_KHR = 0x93DC,
            GL_COMPRESSED_SRGB8_ALPHA8_ASTC_12x12_KHR = 0x93DD,

            //GL_VIEW_CLASS_S3TC_DXT1_RGB = 0x82CC,
            //GL_VIEW_CLASS_S3TC_DXT1_RGBA = 0x82CD,
            //GL_VIEW_CLASS_S3TC_DXT3_RGBA = 0x82CE,
            //GL_VIEW_CLASS_S3TC_DXT5_RGBA = 0x82CF,
        }

        public enum PixelType
        {
            GL_BYTE = 0x1400,
            GL_UNSIGNED_BYTE = 0x1401,
            GL_SHORT = 0x1402,
            GL_UNSIGNED_SHORT = 0x1403,
            GL_INT = 0x1404,
            GL_UNSIGNED_INT = 0x1405,
            GL_FLOAT = 0x1406,
            GL_DOUBLE = 0x140A,
            GL_HALF_FLOAT = 0x140B,
        }

        public enum ParameterName
        {
            GL_NEAREST = 0x2600,
            GL_LINEAR = 0x2601,

            GL_REPEAT = 0x2901,
            GL_CLAMP_TO_EDGE = 0x812F,
            GL_MIRRORED_REPEAT = 0x8370,

            GL_NEAREST_MIPMAP_NEAREST = 0x2700,
            GL_LINEAR_MIPMAP_NEAREST = 0x2701,
            GL_NEAREST_MIPMAP_LINEAR = 0x2702,
            GL_LINEAR_MIPMAP_LINEAR = 0x2703,

            GL_PACK_ALIGNMENT = 0x0D05,
            GL_UNPACK_ALIGNMENT = 0x0CF5,
        }

        public enum TextureParameterName
        {
            GL_TEXTURE_MAG_FILTER = 0x2800,
            GL_TEXTURE_MIN_FILTER = 0x2801,

            GL_TEXTURE_WRAP_S = 0x2802,
            GL_TEXTURE_WRAP_T = 0x2803,

            GL_TEXTURE_MIN_LOD = 0x813A,
            GL_TEXTURE_MAX_LOD = 0x813B,
            GL_TEXTURE_BASE_LEVEL = 0x813C,
            GL_TEXTURE_MAX_LEVEL = 0x813D,
        }
    }
}
