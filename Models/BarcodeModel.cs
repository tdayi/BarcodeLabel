using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BarcodeLabel.Models
{
    public class BarcodeModel
    {
        public BarcodeModel()
        {
            this.BarcodeList = new List<BarcodeItem>();
        }

        public string LabelLeftMargin { get; set; }
        public string LabelRightMargin { get; set; }
        public string LabelTopMargin { get; set; }
        public string LabelBottomMargin { get; set; }

        public string LabelLeftPadding { get; set; }
        public string LabelRightPadding { get; set; }
        public string LabelTopPadding { get; set; }
        public string LabelBottomPadding { get; set; }

        public string LabelWidth { get; set; }
        public string LabelHeight { get; set; }

        public string PageWidth { get; set; }
        public string PageLeftMargin { get; set; }
        public string PageRightMargin { get; set; }
        public string PageTopMargin { get; set; }
        public string PageBottomMargin { get; set; }

        public List<BarcodeItem> BarcodeList { get; set; }
    }

    public class BarcodeItem
    {
        public string BarcodeLeftText { get; set; }
        public string BarcodeTopText { get; set; }
        public string BarcodeData { get; set; }
    }
}