namespace Documents.DocProgram;

class DocumentProgram
{

    public void OpenDocument()
    {
        Console.WriteLine("Document Opened...");
    }

    public virtual void EditDocument()
    {
        Console.WriteLine("Documents can be edited in Pro and Expert editions...");
    }

    public virtual void SaveDocument()
    {
        Console.WriteLine("Documents can be saved in Pro and Expert editions...");
    }

}