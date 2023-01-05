namespace WorkflowEngine;

public class Workflow: IWorkflow
{
    private readonly IList<IActivity> _activities;
    
    public Workflow()
    {
        _activities = new List<IActivity>();
    }
    
    public IEnumerable<IActivity> GetActivities()
    {
        return _activities;
    }
    
    public void Add(IActivity activity)
    {
        _activities.Add(activity);
    }

    public void Remove(IActivity activity)
    {
        _activities.Remove(activity);
    }
}