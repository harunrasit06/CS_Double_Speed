
namespace VisualStudioTips
{
    // Press Ctrl + F to open up the Find dialog. Type in "Harun". Note that all occurrences of "Harun" are highlighted.
    //
    // Press F3. Note that the occurrence closest to the cursor gets focus. Press F3 again. Or Shift and F3 to go to the previous occurrence. 
    //
    // Now press Ctrl + H. Note that in the Find/Replace window, the focus is still on the search text: "Harun". Hit the Tab to move the focus
    // to the replacement text box. Now type "Harun". Press Alt + A to replace all occurrences of the "Harun" with "Harun". At this point you'll
    // get a confirmation dialog. Press Enter to hit OK. Now the focus is gone from the editor. Put the cursor back somewhere in the editor and 
    // press Ctrl + Z to undo the replacement.
    //
    // Now, press Alt + R. Note that only the instance of "Harun" that's currently in focus is replaced with "Harun" and the focus is on the next instance. 
    // Press F3 to skip. Now press Alt and R again to replace another instance.
    public class FindAndReplace
    {
        public void Start()
        {
            System.Console.WriteLine("Hello, Harun");

            System.Console.WriteLine("Hello, Harun");

            System.Console.WriteLine("Hello, Harun");

            System.Console.WriteLine("Hello, Harun");

            System.Console.WriteLine("Hello, Harun");
        }
    }
}
