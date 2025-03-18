using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageFormatConverterWinForm;

public class CustomBaseHandler<T>
{
    protected T value
    {
        get;
        set;
    }
    public static implicit operator T(CustomBaseHandler<T> obj)
    {
        return obj.value;
    }
}
