using Microsoft.AspNetCore.Components;

namespace BlazorApp;

public class CounterBase: ComponentBase
{
    public int currentCount = 0;

    public void IncrementCount()
    {
        currentCount++;
    }
}