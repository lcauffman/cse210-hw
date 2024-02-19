public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    public string _points;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();
    public abstract bool Complete();

    public virtual string GetDetailString()
    {
        string checkingOff;
        bool isComplete = Complete();


        if (isComplete == true)
        {
            checkingOff = "x";
        }

        else
        {
            checkingOff = " "
        }

        string details = $"[{checkingOff}] {_shortName --{_description}";
        

        return details;
    }
    public abstract string GetStringRepresentation();
}