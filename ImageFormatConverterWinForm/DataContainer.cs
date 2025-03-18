using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageFormatConverterWinForm;
public enum TargetImageFormat
{
    png,
    gif,
    jpeg,
    bmp,
    webp,
    icon,
}
public class DataContainer
{
    public List<string> ImportedFiles = new();
    public string[]? SelectedFiles;
    public string[] FormatItems = ["PNG", "GIF", "JPEG", "BMP", "WEBP", "ICON"];
    public int TargetFormatIndex;

}
