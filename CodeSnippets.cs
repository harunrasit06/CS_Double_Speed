
namespace VisualStudioTips
{
    public class CodeSnippets
    {
        // Put the cursor here and type "ctor" and then press the Tab. This will create a constructor for this class.
        public CodeSnippets()
        {
            
        }


        // Now put the cursor here and type "prop" and then press the Tab. This will create an auto-implemented property.
        public string name { get; set; }
        // Note that the "type" is highlighted. Type in "string" and press the Tab. Now you can type a name for this property.
        // Then press the Tab or Enter to finish editing. 



        // Now type "propfull" to create a property with a private field. Press the tab and specify the values accordingly.
        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }
       

        public void Start()
        {
            // Put the cursor here and type "for" and press the Tab. 
            for (int i = 0; i < 10; i++) { }

            // Do the same with "foreach".
            foreach (var item in collection)
            {

            }

            // Now type "try" to create a try/catch block.
            try
            {

            }
            catch (System.Exception)
            {

                throw;
            }

            // Repeat with "tryf" to create a try/finally block.
            try
            {

            }
            finally
            {

            }

            // Now create a for loop with "for".
            for (int i = 0;i < 10;i++) { }

            // Or a for loop that decrements the loop variable using "forr".
            for (int i = length - 1; i >= 0; i--)
            {
                
            }
        }
    }
}
