using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageFormatConverterWinForm;

public class ImageManager
{
    private static List<string> files = new();
    public static string[] GetImageDirectorys(params string[] names)
    {
        files.Clear();
        if (Directory.Exists(names[0]))
        {
            foreach (var file in Directory.GetFiles(names[0]))
            {
                if (IsImageFormat(file))
                {
                    files.Add(file);
                }
            }
        }
        else
        {
            foreach (var file in names)
            {
                if (IsImageFormat(file))
                {
                    files.Add(file);
                }
            }
        }

        return files.ToArray();
    }

    private static bool IsImageFormat(string file)
    {
        try
        {
            using (var target = Image.FromFile(file))
            {
                if (target != null)
                {
                    return true;
                }
                return false;
            }
        }
        catch
        {
            return false;
        }
    }
}