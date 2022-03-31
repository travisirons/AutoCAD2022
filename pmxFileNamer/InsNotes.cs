using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pmxFileNamer
{
    public partial class frmInsNote : Form
    {

        private Int16 c_InsPoint = 10;
        private Int16 c_NoteType = 2;
        private Point3d g_InsPoint;
        private string g_NoteType;
        public ResultBuffer DialogValues;

        public frmInsNote()
        {
            InitializeComponent();
        }

        private void frmInsNote_Shown(object sender, EventArgs e)
        {
            if (cmbNoteTypes.Items.Count == 0)
            {
                ;
                cmbNoteTypes.Items.Add("General Disclaimer");
                cmbNoteTypes.Items.Add("Confidential");
                cmbNoteTypes.Items.Add("Draft");
            }

            if (DialogValues != null)
            {
                foreach (TypedValue val in DialogValues)
                {
                    switch ((Int32)val.TypeCode)
                    {
                        case 10:
                            g_InsPoint = (Point3d)val.Value;
                            txtInsPoint.Text = g_InsPoint.ToString();
                            break;
                        case 2:
                            g_NoteType = (string)val.Value;
                            cmbNoteTypes.Text = g_NoteType;
                            break;
                    }
                }
            }

        }


        private void cmbNoteTypes_Leave(object sender, EventArgs e)
        {
            if (cmbNoteTypes.SelectedItem != null)
            {
                g_NoteType = cmbNoteTypes.SelectedItem.ToString();
            }
            else
            {
                g_NoteType = "";
            }
        }

        private void Ok_Button_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();

            //Store values in list of dotted pairs
            {
                DialogValues = new ResultBuffer(
                    new TypedValue((int)LispDataType.ListBegin),
                    new TypedValue((int)LispDataType.Int16, c_InsPoint),
                    new TypedValue((int)LispDataType.Point3d, g_InsPoint),
                    new TypedValue((int)LispDataType.DottedPair),

                    new TypedValue((int)LispDataType.ListBegin),
                    new TypedValue((int)LispDataType.Int16, c_NoteType),
                    new TypedValue((int)LispDataType.Text, g_NoteType),
                    new TypedValue((int)LispDataType.DottedPair));
            }
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btnInsPoint_Click(object sender, EventArgs e)
        {
            Document doc = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument;
            Editor docEditor = doc.Editor;

            EditorUserInteraction docEditorUI = docEditor.StartUserInteraction(this);

            try
            {
                PromptPointOptions pPointOpts = new PromptPointOptions("Specify insertion point: ");
                PromptPointResult pPointResult = docEditor.GetPoint(pPointOpts);

                if (pPointResult.Status == PromptStatus.OK)
                {
                    g_InsPoint = pPointResult.Value;
                    txtInsPoint.Text = pPointResult.Value.ToString();
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                docEditorUI.End();
            }


        }
    }
}
