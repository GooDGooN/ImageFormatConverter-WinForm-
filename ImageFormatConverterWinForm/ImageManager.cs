using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageFormatConverterWinForm;

public class ImageManager
{
    private static List<string> files = new();
    private static ImageFormat[] formats = [
        ImageFormat.Png,
        ImageFormat.Gif,
        ImageFormat.Jpeg,
        ImageFormat.Bmp,
        ImageFormat.Webp,
        ImageFormat.Icon,
    ];
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

    public static void ExportImages(IEnumerable<string> files, string directory, TargetImageFormat format, bool createDirectory)
    {
        if (createDirectory)
        {
            var olddir = directory;
            directory = Path.Combine(directory, "ConvertedImage");
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(Path.Combine(olddir, "ConvertedImage"));
            }
        }
        foreach (var file in files)
        {
            var formatStr = format.ToString();
            var fileName = Path.Combine(directory, Path.GetFileName(file));
            fileName = Path.ChangeExtension(fileName, formatStr);
            try
            {
                using (var image = Image.FromFile(file))
                {
                    if (!Path.Exists(fileName))
                    {
                        image.Save(fileName, formats[(int)format]);
                    }
                }
            }
            catch
            {
                MessageBox.Show($"ERROR:{fileName}\nThere is no Folder!\ndid you delete folder while converting?");
                return;
            }
        }

        MessageBox.Show($"saved at {directory}");
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