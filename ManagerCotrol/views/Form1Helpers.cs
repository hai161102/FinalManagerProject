using System;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace ManagerCotrol
{
    public class Form1Helpers
    {
        public static string SIGN_IN = "sign_in";
        public static string SIGN_IN_ACC = "SIGN_IN_ACC";
        public static string SIGN_UP_ACC = "SIGN_UP_ACC";
        public static string NOTIFY_TEXT = "NOTIFY_TEXT";
        public static string VIEW_LOGIN = "VIEW_LOGIN";
        public static string SIGN_UP_NEW_ACC = "SIGN_UP_NEW_ACC";
        public static string SIGNUP_SUCCESS = "Signup Success";

        public static string EXIT_SIGNUP = "EXIT_SIGNUP";
        public static string VIEW_SIGNUP = "VIEW_SIGNUP";
        public static FontFamily FONT_FAMILY = null;

        public static PrivateFontCollection getFont(byte[] font)
        {

            PrivateFontCollection fontCollection = new PrivateFontCollection();

            int fontLenght = font.Length;

            byte[] fontData = font;


            IntPtr memory = Marshal.AllocCoTaskMem(fontLenght);

            Marshal.Copy(fontData, 0, memory, fontLenght);

            fontCollection.AddMemoryFont(memory, fontLenght);
            

            return fontCollection;
        }
    }
}