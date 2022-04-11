namespace HelloMVC.Helpers
{
    public class Tools
    {
        static public string GetControllerName(string controllerName)
        {
            int posEntryController = controllerName.IndexOf("Controller");

            if (posEntryController == -1) return "";

            return controllerName.Substring(0, posEntryController);
        }

        static public string GetReversedString(string value)
        {
            char[] charArray = value.ToCharArray();
            Array.Reverse(charArray);

            return new string(charArray);
        }
    }
}
