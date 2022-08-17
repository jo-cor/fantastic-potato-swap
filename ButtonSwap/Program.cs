using System;
using System.Runtime.InteropServices;

namespace ButtonSwap
{
   internal class Program
   {
      public const Int32 SM_SWAPBUTTON = 23;

      static void Main(string[] args)
      {
         SwapMouseButton(GetSystemMetrics(SM_SWAPBUTTON) == 0 ? 1 : 0);
      }

      /// <summary>
      /// https://docs.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-getsystemmetrics
      /// </summary>
      /// <param name="nIndex">The system metric or configuration setting to be retrieved. This parameter can be one of the following values. 
      /// Note that all SM_CX* values are widths and all SM_CY* values are heights. Also note that all settings designed to return Boolean 
      /// data represent TRUE as any nonzero value, and FALSE as a zero value.</param>
      /// <returns></returns>
      [DllImport("user32.dll")]
      public static extern Int32 GetSystemMetrics(Int32 nIndex);

      /// <summary>
      /// 
      /// </summary>
      /// <param name="bSwap">If this parameter is TRUE, the left button generates right-button messages and the right button generates 
      /// left-button messages. If this parameter is FALSE, the buttons are restored to their original meanings.</param>
      /// <returns></returns>
      [DllImport("user32.dll")]
      public static extern Int32 SwapMouseButton(Int32 bSwap);

   }
}
