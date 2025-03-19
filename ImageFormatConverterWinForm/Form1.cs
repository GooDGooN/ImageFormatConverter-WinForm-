
using System.ComponentModel;
using System.Windows.Forms;
using static System.Windows.Forms.ListBox;

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
public partial class Form1 : Form
{
    private BindingList<string> importedFiles = new();
    private string[] formatItems = ["PNG", "GIF", "JPEG", "BMP", "WEBP", "ICON"];
    private List<string> selectedChanges = new();
    private bool isDelete = false;
    public Form1()
    {
        InitializeComponent();
        foreach (var format in formatItems)
        {
            formatComboBox.Items.Add(format);
        }
        formatComboBox.SelectedIndex = 0;

        fileListBox.DataSource = importedFiles;
    }

    public void OnImportFolderClick(object sender, EventArgs args)
    {
        var dialog = new FolderBrowserDialog();

        if (dialog.ShowDialog() == DialogResult.OK)
        {
            var files = ImageManager.GetImageDirectorys(dialog.SelectedPath);
            foreach (var file in files)
            {
                importedFiles.Add(file);
            }

        }
    }

    public void OnImportFileClick(object sender, EventArgs e)
    {
        var dialog = new OpenFileDialog();
        dialog.Title = "Select Image Files";
        dialog.Multiselect = true;
        dialog.Filter = "Image Files (*.png, *.gif, *.jpeg, *.bmp, *.webp, *.ico|*.png;*.gif;*.jpeg;*.bmp;*.webp;*.ico|All files (*.*)|*.*";
        if (dialog.ShowDialog() == DialogResult.OK)
        {
            var files = ImageManager.GetImageDirectorys(dialog.FileNames);
            foreach (var file in files)
            {
                importedFiles.Add(file);
            }
        }
    }

    public void OnExportClick(object sender, EventArgs e)
    {
        if (importedFiles.Count > 0)
        {
            var dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            var dir = dialog.SelectedPath;
            if (!Directory.Exists(dir))
            {
                MessageBox.Show("Worng Action!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ImageManager.ExportImages(importedFiles, dir, (TargetImageFormat)formatComboBox.SelectedIndex, createDirectoryCheckBox.Checked);
        }
        else
        {
            MessageBox.Show($"There is nothing to convert!");
        }
    }

    public void OnRemoveClick(object sender, EventArgs e)
    {
        isDelete = true;
        foreach (var item in selectedChanges)
        {
            importedFiles.Remove(item);
        }
        isDelete = false;
    }

    public void OnSelectChange(object sender, EventArgs e)
    {
        if (!isDelete)
        {
            selectedChanges.Clear();
            foreach (var item in fileListBox.SelectedItems)
            {
                selectedChanges.Add((string)item);
            }
        }
    }

    public void OnDragFileEnter(object sender, DragEventArgs e)
    {
        e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.All : DragDropEffects.None;
    }

    public void OnDropFile(object sender, DragEventArgs e)
    {
        var dropted = e.Data.GetData(DataFormats.FileDrop);
        if (dropted is string[] files)
        {
            var fileList = files.ToList<string>();
            for (int i = 0; i < fileList.Count; i++)
            {
                if (Directory.Exists(fileList[i]))
                {
                    var insideFiles = Directory.GetFiles(fileList[i]);
                    fileList.RemoveAt(i);
                    fileList.AddRange(insideFiles);
                    i--;
                }
            }

            var images = ImageManager.GetImageDirectorys(fileList.ToArray());

            foreach (var image in images)
            {
                importedFiles.Add(image);
            }

            MessageBox.Show($"{fileList.Count} Files imported");
        }
    }
}