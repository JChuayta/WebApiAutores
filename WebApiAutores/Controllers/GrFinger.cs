using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.FileSystemGlobbing.Internal;
using System;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
namespace WebApiAutores.Controllers
{
    public class GrFinger
    {

        //[DllImport("grfinger.dll", EntryPoint = "_GrBiometricDisplay@32")]

        //public static extern int _BiometricDisplay(int tptQuery, int rawImage, int width, int height, int res, int hdc, int handle, int matchContext);

        //public static void BiometricDisplays(Byte[] tptQuery, int rawImage, int width, int height, int res, int hdc, int handle, int matchContext)
        //{
        //    int tptq = ByteArrayToPointer(tptQuery);
        //    _BiometricDisplay(tptq, rawImage, width, height, res, hdc, handle, matchContext);
        //    Marshal.FreeHGlobal(new IntPtr(tptq));
        //}

        //public static void BiometricDisplay(Byte[] tptQuery, Byte[] rawImage,int width,int height,int res,int hdc,int handle,int matchContext)
        //{
        //    int ri = ByteArrayToPointer(rawImage);
        //    BiometricDisplays(tptQuery, ri, width, height, res, hdc, handle, matchContext);
        //    Marshal.FreeHGlobal(new IntPtr(ri));
        //}

        //public static int ByteArrayToPointer(Byte[] array)
        //{
        //    IntPtr buffer = Marshal.StringToHGlobalAuto(array.ToString());
        //    Marshal.Copy(array, 0, buffer, array.Length);
        //    return buffer.ToInt32();
        //}


        ////////public static int Extract(Byte rawimage, ByVal width As Integer, ByVal height As Integer, ByVal res As Integer, ByRef tpt As Byte(), ByRef tptSize As Integer, ByVal context As Integer)
        ////////{
        ////////    Dim ri As Integer = ByteArrayToPointer(rawimage)
        ////////    Extract = Extract(ri, width, height, res, tpt, tptSize, context)
        ////////    Marshal.FreeHGlobal(New IntPtr(ri))
        ////////}
    }
}
