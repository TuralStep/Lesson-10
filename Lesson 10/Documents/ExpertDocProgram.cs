using Documents.ProDocProgram;

namespace Documents.ExpertDocProgram;

class ExpertDocumentProgram : ProDocumentProgram
{

    public sealed override void SaveDocument()
    {
        Console.WriteLine("Document saved in .pdf format...");
    }

}