using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;
using System;

namespace devStandardsManager
{
    public class Commands
    {
        // Display Insert Notes
        // Usage: (setq args (list (cons 2 "Draft")cons 10 (getpoint))))(displayinsnotes args)
        [LispFunction("pmxstandards")]
        static public Object pmxstandards(ResultBuffer rbArgs)
        {
            frmInsNote frmNotes = new frmInsNote
            {
                DialogValues = rbArgs
            };
            frmNotes.ShowDialog();

            if (frmNotes.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                return frmNotes.DialogValues;
            }
            else
            {
                return null;
            }
        }

    } // end class
}
