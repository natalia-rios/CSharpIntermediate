namespace WorkflowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var workFlow = new Workflow();
            
            workFlow.Add(new UploadVideo());
            workFlow.Add(new EncodeVideo());
            workFlow.Add(new SendEmail());
            workFlow.Add(new ProcessVideo());
            
            var engine = new WorkflowEngine();
            engine.Run(workFlow);

            Console.ReadLine();
        }
    }
    
}
