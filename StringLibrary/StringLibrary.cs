using System;

namespace UtilityLibraries
{
    // The class library, UtilityLibraries.StringLibrary, contains a method named StartsWithUpper.
    public static class StringLibrary
    {
        // StartsWithUpper method returns a Boolean value that indicates whether the current string instance begins with an uppercase character.
        // StartsWithUpper is implemented as an extension method.

        // Note the parameter declaration of this method, it makes you to call this method as if it were a member of the String class
        public static bool StartsWithUpper(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return false;

            // The Unicode standard distinguishes uppercase characters from lowercase characters.
            char ch = str[0];

            // The Char.IsUpper(Char) method returns true if a character is uppercase.
            return char.IsUpper(ch);
        }
    }
}