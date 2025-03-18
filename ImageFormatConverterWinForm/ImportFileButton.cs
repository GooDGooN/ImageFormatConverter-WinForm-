using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ImageFormatConverterWinForm;

public class ImportFileButton : CustomBaseHandler<string[]>
{
    public void OnClick(object sender, EventArgs e)
    {
        var dialog = new OpenFileDialog();
        dialog.Title = "Select Image Files";
        dialog.Multiselect = true;
        dialog.Filter = "Image Files (*.png, *.gif, *.jpeg, *.bmp, *.webp, *.ico|*.png;*.gif;*.jpeg;*.bmp;*.webp;*.ico|All files (*.*)|*.*";
        if (dialog.ShowDialog() == DialogResult.OK)
        {
            value = ImageManager.GetImageDirectorys();
        }
    }
}
