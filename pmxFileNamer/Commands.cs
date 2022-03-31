using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;
using System;

namespace pmxFileNamer
{
    public class Commands
    {

        // Autocad Command
        // Usage: pmxWelcome
        // Returns: "Welcome World."
        [CommandMethod("pmxWelcome")]
        public void pmxWelcome()
        {
            Document doc = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument;
            Editor docEditor = doc.Editor;

            docEditor.WriteMessage("Welcome World.");
        }

        // Display Insert Notes
        // Usage: (setq args (list (cons 2 "Draft")cons 10 (getpoint))))(displayinsnotes args)
        [LispFunction("DisplayInsNotes")]
        static public Object DisplayInsNotes(ResultBuffer rbArgs)
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

        // AutoCAD lisp Command
        // Usage: (pmxHello "World." " Looks Good.")
        // Returns: "Hello World. Looks Good."
        [LispFunction("pmxHello")]
        static public Object pmxHello(ResultBuffer rbArgs)
        {
            Object strReturn = string.Empty;

            if (rbArgs != null)
            {
                string strReturnFirstParam = "";
                string strReturnSecondParam = "";

                int nCnt = 0;
                foreach (TypedValue rb in rbArgs)
                {
                    if (rb.TypeCode == (int)Autodesk.AutoCAD.Runtime.LispDataType.Text)
                    {
                        switch (nCnt)
                        {
                            case 0:
                                strReturnFirstParam = rb.Value.ToString();
                                break;
                            case 1:
                                strReturnSecondParam = rb.Value.ToString();
                                break;
                        }

                        nCnt = nCnt + 1;
                    }
                }

                strReturn = "Hello: " + strReturnFirstParam + strReturnSecondParam;

            }

            return strReturn;
        }
    } // end class
}
