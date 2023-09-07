# Better Maui Converters
Sample app for better ways of working with IValueConverter's in Maui



When using a value converter, there is alot of boilerplate type checking to perform. Also when you test the converter you have to to extra casting (since the return type of `IValueConverter` is `object`).



This sample provides 2 base classes which perform the casting & type checking, all your converter needs to do is specify the value & return types:

```csharp
public class YourConverter : ConverterBase<string, Color>
{
	public Color Convert(string value, Type TargetType, object? parameter, CultureInfo culture)
    {
        ...
    }
    
    public string ConvertBack(Color value, Type TargetType, object? parameter, CultureInfo culture)
    {
        ...
    }
}
```

Add parameter as the third type argument:

```csharp
public class YourConverter : ConverterBase<string, Color, int>
{
	public Color Convert(string value, Type TargetType, int parameter, CultureInfo culture)
    {
        ...
    }
    
    public string ConvertBack(Color value, Type TargetType, int parameter, CultureInfo culture)
    {
        ...
    }
}
```



Currently this is just a sample project, I think these classes could be useful in a library, however I need to battle test them first!
