namespace Challenge.Api.ViewModels.Common;

public class ResultViewModel<T>
{
    public ResultViewModel(T data)
    {
        Result = data;
    }

    public ResultViewModel(T data, List<string> errors)
    {
        Errors = errors;
        Result = data;
    }
    
    public ResultViewModel(string error)
    {
        Errors.Add(error);
    }
    
    public T Result { get; }
    public List<string> Errors { get; } = new();
}