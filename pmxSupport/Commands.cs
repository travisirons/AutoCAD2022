using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.Windows;

namespace pmxSupport
{
    public class Commands
    {
        // AutoCAD open file dialog for use in lisp
        // Usage: (pmxOpenFileDialog "c:\\pmx\\" "Select Reference File")
        // Returns: Path to selected file as String
        [LispFunction("pmxOpenFileDialog")]
        static public Object pmxOpenFileDialog(ResultBuffer rbArgs)
        {
            Object strReturn = string.Empty;

            if (rbArgs != null)
            {
                string strDefaultPath = "";
                string strTitle = "";

                int nCnt = 0;
                foreach (TypedValue rb in rbArgs)
                {
                    if (rb.TypeCode == (int)Autodesk.AutoCAD.Runtime.LispDataType.Text)
                    {
                        switch (nCnt)
                        {
                            case 0:
                                strDefaultPath = rb.Value.ToString();
                                break;
                            case 1:
                                strTitle = rb.Value.ToString();
                                break;
                        }

                        nCnt = nCnt + 1;
                    }
                }

                OpenFileDialog objFileDialog = new OpenFileDialog(
                    strTitle,
                    strDefaultPath,
                    "dwg",
                    "pmxOpenFileDialog",
                    OpenFileDialog.OpenFileDialogFlags.ForceDefaultFolder
                );

                if (objFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    //strReturn = "something";
                    strReturn = objFileDialog.Filename;


                }

                objFileDialog = null;
            }
            return strReturn;
        }
    } // end class
}
