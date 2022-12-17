using NTypewriter.Editor.Config;

namespace WebApplication1
{
    public class user_code : EditorConfig
    {
        public static string HelloWorld()
        {
            return $"// Hello, from the user code";
        }
    }
}
