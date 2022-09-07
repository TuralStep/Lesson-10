using Documents.DocProgram;

namespace Documents.ProDocProgram;

class ProDocumentProgram : DocumentProgram
{
    public sealed override void EditDocument()
    {
        Console.WriteLine("Document Edited...");
    }

    public override void SaveDocument()
    {
        Console.WriteLine("Document saved in .doc format , buy expert packet to save documents in .pdf format...");
    }

}