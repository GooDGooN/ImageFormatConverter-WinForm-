using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageFormatConverterWinForm;



public class FileList
{
    private string[] files
    {
        get;
        set;
    }
    public static implicit operator string[](FileList obj)
    {
        return obj.files;
    }

    public void DragEnter(object sender, DragEventArgs e)
    {
        e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.All : DragDropEffects.None;
    }

    public void DropFile(object sender, DragEventArgs e)
    {
        var dropted = e.Data.GetData(DataFormats.FileDrop);
        if(dropted is string[] strs) 
        {
            files = ImageManager.GetImageDirectorys(strs);
        }
        files = null;
    }
}
