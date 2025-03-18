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
            var newdir = Path.Combine(directory, "ConvertedImage");
            if (!Directory.Exists(newdir))
            {
                Directory.CreateDirectory(Path.Combine(directory, "ConvertedImage"));
            }
            else
            {
                createDirectory = false;
            }
        }
        foreach (var file in files)
        {
            var formatStr = format.ToString();
            var fileName = Path.ChangeExtension(file, formatStr);
            var directoryInsertIndex = fileName.LastIndexOf(Path.DirectorySeparatorChar);
            if (createDirectory)
            {
                fileName = fileName.Insert(directoryInsertIndex, Path.DirectorySeparatorChar + "ConvertedImage");
            }
            try
            {
                using (var image = Image.FromFile(file))
                {
                    image.Save(fileName, formats[(int)format]);
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