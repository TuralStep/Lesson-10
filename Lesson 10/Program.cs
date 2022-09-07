using Documents.DocProgram;
using Documents.ExpertDocProgram;
using Documents.ProDocProgram;

namespace Lesson_10;

class Program
{
    static void Main()
    {

        Console.WriteLine("---Document Program---");
        Console.Write("\nEnter key : ");
        string? key = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("---Document Program---\n");

        switch (key)
        {
            case "basic":
                DocumentProgram docProgram = new DocumentProgram();

                docProgram.OpenDocument();
                docProgram.EditDocument();
                docProgram.SaveDocument();

                break;
            case "pro":
                DocumentProgram proDocProgram = new ProDocumentProgram();

                proDocProgram.OpenDocument();
                proDocProgram.EditDocument();
                proDocProgram.SaveDocument();

                break;
            case "expert":
                DocumentProgram expertDocProgram = new ExpertDocumentProgram();

                expertDocProgram.OpenDocument();
                expertDocProgram.EditDocument();
                expertDocProgram.SaveDocument();

                break;
            default:

                Console.WriteLine("Unusual key...   ( Try again ) ");

                break;
        }

    }
}