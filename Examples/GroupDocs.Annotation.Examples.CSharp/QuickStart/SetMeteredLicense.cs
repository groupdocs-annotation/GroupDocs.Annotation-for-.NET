using System;

namespace GroupDocs.Annotation.Examples.CSharp
{
    /// <summary>
    /// This example demonstrates how to set Metered license.
    /// Learn more about Metered license at https://purchase.groupdocs.com/faqs/licensing/metered.
    /// </summary>
    class SetMeteredLicense
    {
        public static void Run()
        {
            Console.WriteLine("\n--------------------------------------------------------------------------------------------------");
            Console.WriteLine("[Example Basic Usage] # SetMeteredLicense : how to set Metered license.");


            string publicKey = "*****";
            string privateKey = "*****";
            Metered metered = new Metered();
            metered.SetMeteredKey(publicKey, privateKey);
            Console.WriteLine("License set successfully.");
        }
    }
}