using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageFormatConverterWinForm;

public class ImportFolderButton : CustomBaseHandler<string[]>
{
    public void OnClick(object sender, EventArgs args)
    {
        var dialog = new FolderBrowserDialog();
        if (dialog.OkRequiresInteraction)
        {
            value = ImageManager.GetImageDirectorys(dialog.SelectedPath);
        }
    }
}
