using BarcodeLabel.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BarcodeLabel.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            BarcodeModel barcodeModel = new BarcodeModel();

            barcodeModel.LabelLeftMargin = CmToInc(0);
            barcodeModel.LabelRightMargin = CmToInc(0.3m);
            barcodeModel.LabelTopMargin = CmToInc(0.3m);
            barcodeModel.LabelBottomMargin = CmToInc(0);

            barcodeModel.LabelLeftPadding = CmToInc(0.1m);
            barcodeModel.LabelRightPadding = CmToInc(0.1m);
            barcodeModel.LabelTopPadding = CmToInc(0.1m);
            barcodeModel.LabelBottomPadding = CmToInc(0.1m);

            barcodeModel.LabelWidth = CmToInc(6.4m);
            barcodeModel.LabelHeight = CmToInc(3.8m);

            barcodeModel.PageWidth = CmToInc(21);
            barcodeModel.PageLeftMargin = CmToInc(0.7m);
            barcodeModel.PageRightMargin = CmToInc(0.7m);
            barcodeModel.PageTopMargin = CmToInc(1);
            barcodeModel.PageBottomMargin = CmToInc(1);

            for (int i = 0; i < 21; i++)
            {
                BarcodeItem barcodeItem = new BarcodeItem();
                barcodeItem.BarcodeData = (new Random().Next(12345, 99999).ToString() + i).PadLeft(8, '0');
                barcodeItem.BarcodeTopText = "KKK KUTUPHANESI";
                barcodeItem.BarcodeLeftText = "KKT 11-120 (A) </br> N567y </br> 2017";
                barcodeModel.BarcodeList.Add(barcodeItem);
            }

            return View(barcodeModel);
        }

        private static string CmToInc(decimal cm)
        {
            string inch = "";

            if (cm <= 0)
            {
                inch = "0in";
            }
            else
            {
                inch = (cm / 2.4m).ToString("N2", CultureInfo.GetCultureInfo("en-US")) + "in";
            }

            return inch;
        }
    }
}