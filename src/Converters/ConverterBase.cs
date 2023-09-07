using System.Globalization;

namespace BetterConverters.Converters;
#nullable enable
public abstract class ConverterBase<TValue, TResponse> : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is not null && value is not TValue)
        {
            throw new NotSupportedException($"Value must be of type: {typeof(TValue)}, actually was: {value.GetType()}");
        }

        if (value is TValue tValue)
        {
            return Convert(tValue, targetType, parameter, culture);
        }

        return Convert(default, targetType, parameter, culture);
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }

    protected abstract TResponse? Convert(TValue? value, Type targetType, object? parameter, CultureInfo culture);

    protected abstract TValue? ConvertBack(TResponse? value, Type targetType, object? parameter, CultureInfo culture);
}

public abstract class ConverterBase<TValue, TResponse, TParameter> : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is not null && value is not TValue)
        {
            throw new NotSupportedException($"Value was not of type: {typeof(TValue)}, actually was: {value.GetType()}");
        }

        if (parameter is not null && parameter is not TParameter)
        {
            throw new NotSupportedException($"Parameter was not of type: {typeof(TParameter)}, actually was: {parameter.GetType()}");
        }

        if (value is TValue tValue && parameter is TParameter tParameter)
        {
            return Convert(tValue, targetType, tParameter, culture);
        }

        if (value is null && parameter is null)
        {
            return Convert(default, targetType, default, culture);
        }
        else if (value is not null && parameter is null)
        {
            return Convert((TValue)value, targetType, default, culture);
        }
        else // if (value is null && parameter is not null)
        {
            // Parameter is not null, this is the end of the if!
            return Convert(default, targetType, (TParameter)parameter!, culture);
        }
    }

    public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }

    protected abstract TResponse? Convert(TValue? value, Type targetType, TParameter? parameter, CultureInfo culture);

    protected abstract TValue? ConvertBack(TResponse? value, Type targetType, TParameter? parameter, CultureInfo culture);
}
#nullable disable