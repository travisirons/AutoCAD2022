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

namespace devStandardsManager
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
            //if (cmbNoteTypes.Items.Count == 0)
            //{
            //    ;
            //    cmbNoteTypes.Items.Add("General Disclaimer");
            //    cmbNoteTypes.Items.Add("Confidential");
            //    cmbNoteTypes.Items.Add("Draft");
            //}
            tabControl1.SelectedIndex = 0;

            if (DialogValues != null)
            {
                foreach (TypedValue val in DialogValues)
                {
                    switch ((Int32)val.TypeCode)
                    {
                        case 5005:
                            tabControl1.SelectTab("tabTextStyles");
                            break;
                        case 5003:
                            tabControl1.SelectedIndex = (Int16)val.Value;
                            break;
                    }
                }


            }

        }


        //private void cmbNoteTypes_Leave(object sender, EventArgs e)
        //{
        //    if (cmbNoteTypes.SelectedItem != null)
        //    {
        //        g_NoteType = cmbNoteTypes.SelectedItem.ToString();
        //    }
        //    else
        //    {
        //        g_NoteType = "";
        //    }
        //}

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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    if (boxTab0Groups.Items.Count == 0)
                    {
                        boxTab0Groups.Items.Add("<< Load All >>");
                        boxTab0Groups.Items.Add("NOTE12");
                        boxTab0Groups.Items.Add("NOTE10");
                        boxTab0Groups.Items.Add("SUBTITLE");
                        boxTab0Groups.Items.Add("TITLE");
                        boxTab0Groups.Items.Add("SURVEY");
                        boxTab0Groups.Items.Add("PLAT");
                        boxTab0Groups.Items.Add("PARCEL");
                        boxTab0Groups.Items.Add("LOT");
                        boxTab0Groups.Items.Add("MATCH");
                        boxTab0Groups.Items.Add("FIGNOTE");
                        boxTab0Groups.Items.Add("FIGSUBTITLE");
                        boxTab0Groups.Items.Add("FIGTITLE");
                        boxTab0Groups.Items.Add("TITLESHEET");
                    }
                    break;
                case 1:
                    if (boxTab1Groups.Items.Count == 0)
                    {         
                        boxTab1Groups.Items.Add("Dim Style Groups");
                        boxTab1Groups.Items.Add("Confidential");
                        boxTab1Groups.Items.Add("Draft");
                    }
                    break;
                case 2:
                    if (boxTab2Groups.Items.Count == 0)
                    {
                        boxTab2Groups.Items.Add("Leader Style Groups");
                        boxTab2Groups.Items.Add("Confidential");
                        boxTab2Groups.Items.Add("Draft");
                    }
                    break;
                case 3:
                    if (boxTab3Groups.Items.Count == 0)
                    {
                        boxTab3Groups.Items.Add("Linetype groups");
                        boxTab3Groups.Items.Add("Confidential");
                        boxTab3Groups.Items.Add("Draft");
                    }
                    break;
            }

        }



        //private void btnInsPoint_Click(object sender, EventArgs e)
        //{
        //    Document doc = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument;
        //    Editor docEditor = doc.Editor;

        //    EditorUserInteraction docEditorUI = docEditor.StartUserInteraction(this);

        //    try
        //    {
        //        PromptPointOptions pPointOpts = new PromptPointOptions("Specify insertion point: ");
        //        PromptPointResult pPointResult = docEditor.GetPoint(pPointOpts);

        //        if (pPointResult.Status == PromptStatus.OK)
        //        {
        //            g_InsPoint = pPointResult.Value;
        //            txtInsPoint.Text = pPointResult.Value.ToString();
        //        }
        //    }
        //    catch (System.Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        throw;
        //    }
        //    finally
        //    {
        //        docEditorUI.End();
        //    }


        //}
    }
}
