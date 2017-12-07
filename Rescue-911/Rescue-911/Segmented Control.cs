using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rescue_911
{
    public partial class Segmented_Control : UserControl
    {
        // DATA STRUCTURE
        //Composite Data
        private Special_List<Button> SegmentsBtns;
        private int mSelectedSegment = -1;

        //Public Data
        [Description("Set the width of a single segment"), Category("Data")]
        public int SegmentWidth = 75;

        private string segmentsValue = string.Empty;
        [Description("Set available segments. Use / to separate segements"), Category("Data")]
        public string Segments
        {
            get
            {
                return segmentsValue;
            }
            set
            {
                segmentsValue = value;
                SetSegments(segmentsValue);
            }
        }
        private string availableSegments = "";
        [Description("Set access to segments. Use 't' for granting the access to a view or 'f' to block it. Use / to separate elements"), Category("Data")]
        public string AvailableSegments
        {
            get
            {
                return availableSegments;
            }
            set
            {
                availableSegments = value;
                this.SetAvailableSegments(AvailableSegments);
                Segmented_Control_SizeChanged(null,null);
            }
        }

        //Events
        public event EventHandler SegmentBtn_Click;
        //


        // CONSTRUCTOR
        public Segmented_Control()
        {
            InitializeComponent();

            SegmentsBtns = new Special_List<Button>();
        }


        // FUNCTIONAL METHODS
        public void SetSegments(string Labels)
        {
            lbPreview.Visible = false;

            string[] labelsFetched = Labels.Split('/');

            Controls.Clear();
            SegmentsBtns.Clear();

            for (int i = 0; i < labelsFetched.Length; i++)
            {
                SegmentsBtns.AddItem(new Button());
                SegmentsBtns[i].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                SegmentsBtns[i].Font = new System.Drawing.Font("Franklin Gothic Book",8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                SegmentsBtns[i].UseVisualStyleBackColor = false;
                SegmentsBtns[i].BackColor = System.Drawing.Color.Transparent;
                SegmentsBtns[i].FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
                SegmentsBtns[i].FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
                SegmentsBtns[i].FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
                SegmentsBtns[i].ForeColor = System.Drawing.Color.DodgerBlue;
                SegmentsBtns[i].Name = "btnSegment" + i;
                SegmentsBtns[i].Text = labelsFetched[i];
                SegmentsBtns[i].Size = new Size(SegmentWidth,this.Height);

                SegmentsBtns[i].Left = (int)((double)this.Width / labelsFetched.Length) * i;

                SegmentsBtns[i].Click -= (sender, e) => { };
                SegmentsBtns[i].Click += (sender, e) => {
                    SegmentBtn_Click?.Invoke(sender, e);
                    SetActiveSegment(((Button)sender).Name);
                };      
            }
        }

        public void SetAvailableSegments(string segmentsString)
        {
            if (segmentsString == string.Empty)
                return;

            string[] segmentsStringFetched = segmentsString.Split('/');

            SetSegments(segmentsValue);
            

            if (segmentsStringFetched.Length > SegmentsBtns.Count || segmentsStringFetched.Length < SegmentsBtns.Count)
                return;


            for (int i = 0; i < SegmentsBtns.Count; i++)
            {
                if (segmentsStringFetched[i] == "t")
                {
                    continue;
                }
                else if (segmentsStringFetched[i] == "f")
                {
                    SegmentsBtns[i] = null;
                }
                else
                {
                    SegmentsBtns[i] = null;
                }
            }

            while (SegmentsBtns.Contains(null) == true)
            {
                SegmentsBtns.Remove(null);
            }
            Segmented_Control_SizeChanged(null,null);
            Controls.AddRange(SegmentsBtns.ToArray());
        }

        public void SetActiveSegment(string senderName)
        {
            Button sender = new Button();

            for (int j = 0; j < SegmentsBtns.Count; j++)
            {
                if (SegmentsBtns[j].Name == senderName)
                {
                    sender = SegmentsBtns[j];

                    if (mSelectedSegment != -1)
                    {
                        SegmentsBtns[mSelectedSegment].BackColor = System.Drawing.Color.Transparent;
                        SegmentsBtns[mSelectedSegment].FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
                        SegmentsBtns[mSelectedSegment].FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
                        SegmentsBtns[mSelectedSegment].FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
                        SegmentsBtns[mSelectedSegment].ForeColor = System.Drawing.Color.DodgerBlue;
                        SegmentsBtns[mSelectedSegment].Enabled = true;
                    }

                    sender.BackColor = System.Drawing.Color.DodgerBlue;
                    sender.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
                    sender.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
                    sender.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
                    sender.ForeColor = System.Drawing.Color.White;
                    sender.Enabled = false;

                    mSelectedSegment = j;
                    break;
                }
            }
        }

        // EVENTS HANDLERS
        private void Segmented_Control_SizeChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < SegmentsBtns.Count; i++)
            {
                //SegmentsBtns[i].Width = (int)((double)this.Width / SegmentsBtns.Count - 1 * SegmentsBtns.Count);

                if (i > 0)
                {
                    SegmentsBtns[i].Left = SegmentsBtns[i - 1].Right - 1;
                }
                else
                {
                    SegmentsBtns[i].Left = 0;
                }
            }
        }
        //
    }
}