
namespace VisualStudioTips
{
    public class Bookmarks
    {
        public void Start()
        {
            // Put the cursor here and press Ctrl + K, Ctrl + K again. Note the little bookmark icon on the left of this line.
            // Press Ctrl + K, Ctrl + K again to remove the bookmark.
            System.Console.WriteLine("Hello, World");


            // Now put a bookmark here. Then press Ctrl + W, B to view the bookmarks window. Double-click your bookmark and rename it
            // to "Requires Refactoring". You can use this technique to put bookmarks in various part of the code to remind you that
            // you should get back there and do something. 
            System.Console.WriteLine("Hello, World");
            /*Ctrl+K, Ctrl+K - Toggle Bookmark

Ctrl+K, Ctrl+N - Navigate to Next Bookmark

Ctrl+K, Ctrl+P - Navigate to Previous Bookmark

Ctrl+K, Ctrl+W - Open Bookmark Window
            */
        }
    }
}
