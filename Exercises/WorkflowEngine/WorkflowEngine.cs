namespace WorkflowEngine;

public class WorkflowEngine {
    public void Run(IWorkflow workflow)
    {
        foreach (IActivity I in workflow.GetActivities())
        {
            I.Execute();
        }
    }
}
